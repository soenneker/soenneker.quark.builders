using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the border color enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BorderColorEnum
{
    /// <summary>
    /// The primary.
    /// </summary>
    public static readonly BorderColorEnum Primary = new("border-primary");
    /// <summary>
    /// The secondary.
    /// </summary>
    public static readonly BorderColorEnum Secondary = new("border-secondary");
    /// <summary>
    /// The destructive.
    /// </summary>
    public static readonly BorderColorEnum Destructive = new("border-destructive");
    /// <summary>
    /// The muted.
    /// </summary>
    public static readonly BorderColorEnum Muted = new("border-muted");
    /// <summary>
    /// The accent.
    /// </summary>
    public static readonly BorderColorEnum Accent = new("border-accent");
    /// <summary>
    /// The popover.
    /// </summary>
    public static readonly BorderColorEnum Popover = new("border-popover");
    /// <summary>
    /// The card.
    /// </summary>
    public static readonly BorderColorEnum Card = new("border-card");
    /// <summary>
    /// The background.
    /// </summary>
    public static readonly BorderColorEnum Background = new("border-background");
    /// <summary>
    /// The border.
    /// </summary>
    public static readonly BorderColorEnum Border = new("border-border");
    /// <summary>
    /// The input.
    /// </summary>
    public static readonly BorderColorEnum Input = new("border-input");
    /// <summary>
    /// The ring.
    /// </summary>
    public static readonly BorderColorEnum Ring = new("border-ring");
    /// <summary>
    /// The current.
    /// </summary>
    public static readonly BorderColorEnum Current = new("border-current");
    /// <summary>
    /// The white.
    /// </summary>
    public static readonly BorderColorEnum White = new("border-white");
    /// <summary>
    /// The black.
    /// </summary>
    public static readonly BorderColorEnum Black = new("border-black");
    /// <summary>
    /// The transparent.
    /// </summary>
    public static readonly BorderColorEnum Transparent = new("border-transparent");
}
