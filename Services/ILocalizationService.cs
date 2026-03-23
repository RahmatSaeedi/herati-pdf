using PdfMerger.Client.Models;

namespace PdfMerger.Client.Services;

/// <summary>
/// Service interface for multi-language localization support
/// </summary>
public interface ILocalizationService
{
    /// <summary>
    /// Event fired when the language changes
    /// </summary>
    event Action? OnLanguageChanged;

    /// <summary>
    /// Gets the current language code
    /// </summary>
    string CurrentLanguage { get; }

    /// <summary>
    /// Gets whether the current language is RTL
    /// </summary>
    bool IsRtl { get; }

    /// <summary>
    /// Gets information about the current language
    /// </summary>
    LanguageInfo CurrentLanguageInfo { get; }

    /// <summary>
    /// Gets all available languages
    /// </summary>
    IReadOnlyList<LanguageInfo> AvailableLanguages { get; }

    /// <summary>
    /// Initialize the localization service (load saved language preference)
    /// </summary>
    Task InitializeAsync();

    /// <summary>
    /// Set the current language
    /// </summary>
    /// <param name="languageCode">The language code to set</param>
    Task SetLanguageAsync(string languageCode);

    /// <summary>
    /// Get a translated string by key
    /// </summary>
    /// <param name="key">The translation key (supports nested keys like "common.save")</param>
    /// <param name="args">Optional format arguments for placeholders</param>
    /// <returns>The translated string, or the key if not found</returns>
    string T(string key, params object[] args);

    /// <summary>
    /// Get a translated string by key (alias for T)
    /// </summary>
    string Translate(string key, params object[] args);

    /// <summary>
    /// Check if a translation key exists
    /// </summary>
    bool HasKey(string key);
}
