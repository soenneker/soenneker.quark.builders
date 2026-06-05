using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the button type.
/// </summary>
[EnumValue<string>]
public sealed partial class ButtonType
{
    /// <summary>
    /// The button.
    /// </summary>
    public static readonly ButtonType Button = new("button");
    /// <summary>
    /// The submit.
    /// </summary>
    public static readonly ButtonType Submit = new("submit");
    /// <summary>
    /// The reset.
    /// </summary>
    public static readonly ButtonType Reset = new("reset");
    /// <summary>
    /// The link.
    /// </summary>
    public static readonly ButtonType Link = new("link");
}