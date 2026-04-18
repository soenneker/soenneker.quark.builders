namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating box shadow builders with predefined values.
/// </summary>
public static class BoxShadow
{
    /// <summary>
    /// No shadow.
    /// </summary>
    public static BoxShadowBuilder None => new(BoxShadowEnum.None);

    /// <summary>
    /// Extra small shadow.
    /// </summary>
    public static BoxShadowBuilder Xs => new(BoxShadowEnum.Xs);

    /// <summary>
    /// Small shadow.
    /// </summary>
    public static BoxShadowBuilder Sm => new(BoxShadowEnum.Sm);

    public static BoxShadowBuilder Small => Sm;

    /// <summary>
    /// Default shadow.
    /// </summary>
    public static BoxShadowBuilder Default => new(BoxShadowEnum.Default);

    public static BoxShadowBuilder Base => Default;

    /// <summary>
    /// Medium shadow.
    /// </summary>
    public static BoxShadowBuilder Md => new(BoxShadowEnum.Md);

    /// <summary>
    /// Large shadow.
    /// </summary>
    public static BoxShadowBuilder Lg => new(BoxShadowEnum.Lg);

    /// <summary>
    /// Extra large shadow.
    /// </summary>
    public static BoxShadowBuilder Xl => new(BoxShadowEnum.Xl);

    /// <summary>
    /// 2x extra large shadow.
    /// </summary>
    public static BoxShadowBuilder TwoXl => new(BoxShadowEnum.TwoXl);

    /// <summary>
    /// Inner shadow.
    /// </summary>
    public static BoxShadowBuilder Inner => new(BoxShadowEnum.Inner);
}
