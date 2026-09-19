using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>Named Tailwind decoration color utilities.</summary>
[EnumValue<string>]
public sealed partial class DecorationColorEnum
{
    /// <summary>The <c>decoration-primary</c> utility.</summary>
    public static readonly DecorationColorEnum Primary = new("decoration-primary");

    /// <summary>The <c>decoration-primary-foreground</c> utility.</summary>
    public static readonly DecorationColorEnum PrimaryForeground = new("decoration-primary-foreground");

    /// <summary>The <c>decoration-secondary</c> utility.</summary>
    public static readonly DecorationColorEnum Secondary = new("decoration-secondary");

    /// <summary>The <c>decoration-secondary-foreground</c> utility.</summary>
    public static readonly DecorationColorEnum SecondaryForeground = new("decoration-secondary-foreground");

    /// <summary>The <c>decoration-destructive</c> utility.</summary>
    public static readonly DecorationColorEnum Destructive = new("decoration-destructive");

    /// <summary>The <c>decoration-destructive-foreground</c> utility.</summary>
    public static readonly DecorationColorEnum DestructiveForeground = new("decoration-destructive-foreground");

    /// <summary>The <c>decoration-muted</c> utility.</summary>
    public static readonly DecorationColorEnum Muted = new("decoration-muted");

    /// <summary>The <c>decoration-muted-foreground</c> utility.</summary>
    public static readonly DecorationColorEnum MutedForeground = new("decoration-muted-foreground");

    /// <summary>The <c>decoration-accent</c> utility.</summary>
    public static readonly DecorationColorEnum Accent = new("decoration-accent");

    /// <summary>The <c>decoration-accent-foreground</c> utility.</summary>
    public static readonly DecorationColorEnum AccentForeground = new("decoration-accent-foreground");

    /// <summary>The <c>decoration-popover</c> utility.</summary>
    public static readonly DecorationColorEnum Popover = new("decoration-popover");

    /// <summary>The <c>decoration-popover-foreground</c> utility.</summary>
    public static readonly DecorationColorEnum PopoverForeground = new("decoration-popover-foreground");

    /// <summary>The <c>decoration-card</c> utility.</summary>
    public static readonly DecorationColorEnum Card = new("decoration-card");

    /// <summary>The <c>decoration-card-foreground</c> utility.</summary>
    public static readonly DecorationColorEnum CardForeground = new("decoration-card-foreground");

    /// <summary>The <c>decoration-background</c> utility.</summary>
    public static readonly DecorationColorEnum Background = new("decoration-background");

    /// <summary>The <c>decoration-foreground</c> utility.</summary>
    public static readonly DecorationColorEnum Foreground = new("decoration-foreground");

    /// <summary>The <c>decoration-border</c> utility.</summary>
    public static readonly DecorationColorEnum Border = new("decoration-border");

    /// <summary>The <c>decoration-input</c> utility.</summary>
    public static readonly DecorationColorEnum Input = new("decoration-input");

    /// <summary>The <c>decoration-ring</c> utility.</summary>
    public static readonly DecorationColorEnum Ring = new("decoration-ring");

    /// <summary>The <c>decoration-ring/50</c> utility.</summary>
    public static readonly DecorationColorEnum Ring50 = new("decoration-ring/50");

    /// <summary>The <c>decoration-success</c> utility.</summary>
    public static readonly DecorationColorEnum Success = new("decoration-success");

    /// <summary>The <c>decoration-warning</c> utility.</summary>
    public static readonly DecorationColorEnum Warning = new("decoration-warning");

    /// <summary>The <c>decoration-info</c> utility.</summary>
    public static readonly DecorationColorEnum Info = new("decoration-info");

    /// <summary>The <c>decoration-white</c> utility.</summary>
    public static readonly DecorationColorEnum White = new("decoration-white");

    /// <summary>The <c>decoration-black</c> utility.</summary>
    public static readonly DecorationColorEnum Black = new("decoration-black");

    /// <summary>The <c>decoration-transparent</c> utility.</summary>
    public static readonly DecorationColorEnum Transparent = new("decoration-transparent");

    /// <summary>The <c>decoration-current</c> utility.</summary>
    public static readonly DecorationColorEnum Current = new("decoration-current");

    /// <summary>The <c>decoration-inherit</c> utility.</summary>
    public static readonly DecorationColorEnum Inherit = new("decoration-inherit");

}
