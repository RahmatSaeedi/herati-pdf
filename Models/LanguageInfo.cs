namespace PdfMerger.Client.Models;

/// <summary>
/// Represents information about a supported language
/// </summary>
public class LanguageInfo
{
    /// <summary>
    /// Language code (e.g., "en", "prs", "ps")
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// Language name in English (e.g., "English", "Dari", "Pashto")
    /// </summary>
    public string EnglishName { get; set; } = string.Empty;

    /// <summary>
    /// Language name in native script (e.g., "English", "دری", "پښتو")
    /// </summary>
    public string NativeName { get; set; } = string.Empty;

    /// <summary>
    /// Whether the language is right-to-left
    /// </summary>
    public bool IsRtl { get; set; }

    /// <summary>
    /// Font family to use for this language
    /// </summary>
    public string FontFamily { get; set; } = "Roboto, sans-serif";

    /// <summary>
    /// Optional flag emoji for display
    /// </summary>
    public string FlagEmoji { get; set; } = string.Empty;
}
