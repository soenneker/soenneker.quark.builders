namespace Soenneker.Quark;

/// <summary>
/// Represents the clear.
/// </summary>
[TailwindModifiers(typeof(ClearBuilder))]
public static partial class Clear
{
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static ClearBuilder Start => new(ClearEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static ClearBuilder End => new(ClearEnum.End);
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public static ClearBuilder Left => new(ClearEnum.Left);
    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public static ClearBuilder Right => new(ClearEnum.Right);
    /// <summary>
    /// Gets or sets both.
    /// </summary>
    public static ClearBuilder Both => new(ClearEnum.Both);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static ClearBuilder None => new(ClearEnum.None);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static ClearBuilder Token(string value) => new(value.StartsWith("clear-") ? value : $"clear-{value}");
}
