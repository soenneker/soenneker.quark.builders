using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the background color enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BackgroundColorEnum
{
    /// <summary>
    /// The primary.
    /// </summary>
    public static readonly BackgroundColorEnum Primary = new("bg-primary");
    /// <summary>
    /// The secondary.
    /// </summary>
    public static readonly BackgroundColorEnum Secondary = new("bg-secondary");
    /// <summary>
    /// The destructive.
    /// </summary>
    public static readonly BackgroundColorEnum Destructive = new("bg-destructive");
    /// <summary>
    /// The muted.
    /// </summary>
    public static readonly BackgroundColorEnum Muted = new("bg-muted");
    /// <summary>
    /// The accent.
    /// </summary>
    public static readonly BackgroundColorEnum Accent = new("bg-accent");
    /// <summary>
    /// The popover.
    /// </summary>
    public static readonly BackgroundColorEnum Popover = new("bg-popover");
    /// <summary>
    /// The card.
    /// </summary>
    public static readonly BackgroundColorEnum Card = new("bg-card");
    /// <summary>
    /// The background.
    /// </summary>
    public static readonly BackgroundColorEnum Background = new("bg-background");
    /// <summary>
    /// The foreground.
    /// </summary>
    public static readonly BackgroundColorEnum Foreground = new("bg-foreground");
    /// <summary>
    /// The border.
    /// </summary>
    public static readonly BackgroundColorEnum Border = new("bg-border");
    /// <summary>
    /// The white.
    /// </summary>
    public static readonly BackgroundColorEnum White = new("bg-white");
    /// <summary>
    /// The black.
    /// </summary>
    public static readonly BackgroundColorEnum Black = new("bg-black");
    /// <summary>
    /// The transparent.
    /// </summary>
    public static readonly BackgroundColorEnum Transparent = new("bg-transparent");
}
