namespace Soenneker.Quark;

/// <summary>
/// Represents the flex direction.
/// </summary>
[TailwindModifiers(typeof(FlexDirectionBuilder))]
public static partial class FlexDirection
{
    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public static FlexDirectionBuilder Row => new(FlexDirectionEnum.Row);
    /// <summary>
    /// Gets or sets row reverse.
    /// </summary>
    public static FlexDirectionBuilder RowReverse => new(FlexDirectionEnum.RowReverse);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public static FlexDirectionBuilder Col => new(FlexDirectionEnum.Col);
    /// <summary>
    /// Gets or sets col reverse.
    /// </summary>
    public static FlexDirectionBuilder ColReverse => new(FlexDirectionEnum.ColReverse);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static FlexDirectionBuilder Token(string value) => new("flex-" + value);
}
