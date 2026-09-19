namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for mask repetition.
/// </summary>
[TailwindModifiers(typeof(MaskRepeatBuilder))]
public static partial class MaskRepeat
{
    /// <summary>Adds <c>mask-repeat</c>.</summary>
    public static MaskRepeatBuilder Repeat => new("mask-repeat");

    /// <summary>Adds <c>mask-no-repeat</c>.</summary>
    public static MaskRepeatBuilder NoRepeat => new("mask-no-repeat");

    /// <summary>Adds <c>mask-repeat-x</c>.</summary>
    public static MaskRepeatBuilder RepeatX => new("mask-repeat-x");

    /// <summary>Adds <c>mask-repeat-y</c>.</summary>
    public static MaskRepeatBuilder RepeatY => new("mask-repeat-y");

    /// <summary>Adds <c>mask-repeat-round</c>.</summary>
    public static MaskRepeatBuilder Round => new("mask-repeat-round");

    /// <summary>Adds <c>mask-repeat-space</c>.</summary>
    public static MaskRepeatBuilder Space => new("mask-repeat-space");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaskRepeatBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "mask-"));
}
