using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the user select enum.
/// </summary>
[EnumValue<string>]
public sealed partial class UserSelectEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly UserSelectEnum None = new("select-none");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly UserSelectEnum Auto = new("select-auto");
    /// <summary>
    /// The all.
    /// </summary>
    public static readonly UserSelectEnum All = new("select-all");
}
