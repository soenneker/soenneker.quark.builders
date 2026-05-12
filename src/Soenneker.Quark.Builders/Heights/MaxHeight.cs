namespace Soenneker.Quark;

/// <summary>
/// Max-height utility with fluent API. Tailwind-first (max-h-*).
/// </summary>
[TailwindModifiers(typeof(MaxHeightBuilder))]
public static partial class MaxHeight
{
    public static MaxHeightBuilder IsNone => new("max-h-none");
    public static MaxHeightBuilder Is0 => new("max-h-0");
    public static MaxHeightBuilder IsPx => new("max-h-px");
    public static MaxHeightBuilder IsFull => new("max-h-full");
    public static MaxHeightBuilder IsScreen => new("max-h-screen");
    public static MaxHeightBuilder IsSvh => new("max-h-svh");
    public static MaxHeightBuilder IsLvh => new("max-h-lvh");
    public static MaxHeightBuilder IsDvh => new("max-h-dvh");
    public static MaxHeightBuilder IsMin => new("max-h-min");
    public static MaxHeightBuilder IsMax => new("max-h-max");
    public static MaxHeightBuilder IsFit => new("max-h-fit");
    public static MaxHeightBuilder Token(string value) => new(value.StartsWith("max-h-") ? value : "max-h-" + value);
}
