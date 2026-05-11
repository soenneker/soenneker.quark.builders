using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BackgroundColorEnum
{
    public static readonly BackgroundColorEnum Primary = new("bg-primary");
    public static readonly BackgroundColorEnum Secondary = new("bg-secondary");
    public static readonly BackgroundColorEnum Destructive = new("bg-destructive");
    public static readonly BackgroundColorEnum Muted = new("bg-muted");
    public static readonly BackgroundColorEnum Accent = new("bg-accent");
    public static readonly BackgroundColorEnum Popover = new("bg-popover");
    public static readonly BackgroundColorEnum Card = new("bg-card");
    public static readonly BackgroundColorEnum Background = new("bg-background");
    public static readonly BackgroundColorEnum Foreground = new("bg-foreground");
    public static readonly BackgroundColorEnum White = new("bg-white");
    public static readonly BackgroundColorEnum Black = new("bg-black");
    public static readonly BackgroundColorEnum Transparent = new("bg-transparent");
}
