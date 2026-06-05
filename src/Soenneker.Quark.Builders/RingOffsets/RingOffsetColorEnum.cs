using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the ring offset color enum.
/// </summary>
[EnumValue<string>]
public sealed partial class RingOffsetColorEnum
{
    /// <summary>
    /// The primary.
    /// </summary>
    public static readonly RingOffsetColorEnum Primary = new("ring-offset-primary");
    /// <summary>
    /// The secondary.
    /// </summary>
    public static readonly RingOffsetColorEnum Secondary = new("ring-offset-secondary");
    /// <summary>
    /// The destructive.
    /// </summary>
    public static readonly RingOffsetColorEnum Destructive = new("ring-offset-destructive");
    /// <summary>
    /// The muted.
    /// </summary>
    public static readonly RingOffsetColorEnum Muted = new("ring-offset-muted");
    /// <summary>
    /// The accent.
    /// </summary>
    public static readonly RingOffsetColorEnum Accent = new("ring-offset-accent");
    /// <summary>
    /// The popover.
    /// </summary>
    public static readonly RingOffsetColorEnum Popover = new("ring-offset-popover");
    /// <summary>
    /// The card.
    /// </summary>
    public static readonly RingOffsetColorEnum Card = new("ring-offset-card");
    /// <summary>
    /// The background.
    /// </summary>
    public static readonly RingOffsetColorEnum Background = new("ring-offset-background");
    /// <summary>
    /// The border.
    /// </summary>
    public static readonly RingOffsetColorEnum Border = new("ring-offset-border");
    /// <summary>
    /// The input.
    /// </summary>
    public static readonly RingOffsetColorEnum Input = new("ring-offset-input");
    /// <summary>
    /// The ring.
    /// </summary>
    public static readonly RingOffsetColorEnum Ring = new("ring-offset-ring");
    /// <summary>
    /// The white.
    /// </summary>
    public static readonly RingOffsetColorEnum White = new("ring-offset-white");
    /// <summary>
    /// The black.
    /// </summary>
    public static readonly RingOffsetColorEnum Black = new("ring-offset-black");
    /// <summary>
    /// The transparent.
    /// </summary>
    public static readonly RingOffsetColorEnum Transparent = new("ring-offset-transparent");
}
