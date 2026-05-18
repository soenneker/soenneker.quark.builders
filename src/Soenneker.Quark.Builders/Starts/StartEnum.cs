using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class StartEnum
{
    public static readonly StartEnum Is0 = new("start-0");
    public static readonly StartEnum Is1 = new("start-1");
    public static readonly StartEnum Is1_5 = new("start-1.5");
    public static readonly StartEnum Is2 = new("start-2");
    public static readonly StartEnum Is3 = new("start-3");
    public static readonly StartEnum Is4 = new("start-4");
    public static readonly StartEnum Is5 = new("start-5");
    public static readonly StartEnum Auto = new("start-auto");
    public static readonly StartEnum Px = new("start-px");
}
