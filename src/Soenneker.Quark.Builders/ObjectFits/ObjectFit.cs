namespace Soenneker.Quark;

/// <summary>
/// Simplified object-fit utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(ObjectFitBuilder))]
public static partial class ObjectFit
{
    /// <summary>
    /// object-fit: contain.
    /// </summary>
    public static ObjectFitBuilder Contain => new(ObjectFitEnum.ContainValue);

    /// <summary>
    /// object-fit: cover.
    /// </summary>
    public static ObjectFitBuilder Cover => new(ObjectFitEnum.CoverValue);

    /// <summary>
    /// object-fit: fill.
    /// </summary>
    public static ObjectFitBuilder Fill => new(ObjectFitEnum.FillValue);

    /// <summary>
    /// object-fit: scale-down.
    /// </summary>
    public static ObjectFitBuilder ScaleDown => new(ObjectFitEnum.ScaleDownValue);

    /// <summary>
    /// object-fit: none.
    /// </summary>
    public static ObjectFitBuilder None => new(ObjectFitEnum.NoneValue);
}
