using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the screen reader enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ScreenReaderEnum
{
    /// <summary>
    /// The only.
    /// </summary>
    public static readonly ScreenReaderEnum Only = new("sr-only");
}
