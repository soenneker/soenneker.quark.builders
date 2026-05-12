namespace Soenneker.Quark;

/// <summary>
/// Min-height utility with fluent API. Tailwind-first (min-h-*).
/// </summary>
[TailwindModifiers(typeof(MinHeightBuilder))]
public static partial class MinHeight
{
    public static MinHeightBuilder Is0 => new("min-h-0");
    public static MinHeightBuilder IsPx => new("min-h-px");
    public static MinHeightBuilder IsFull => new("min-h-full");
    public static MinHeightBuilder IsScreen => new("min-h-screen");
    public static MinHeightBuilder IsSvh => new("min-h-svh");
    public static MinHeightBuilder IsLvh => new("min-h-lvh");
    public static MinHeightBuilder IsDvh => new("min-h-dvh");
    public static MinHeightBuilder IsMin => new("min-h-min");
    public static MinHeightBuilder IsMax => new("min-h-max");
    public static MinHeightBuilder IsFit => new("min-h-fit");
    public static MinHeightBuilder Token(string value) => new(value.StartsWith("min-h-") ? value : "min-h-" + value);
}
