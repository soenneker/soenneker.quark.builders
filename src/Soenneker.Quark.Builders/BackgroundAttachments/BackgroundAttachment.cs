namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for background attachment.
/// </summary>
[TailwindModifiers(typeof(BackgroundAttachmentBuilder))]
public static partial class BackgroundAttachment
{
    /// <summary>Adds <c>bg-fixed</c>.</summary>
    public static BackgroundAttachmentBuilder Fixed => new("bg-fixed");

    /// <summary>Adds <c>bg-local</c>.</summary>
    public static BackgroundAttachmentBuilder Local => new("bg-local");

    /// <summary>Adds <c>bg-scroll</c>.</summary>
    public static BackgroundAttachmentBuilder Scroll => new("bg-scroll");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackgroundAttachmentBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "bg-"));
}
