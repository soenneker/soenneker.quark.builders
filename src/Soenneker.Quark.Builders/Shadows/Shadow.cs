namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating shadow builders with predefined values.
/// </summary>
public static class Shadow
{
    /// <summary>
    /// No shadow.
    /// </summary>
    public static ShadowBuilder None => new(ShadowKeyword.None);

    /// <summary>
    /// Extra small shadow.
    /// </summary>
    public static ShadowBuilder Xs => new(ShadowKeyword.Xs);

    /// <summary>
    /// Small shadow.
    /// </summary>
    public static ShadowBuilder Sm => new(ShadowKeyword.Sm);

    public static ShadowBuilder Small => Sm;

    /// <summary>
    /// Default shadow.
    /// </summary>
    public static ShadowBuilder Default => new(ShadowKeyword.Default);

    public static ShadowBuilder Base => Default;

    /// <summary>
    /// Medium shadow.
    /// </summary>
    public static ShadowBuilder Md => new(ShadowKeyword.Md);

    /// <summary>
    /// Large shadow.
    /// </summary>
    public static ShadowBuilder Lg => new(ShadowKeyword.Lg);

    /// <summary>
    /// Extra large shadow.
    /// </summary>
    public static ShadowBuilder Xl => new(ShadowKeyword.Xl);

    /// <summary>
    /// 2x extra large shadow.
    /// </summary>
    public static ShadowBuilder TwoXl => new(ShadowKeyword.TwoXl);

    /// <summary>
    /// Inner shadow.
    /// </summary>
    public static ShadowBuilder Inner => new(ShadowKeyword.Inner);
}
