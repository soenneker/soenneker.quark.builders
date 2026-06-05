namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn line clamp utility shortcuts.
/// </summary>
[TailwindModifiers(typeof(LineClampBuilder))]
public static partial class LineClamp
{
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static LineClampBuilder None => new(LineClampEnum.None);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static LineClampBuilder Is1 => new(LineClampEnum.Is1);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static LineClampBuilder Is2 => new(LineClampEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static LineClampBuilder Is3 => new(LineClampEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static LineClampBuilder Is4 => new(LineClampEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static LineClampBuilder Is5 => new(LineClampEnum.Is5);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public static LineClampBuilder Is6 => new(LineClampEnum.Is6);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static LineClampBuilder Token(string value) => new(value.StartsWith("line-clamp-") ? value : "line-clamp-" + value);
}
