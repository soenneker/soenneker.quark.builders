using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the start enum.
/// </summary>
[EnumValue<string>]
public sealed partial class StartEnum
{
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly StartEnum Is0 = new("start-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly StartEnum Is1 = new("start-1");
    /// <summary>
    /// The is1 5.
    /// </summary>
    public static readonly StartEnum Is1_5 = new("start-1.5");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly StartEnum Is2 = new("start-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly StartEnum Is3 = new("start-3");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly StartEnum Is4 = new("start-4");
    /// <summary>
    /// The is5.
    /// </summary>
    public static readonly StartEnum Is5 = new("start-5");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly StartEnum Auto = new("start-auto");
    /// <summary>
    /// The px.
    /// </summary>
    public static readonly StartEnum Px = new("start-px");
}
