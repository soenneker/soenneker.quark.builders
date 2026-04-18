using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TextColorEnum
{
    public static readonly TextColorEnum Primary = new("text-primary");
    public static readonly TextColorEnum PrimaryForeground = new("text-primary-foreground");
    public static readonly TextColorEnum Secondary = new("text-secondary");
    public static readonly TextColorEnum SecondaryForeground = new("text-secondary-foreground");
    public static readonly TextColorEnum Destructive = new("text-destructive");
    public static readonly TextColorEnum DestructiveForeground = new("text-destructive-foreground");
    public static readonly TextColorEnum MutedForeground = new("text-muted-foreground");
    public static readonly TextColorEnum Accent = new("text-accent");
    public static readonly TextColorEnum AccentForeground = new("text-accent-foreground");
    public static readonly TextColorEnum PopoverForeground = new("text-popover-foreground");
    public static readonly TextColorEnum CardForeground = new("text-card-foreground");
    public static readonly TextColorEnum Foreground = new("text-foreground");
    public static readonly TextColorEnum White = new("text-white");
    public static readonly TextColorEnum Black = new("text-black");
}
