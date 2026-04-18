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
}
