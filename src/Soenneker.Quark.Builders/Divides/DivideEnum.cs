using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DivideEnum
{
    public static readonly DivideEnum X = new("divide-x");
    public static readonly DivideEnum Y = new("divide-y");
    public static readonly DivideEnum XReverse = new("divide-x-reverse");
    public static readonly DivideEnum YReverse = new("divide-y-reverse");
    public static readonly DivideEnum Solid = new("divide-solid");
    public static readonly DivideEnum Dashed = new("divide-dashed");
    public static readonly DivideEnum Dotted = new("divide-dotted");
    public static readonly DivideEnum Double = new("divide-double");
    public static readonly DivideEnum None = new("divide-none");
    public static readonly DivideEnum Primary = new("divide-primary");
    public static readonly DivideEnum Secondary = new("divide-secondary");
    public static readonly DivideEnum Destructive = new("divide-destructive");
    public static readonly DivideEnum Muted = new("divide-muted");
    public static readonly DivideEnum Accent = new("divide-accent");
    public static readonly DivideEnum Popover = new("divide-popover");
    public static readonly DivideEnum Card = new("divide-card");
    public static readonly DivideEnum Background = new("divide-background");
    public static readonly DivideEnum Border = new("divide-border");
    public static readonly DivideEnum Input = new("divide-input");
    public static readonly DivideEnum Ring = new("divide-ring");
    public static readonly DivideEnum White = new("divide-white");
    public static readonly DivideEnum Black = new("divide-black");
    public static readonly DivideEnum Transparent = new("divide-transparent");
}
