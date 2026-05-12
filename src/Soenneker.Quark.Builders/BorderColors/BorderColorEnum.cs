using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BorderColorEnum
{
    public static readonly BorderColorEnum Primary = new("border-primary");
    public static readonly BorderColorEnum Secondary = new("border-secondary");
    public static readonly BorderColorEnum Destructive = new("border-destructive");
    public static readonly BorderColorEnum Muted = new("border-muted");
    public static readonly BorderColorEnum Accent = new("border-accent");
    public static readonly BorderColorEnum Popover = new("border-popover");
    public static readonly BorderColorEnum Card = new("border-card");
    public static readonly BorderColorEnum Background = new("border-background");
    public static readonly BorderColorEnum Border = new("border-border");
    public static readonly BorderColorEnum Input = new("border-input");
    public static readonly BorderColorEnum Ring = new("border-ring");
    public static readonly BorderColorEnum Current = new("border-current");
    public static readonly BorderColorEnum White = new("border-white");
    public static readonly BorderColorEnum Black = new("border-black");
    public static readonly BorderColorEnum Transparent = new("border-transparent");
}
