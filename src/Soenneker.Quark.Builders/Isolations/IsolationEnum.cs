using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the isolation enum.
/// </summary>
[EnumValue<string>]
public sealed partial class IsolationEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly IsolationEnum Auto = new("isolation-auto");
    /// <summary>
    /// The isolate.
    /// </summary>
    public static readonly IsolationEnum Isolate = new("isolation-isolate");
}
