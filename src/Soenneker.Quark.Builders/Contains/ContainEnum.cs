using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the contain enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ContainEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ContainEnum None = new("contain-none");
    /// <summary>
    /// The size.
    /// </summary>
    public static readonly ContainEnum Size = new("contain-size");
    /// <summary>
    /// The layout.
    /// </summary>
    public static readonly ContainEnum Layout = new("contain-layout");
    /// <summary>
    /// The style.
    /// </summary>
    public static readonly ContainEnum Style = new("contain-style");
    /// <summary>
    /// The paint.
    /// </summary>
    public static readonly ContainEnum Paint = new("contain-paint");
    /// <summary>
    /// The strict.
    /// </summary>
    public static readonly ContainEnum Strict = new("contain-strict");
    /// <summary>
    /// The content.
    /// </summary>
    public static readonly ContainEnum Content = new("contain-content");
}
