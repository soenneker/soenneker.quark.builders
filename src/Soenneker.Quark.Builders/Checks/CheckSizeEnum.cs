using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the check size enum.
/// </summary>
[EnumValue<string>]
public sealed partial class CheckSizeEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly CheckSizeEnum Default = new("size-4");
    /// <summary>
    /// The xs.
    /// </summary>
    public static readonly CheckSizeEnum Xs = new("h-3 w-3");
    /// <summary>
    /// The sm.
    /// </summary>
    public static readonly CheckSizeEnum Sm = new("h-3.5 w-3.5");
    /// <summary>
    /// The md.
    /// </summary>
    public static readonly CheckSizeEnum Md = new("h-4 w-4");
    /// <summary>
    /// The lg.
    /// </summary>
    public static readonly CheckSizeEnum Lg = new("h-5 w-5");
    /// <summary>
    /// The xl.
    /// </summary>
    public static readonly CheckSizeEnum Xl = new("h-7 w-7");
    /// <summary>
    /// The xxl.
    /// </summary>
    public static readonly CheckSizeEnum Xxl = new("h-8 w-8");
}
