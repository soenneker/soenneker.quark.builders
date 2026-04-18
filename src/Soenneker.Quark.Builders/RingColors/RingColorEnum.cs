using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RingColorEnum
{
    public static readonly RingColorEnum Primary = new("ring-primary");
    public static readonly RingColorEnum PrimaryForeground = new("ring-primary-foreground");
    public static readonly RingColorEnum Secondary = new("ring-secondary");
    public static readonly RingColorEnum SecondaryForeground = new("ring-secondary-foreground");
    public static readonly RingColorEnum Destructive = new("ring-destructive");
    public static readonly RingColorEnum DestructiveForeground = new("ring-destructive-foreground");
    public static readonly RingColorEnum Muted = new("ring-muted");
    public static readonly RingColorEnum MutedForeground = new("ring-muted-foreground");
    public static readonly RingColorEnum Accent = new("ring-accent");
    public static readonly RingColorEnum AccentForeground = new("ring-accent-foreground");
    public static readonly RingColorEnum Popover = new("ring-popover");
    public static readonly RingColorEnum PopoverForeground = new("ring-popover-foreground");
    public static readonly RingColorEnum Card = new("ring-card");
    public static readonly RingColorEnum CardForeground = new("ring-card-foreground");
    public static readonly RingColorEnum Background = new("ring-background");
    public static readonly RingColorEnum Foreground = new("ring-foreground");
    public static readonly RingColorEnum Border = new("ring-border");
    public static readonly RingColorEnum Input = new("ring-input");
    public static readonly RingColorEnum Ring = new("ring-ring");
    public static readonly RingColorEnum Success = new("ring-success");
    public static readonly RingColorEnum Warning = new("ring-warning");
    public static readonly RingColorEnum Info = new("ring-info");
    public static readonly RingColorEnum White = new("ring-white");
    public static readonly RingColorEnum Black = new("ring-black");
}
