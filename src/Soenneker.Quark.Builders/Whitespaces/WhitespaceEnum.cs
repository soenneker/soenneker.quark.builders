using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the whitespace enum.
/// </summary>
[EnumValue<string>]
public sealed partial class WhitespaceEnum
{
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly WhitespaceEnum Normal = new("whitespace-normal");
    /// <summary>
    /// The nowrap.
    /// </summary>
    public static readonly WhitespaceEnum Nowrap = new("whitespace-nowrap");
    /// <summary>
    /// The pre.
    /// </summary>
    public static readonly WhitespaceEnum Pre = new("whitespace-pre");
    /// <summary>
    /// The pre line.
    /// </summary>
    public static readonly WhitespaceEnum PreLine = new("whitespace-pre-line");
    /// <summary>
    /// The pre wrap.
    /// </summary>
    public static readonly WhitespaceEnum PreWrap = new("whitespace-pre-wrap");
    /// <summary>
    /// The break spaces.
    /// </summary>
    public static readonly WhitespaceEnum BreakSpaces = new("whitespace-break-spaces");
}
