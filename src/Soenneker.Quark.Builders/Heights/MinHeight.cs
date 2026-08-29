namespace Soenneker.Quark;

/// <summary>
/// Min-height utility with fluent API. Tailwind-first (min-h-*).
/// </summary>
[TailwindModifiers(typeof(MinHeightBuilder))]
public static partial class MinHeight
{
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static MinHeightBuilder Is0 => new("min-h-0");
    /// <summary>
    /// Gets or sets is px.
    /// </summary>
    public static MinHeightBuilder IsPx => new("min-h-px");
    /// <summary>
    /// Gets or sets is full.
    /// </summary>
    public static MinHeightBuilder IsFull => new("min-h-full");
    /// <summary>
    /// Gets or sets is screen.
    /// </summary>
    public static MinHeightBuilder IsScreen => new("min-h-screen");
    /// <summary>
    /// Gets or sets is svh.
    /// </summary>
    public static MinHeightBuilder IsSvh => new("min-h-svh");
    /// <summary>
    /// Gets or sets is lvh.
    /// </summary>
    public static MinHeightBuilder IsLvh => new("min-h-lvh");
    /// <summary>
    /// Gets or sets is dvh.
    /// </summary>
    public static MinHeightBuilder IsDvh => new("min-h-dvh");
    /// <summary>
    /// Gets or sets is min.
    /// </summary>
    public static MinHeightBuilder IsMin => new("min-h-min");
    /// <summary>
    /// Gets or sets is max.
    /// </summary>
    public static MinHeightBuilder IsMax => new("min-h-max");
    /// <summary>
    /// Gets or sets is fit.
    /// </summary>
    public static MinHeightBuilder IsFit => new("min-h-fit");
    /// <summary>
    /// Adds an arbitrary min height utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static MinHeightBuilder Token(string value) => new(value.StartsWith("min-h-") ? value : "min-h-" + value);
}
