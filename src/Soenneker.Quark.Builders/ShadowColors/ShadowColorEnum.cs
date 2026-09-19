using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>Named Tailwind shadow color utilities.</summary>
[EnumValue<string>]
public sealed partial class ShadowColorEnum
{
    /// <summary>The <c>shadow-primary</c> utility.</summary>
    public static readonly ShadowColorEnum Primary = new("shadow-primary");

    /// <summary>The <c>shadow-primary-foreground</c> utility.</summary>
    public static readonly ShadowColorEnum PrimaryForeground = new("shadow-primary-foreground");

    /// <summary>The <c>shadow-secondary</c> utility.</summary>
    public static readonly ShadowColorEnum Secondary = new("shadow-secondary");

    /// <summary>The <c>shadow-secondary-foreground</c> utility.</summary>
    public static readonly ShadowColorEnum SecondaryForeground = new("shadow-secondary-foreground");

    /// <summary>The <c>shadow-destructive</c> utility.</summary>
    public static readonly ShadowColorEnum Destructive = new("shadow-destructive");

    /// <summary>The <c>shadow-destructive-foreground</c> utility.</summary>
    public static readonly ShadowColorEnum DestructiveForeground = new("shadow-destructive-foreground");

    /// <summary>The <c>shadow-muted</c> utility.</summary>
    public static readonly ShadowColorEnum Muted = new("shadow-muted");

    /// <summary>The <c>shadow-muted-foreground</c> utility.</summary>
    public static readonly ShadowColorEnum MutedForeground = new("shadow-muted-foreground");

    /// <summary>The <c>shadow-accent</c> utility.</summary>
    public static readonly ShadowColorEnum Accent = new("shadow-accent");

    /// <summary>The <c>shadow-accent-foreground</c> utility.</summary>
    public static readonly ShadowColorEnum AccentForeground = new("shadow-accent-foreground");

    /// <summary>The <c>shadow-popover</c> utility.</summary>
    public static readonly ShadowColorEnum Popover = new("shadow-popover");

    /// <summary>The <c>shadow-popover-foreground</c> utility.</summary>
    public static readonly ShadowColorEnum PopoverForeground = new("shadow-popover-foreground");

    /// <summary>The <c>shadow-card</c> utility.</summary>
    public static readonly ShadowColorEnum Card = new("shadow-card");

    /// <summary>The <c>shadow-card-foreground</c> utility.</summary>
    public static readonly ShadowColorEnum CardForeground = new("shadow-card-foreground");

    /// <summary>The <c>shadow-background</c> utility.</summary>
    public static readonly ShadowColorEnum Background = new("shadow-background");

    /// <summary>The <c>shadow-foreground</c> utility.</summary>
    public static readonly ShadowColorEnum Foreground = new("shadow-foreground");

    /// <summary>The <c>shadow-border</c> utility.</summary>
    public static readonly ShadowColorEnum Border = new("shadow-border");

    /// <summary>The <c>shadow-input</c> utility.</summary>
    public static readonly ShadowColorEnum Input = new("shadow-input");

    /// <summary>The <c>shadow-ring</c> utility.</summary>
    public static readonly ShadowColorEnum Ring = new("shadow-ring");

    /// <summary>The <c>shadow-ring/50</c> utility.</summary>
    public static readonly ShadowColorEnum Ring50 = new("shadow-ring/50");

    /// <summary>The <c>shadow-success</c> utility.</summary>
    public static readonly ShadowColorEnum Success = new("shadow-success");

    /// <summary>The <c>shadow-warning</c> utility.</summary>
    public static readonly ShadowColorEnum Warning = new("shadow-warning");

    /// <summary>The <c>shadow-info</c> utility.</summary>
    public static readonly ShadowColorEnum Info = new("shadow-info");

    /// <summary>The <c>shadow-white</c> utility.</summary>
    public static readonly ShadowColorEnum White = new("shadow-white");

    /// <summary>The <c>shadow-black</c> utility.</summary>
    public static readonly ShadowColorEnum Black = new("shadow-black");

    /// <summary>The <c>shadow-transparent</c> utility.</summary>
    public static readonly ShadowColorEnum Transparent = new("shadow-transparent");

    /// <summary>The <c>shadow-current</c> utility.</summary>
    public static readonly ShadowColorEnum Current = new("shadow-current");

    /// <summary>The <c>shadow-inherit</c> utility.</summary>
    public static readonly ShadowColorEnum Inherit = new("shadow-inherit");

}
