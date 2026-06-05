using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the ring color enum.
/// </summary>
[EnumValue<string>]
public sealed partial class RingColorEnum
{
    /// <summary>
    /// The primary.
    /// </summary>
    public static readonly RingColorEnum Primary = new("ring-primary");
    /// <summary>
    /// The primary foreground.
    /// </summary>
    public static readonly RingColorEnum PrimaryForeground = new("ring-primary-foreground");
    /// <summary>
    /// The secondary.
    /// </summary>
    public static readonly RingColorEnum Secondary = new("ring-secondary");
    /// <summary>
    /// The secondary foreground.
    /// </summary>
    public static readonly RingColorEnum SecondaryForeground = new("ring-secondary-foreground");
    /// <summary>
    /// The destructive.
    /// </summary>
    public static readonly RingColorEnum Destructive = new("ring-destructive");
    /// <summary>
    /// The destructive foreground.
    /// </summary>
    public static readonly RingColorEnum DestructiveForeground = new("ring-destructive-foreground");
    /// <summary>
    /// The muted.
    /// </summary>
    public static readonly RingColorEnum Muted = new("ring-muted");
    /// <summary>
    /// The muted foreground.
    /// </summary>
    public static readonly RingColorEnum MutedForeground = new("ring-muted-foreground");
    /// <summary>
    /// The accent.
    /// </summary>
    public static readonly RingColorEnum Accent = new("ring-accent");
    /// <summary>
    /// The accent foreground.
    /// </summary>
    public static readonly RingColorEnum AccentForeground = new("ring-accent-foreground");
    /// <summary>
    /// The popover.
    /// </summary>
    public static readonly RingColorEnum Popover = new("ring-popover");
    /// <summary>
    /// The popover foreground.
    /// </summary>
    public static readonly RingColorEnum PopoverForeground = new("ring-popover-foreground");
    /// <summary>
    /// The card.
    /// </summary>
    public static readonly RingColorEnum Card = new("ring-card");
    /// <summary>
    /// The card foreground.
    /// </summary>
    public static readonly RingColorEnum CardForeground = new("ring-card-foreground");
    /// <summary>
    /// The background.
    /// </summary>
    public static readonly RingColorEnum Background = new("ring-background");
    /// <summary>
    /// The foreground.
    /// </summary>
    public static readonly RingColorEnum Foreground = new("ring-foreground");
    /// <summary>
    /// The border.
    /// </summary>
    public static readonly RingColorEnum Border = new("ring-border");
    /// <summary>
    /// The input.
    /// </summary>
    public static readonly RingColorEnum Input = new("ring-input");
    /// <summary>
    /// The ring.
    /// </summary>
    public static readonly RingColorEnum Ring = new("ring-ring");
    /// <summary>
    /// The ring50.
    /// </summary>
    public static readonly RingColorEnum Ring50 = new("ring-ring/50");
    /// <summary>
    /// The success.
    /// </summary>
    public static readonly RingColorEnum Success = new("ring-success");
    /// <summary>
    /// The warning.
    /// </summary>
    public static readonly RingColorEnum Warning = new("ring-warning");
    /// <summary>
    /// The info.
    /// </summary>
    public static readonly RingColorEnum Info = new("ring-info");
    /// <summary>
    /// The white.
    /// </summary>
    public static readonly RingColorEnum White = new("ring-white");
    /// <summary>
    /// The black.
    /// </summary>
    public static readonly RingColorEnum Black = new("ring-black");
}
