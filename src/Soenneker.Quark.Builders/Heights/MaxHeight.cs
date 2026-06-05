namespace Soenneker.Quark;

/// <summary>
/// Max-height utility with fluent API. Tailwind-first (max-h-*).
/// </summary>
[TailwindModifiers(typeof(MaxHeightBuilder))]
public static partial class MaxHeight
{
    /// <summary>
    /// Gets or sets is none.
    /// </summary>
    public static MaxHeightBuilder IsNone => new("max-h-none");
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static MaxHeightBuilder Is0 => new("max-h-0");
    /// <summary>
    /// Gets or sets is px.
    /// </summary>
    public static MaxHeightBuilder IsPx => new("max-h-px");
    /// <summary>
    /// Gets or sets is full.
    /// </summary>
    public static MaxHeightBuilder IsFull => new("max-h-full");
    /// <summary>
    /// Gets or sets is screen.
    /// </summary>
    public static MaxHeightBuilder IsScreen => new("max-h-screen");
    /// <summary>
    /// Gets or sets is svh.
    /// </summary>
    public static MaxHeightBuilder IsSvh => new("max-h-svh");
    /// <summary>
    /// Gets or sets is lvh.
    /// </summary>
    public static MaxHeightBuilder IsLvh => new("max-h-lvh");
    /// <summary>
    /// Gets or sets is dvh.
    /// </summary>
    public static MaxHeightBuilder IsDvh => new("max-h-dvh");
    /// <summary>
    /// Gets or sets is min.
    /// </summary>
    public static MaxHeightBuilder IsMin => new("max-h-min");
    /// <summary>
    /// Gets or sets is max.
    /// </summary>
    public static MaxHeightBuilder IsMax => new("max-h-max");
    /// <summary>
    /// Gets or sets is fit.
    /// </summary>
    public static MaxHeightBuilder IsFit => new("max-h-fit");
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static MaxHeightBuilder Token(string value) => new(value.StartsWith("max-h-") ? value : "max-h-" + value);
}
