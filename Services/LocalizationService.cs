using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.JSInterop;
using PdfMerger.Client.Models;

namespace PdfMerger.Client.Services;

/// <summary>
/// JSON-based localization service with RTL support and localStorage persistence
/// </summary>
public class LocalizationService : ILocalizationService
{
    private readonly HttpClient _httpClient;
    private readonly IJSRuntime _jsRuntime;
    private Dictionary<string, JsonElement> _translations = new();
    private Dictionary<string, JsonElement> _fallbackTranslations = new();
    private string _currentLanguage = "en";
    private bool _isInitialized;

    public event Action? OnLanguageChanged;

    public string CurrentLanguage => _currentLanguage;
    public bool IsRtl => CurrentLanguageInfo.IsRtl;
    public LanguageInfo CurrentLanguageInfo => AvailableLanguages.FirstOrDefault(l => l.Code == _currentLanguage) ?? AvailableLanguages[0];

    public IReadOnlyList<LanguageInfo> AvailableLanguages { get; } = new List<LanguageInfo>
    {
        new() { Code = "en", EnglishName = "English", NativeName = "English", IsRtl = false, FontFamily = "Roboto, sans-serif", FlagEmoji = "🇺🇸" },
        new() { Code = "prs", EnglishName = "Dari", NativeName = "دری", IsRtl = true, FontFamily = "Vazirmatn, Roboto, sans-serif", FlagEmoji = "🇦🇫" },
        new() { Code = "ps", EnglishName = "Pashto", NativeName = "پښتو", IsRtl = true, FontFamily = "Vazirmatn, Roboto, sans-serif", FlagEmoji = "🇦🇫" },
        new() { Code = "uz", EnglishName = "Uzbek", NativeName = "Oʻzbekcha", IsRtl = false, FontFamily = "Roboto, sans-serif", FlagEmoji = "🇺🇿" },
        new() { Code = "tk", EnglishName = "Turkmen", NativeName = "Türkmençe", IsRtl = false, FontFamily = "Roboto, sans-serif", FlagEmoji = "🇹🇲" },
        new() { Code = "haz", EnglishName = "Hazaragi", NativeName = "هزارگی", IsRtl = true, FontFamily = "Vazirmatn, Roboto, sans-serif", FlagEmoji = "🇦🇫" },
        new() { Code = "aiq", EnglishName = "Aimaq", NativeName = "ایماق", IsRtl = true, FontFamily = "Vazirmatn, Roboto, sans-serif", FlagEmoji = "🇦🇫" },
        new() { Code = "bal", EnglishName = "Balochi", NativeName = "بلوچی", IsRtl = true, FontFamily = "Vazirmatn, Roboto, sans-serif", FlagEmoji = "🇦🇫" },
        new() { Code = "psi", EnglishName = "Pashai", NativeName = "پشه‌یی", IsRtl = true, FontFamily = "Vazirmatn, Roboto, sans-serif", FlagEmoji = "🇦🇫" },
        new() { Code = "ktr", EnglishName = "Nuristani", NativeName = "نورستانی", IsRtl = true, FontFamily = "Vazirmatn, Roboto, sans-serif", FlagEmoji = "🇦🇫" }
    };

    public LocalizationService(HttpClient httpClient, IJSRuntime jsRuntime)
    {
        _httpClient = httpClient;
        _jsRuntime = jsRuntime;
    }

    public async Task InitializeAsync()
    {
        if (_isInitialized) return;

        try
        {
            // Load fallback (English) translations first
            _fallbackTranslations = await LoadTranslationsAsync("en");

            // Try to get saved language preference
            var savedLanguage = await GetSavedLanguageAsync();

            if (!string.IsNullOrEmpty(savedLanguage) && AvailableLanguages.Any(l => l.Code == savedLanguage))
            {
                _currentLanguage = savedLanguage;
            }
            else
            {
                // Try to detect browser language
                _currentLanguage = await DetectBrowserLanguageAsync() ?? "en";
            }

            // Load current language translations
            if (_currentLanguage != "en")
            {
                _translations = await LoadTranslationsAsync(_currentLanguage);
            }
            else
            {
                _translations = _fallbackTranslations;
            }

            // Apply initial direction and meta tags
            await ApplyLanguageSettingsAsync();

            _isInitialized = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error initializing localization: {ex.Message}");
            _currentLanguage = "en";
            _translations = _fallbackTranslations;
            _isInitialized = true;
        }
    }

    public async Task SetLanguageAsync(string languageCode)
    {
        if (!AvailableLanguages.Any(l => l.Code == languageCode))
        {
            Console.WriteLine($"Language '{languageCode}' is not supported");
            return;
        }

        if (_currentLanguage == languageCode) return;

        _currentLanguage = languageCode;

        // Load new translations
        if (languageCode == "en")
        {
            _translations = _fallbackTranslations;
        }
        else
        {
            _translations = await LoadTranslationsAsync(languageCode);
        }

        // Save preference
        await SaveLanguagePreferenceAsync(languageCode);

        // Apply direction and meta tags
        await ApplyLanguageSettingsAsync();

        // Notify subscribers
        OnLanguageChanged?.Invoke();
    }

    public string T(string key, params object[] args)
    {
        var value = GetNestedValue(_translations, key) ?? GetNestedValue(_fallbackTranslations, key);

        if (value == null)
        {
            return key; // Return key as fallback
        }

        var text = value.Value.GetString() ?? key;

        // Handle format arguments
        if (args.Length > 0)
        {
            try
            {
                text = string.Format(text, args);
            }
            catch (FormatException)
            {
                // If format fails, return the raw text
            }
        }

        return text;
    }

    public string Translate(string key, params object[] args) => T(key, args);

    public bool HasKey(string key)
    {
        return GetNestedValue(_translations, key) != null || GetNestedValue(_fallbackTranslations, key) != null;
    }

    private async Task<Dictionary<string, JsonElement>> LoadTranslationsAsync(string languageCode)
    {
        try
        {
            var json = await _httpClient.GetFromJsonAsync<Dictionary<string, JsonElement>>($"locales/{languageCode}.json");
            return json ?? new Dictionary<string, JsonElement>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading translations for '{languageCode}': {ex.Message}");
            return new Dictionary<string, JsonElement>();
        }
    }

    private JsonElement? GetNestedValue(Dictionary<string, JsonElement> translations, string key)
    {
        if (translations == null || string.IsNullOrEmpty(key)) return null;

        var parts = key.Split('.');
        JsonElement? current = null;

        for (int i = 0; i < parts.Length; i++)
        {
            var part = parts[i];

            if (i == 0)
            {
                if (!translations.TryGetValue(part, out var element))
                    return null;
                current = element;
            }
            else
            {
                if (current?.ValueKind != JsonValueKind.Object)
                    return null;

                if (!current.Value.TryGetProperty(part, out var element))
                    return null;
                current = element;
            }
        }

        return current?.ValueKind == JsonValueKind.String ? current : null;
    }

    private async Task<string?> GetSavedLanguageAsync()
    {
        try
        {
            return await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", "language");
        }
        catch
        {
            return null;
        }
    }

    private async Task SaveLanguagePreferenceAsync(string languageCode)
    {
        try
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "language", languageCode);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving language preference: {ex.Message}");
        }
    }

    private async Task<string?> DetectBrowserLanguageAsync()
    {
        try
        {
            var browserLang = await _jsRuntime.InvokeAsync<string>("eval", "navigator.language || navigator.userLanguage");

            if (string.IsNullOrEmpty(browserLang)) return null;

            // Extract primary language code
            var primaryCode = browserLang.Split('-')[0].ToLowerInvariant();

            // Check if we support this language
            var supported = AvailableLanguages.FirstOrDefault(l =>
                l.Code == primaryCode || l.Code == browserLang.ToLowerInvariant());

            return supported?.Code;
        }
        catch
        {
            return null;
        }
    }

    private async Task ApplyLanguageSettingsAsync()
    {
        try
        {
            var langInfo = CurrentLanguageInfo;

            // Use JavaScript module for applying settings
            await _jsRuntime.InvokeVoidAsync("localization.setDocumentDirection", langInfo.IsRtl ? "rtl" : "ltr");
            await _jsRuntime.InvokeVoidAsync("localization.setDocumentLanguage", langInfo.Code);
            await _jsRuntime.InvokeVoidAsync("localization.setFontFamily", langInfo.FontFamily);

            // Update meta tags with translations
            var seoTitle = T("seo.title");
            var seoDescription = T("seo.description");

            await _jsRuntime.InvokeVoidAsync("localization.updateMetaTags", seoTitle, seoDescription, langInfo.Code);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error applying language settings: {ex.Message}");
        }
    }
}
