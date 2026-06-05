using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the ease enum.
/// </summary>
[EnumValue<string>]
public sealed partial class EaseEnum
{
    /// <summary>
    /// The linear.
    /// </summary>
    public static readonly EaseEnum Linear = new("ease-linear");
    /// <summary>
    /// The in.
    /// </summary>
    public static readonly EaseEnum In = new("ease-in");
    /// <summary>
    /// The out.
    /// </summary>
    public static readonly EaseEnum Out = new("ease-out");
    /// <summary>
    /// The in out.
    /// </summary>
    public static readonly EaseEnum InOut = new("ease-in-out");
}
