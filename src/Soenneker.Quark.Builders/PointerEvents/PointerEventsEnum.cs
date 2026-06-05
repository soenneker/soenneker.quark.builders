using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the pointer events enum.
/// </summary>
[EnumValue<string>]
public sealed partial class PointerEventsEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly PointerEventsEnum None = new("pointer-events-none");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly PointerEventsEnum Auto = new("pointer-events-auto");
}
