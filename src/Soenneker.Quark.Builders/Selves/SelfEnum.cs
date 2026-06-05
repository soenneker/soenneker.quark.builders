using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the self enum.
/// </summary>
[EnumValue<string>]
public sealed partial class SelfEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly SelfEnum Auto = new("self-auto");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly SelfEnum Start = new("self-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly SelfEnum End = new("self-end");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly SelfEnum Center = new("self-center");
    /// <summary>
    /// The stretch.
    /// </summary>
    public static readonly SelfEnum Stretch = new("self-stretch");
    /// <summary>
    /// The baseline.
    /// </summary>
    public static readonly SelfEnum Baseline = new("self-baseline");
}
