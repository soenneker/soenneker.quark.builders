using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the scroll snap stop enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ScrollSnapStopEnum
{
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly ScrollSnapStopEnum Normal = new("snap-stop-normal");
    /// <summary>
    /// The always.
    /// </summary>
    public static readonly ScrollSnapStopEnum Always = new("snap-stop-always");
}
