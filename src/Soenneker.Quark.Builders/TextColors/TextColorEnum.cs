using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the text color enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TextColorEnum
{
    /// <summary>
    /// The primary.
    /// </summary>
    public static readonly TextColorEnum Primary = new("text-primary");
    /// <summary>
    /// The primary foreground.
    /// </summary>
    public static readonly TextColorEnum PrimaryForeground = new("text-primary-foreground");
    /// <summary>
    /// The secondary.
    /// </summary>
    public static readonly TextColorEnum Secondary = new("text-secondary");
    /// <summary>
    /// The secondary foreground.
    /// </summary>
    public static readonly TextColorEnum SecondaryForeground = new("text-secondary-foreground");
    /// <summary>
    /// The destructive.
    /// </summary>
    public static readonly TextColorEnum Destructive = new("text-destructive");
    /// <summary>
    /// The destructive foreground.
    /// </summary>
    public static readonly TextColorEnum DestructiveForeground = new("text-destructive-foreground");
    /// <summary>
    /// The muted foreground.
    /// </summary>
    public static readonly TextColorEnum MutedForeground = new("text-muted-foreground");
    /// <summary>
    /// The accent.
    /// </summary>
    public static readonly TextColorEnum Accent = new("text-accent");
    /// <summary>
    /// The accent foreground.
    /// </summary>
    public static readonly TextColorEnum AccentForeground = new("text-accent-foreground");
    /// <summary>
    /// The popover foreground.
    /// </summary>
    public static readonly TextColorEnum PopoverForeground = new("text-popover-foreground");
    /// <summary>
    /// The card foreground.
    /// </summary>
    public static readonly TextColorEnum CardForeground = new("text-card-foreground");
    /// <summary>
    /// The foreground.
    /// </summary>
    public static readonly TextColorEnum Foreground = new("text-foreground");
    /// <summary>
    /// The white.
    /// </summary>
    public static readonly TextColorEnum White = new("text-white");
    /// <summary>
    /// The black.
    /// </summary>
    public static readonly TextColorEnum Black = new("text-black");
}
