namespace Soenneker.Quark;

/// <summary>
/// Simplified transition utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(TransitionBuilder))]
public static partial class Transition
{
    /// <summary>
    /// Default transition property set.
    /// </summary>
    public static TransitionBuilder Default => new(TransitionEnum.DefaultValue);

    /// <summary>
    /// No transition (none).
    /// </summary>
    public static TransitionBuilder None => new(TransitionEnum.NoneValue);

    /// <summary>
    /// All properties transition (all).
    /// </summary>
    public static TransitionBuilder All => new(TransitionEnum.AllValue);

    /// <summary>
    /// Colors transition (colors).
    /// </summary>
    public static TransitionBuilder Colors => new(TransitionEnum.ColorsValue);

    /// <summary>
    /// Opacity transition (opacity).
    /// </summary>
    public static TransitionBuilder Opacity => new(TransitionEnum.OpacityValue);

    /// <summary>
    /// Shadow transition (shadow).
    /// </summary>
    public static TransitionBuilder Shadow => new(TransitionEnum.ShadowValue);

    /// <summary>
    /// Transform transition (transform).
    /// </summary>
    public static TransitionBuilder Transform => new(TransitionEnum.TransformValue);

    /// <summary>
    /// Applies an exact Tailwind transition utility token, e.g. "transition-[color,shadow]".
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static TransitionBuilder Token(string token) => new(token.StartsWith("transition") ? token : $"transition-{token}");
}
