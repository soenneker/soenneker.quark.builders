namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating float builders with predefined values.
/// </summary>
[TailwindModifiers(typeof(FloatBuilder))]
public static partial class Float
{
    /// <summary>
    /// Gets a float builder with none value (no floating).
    /// </summary>
    public static FloatBuilder None => new(FloatEnum.None);

    /// <summary>
    /// Gets a float builder with left value (float left).
    /// </summary>
    public static FloatBuilder Left => new(FloatEnum.Left);

    /// <summary>
    /// Gets a float builder with start value (float inline-start).
    /// </summary>
    public static FloatBuilder Start => new(FloatEnum.Start);

    /// <summary>
    /// Gets a float builder with right value (float right).
    /// </summary>
    public static FloatBuilder Right => new(FloatEnum.Right);

    /// <summary>
    /// Gets a float builder with end value (float inline-end).
    /// </summary>
    public static FloatBuilder End => new(FloatEnum.End);
}
