using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the transition enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TransitionEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly TransitionEnum Default = new("transition");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly TransitionEnum None = new("transition-none");
    /// <summary>
    /// The all.
    /// </summary>
    public static readonly TransitionEnum All = new("transition-all");
    /// <summary>
    /// The colors.
    /// </summary>
    public static readonly TransitionEnum Colors = new("transition-colors");
    /// <summary>
    /// The opacity.
    /// </summary>
    public static readonly TransitionEnum Opacity = new("transition-opacity");
    /// <summary>
    /// The shadow.
    /// </summary>
    public static readonly TransitionEnum Shadow = new("transition-shadow");
    /// <summary>
    /// The transform.
    /// </summary>
    public static readonly TransitionEnum Transform = new("transition-transform");
}
