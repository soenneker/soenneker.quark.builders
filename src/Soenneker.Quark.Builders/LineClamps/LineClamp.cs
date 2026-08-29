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
    /// Adds an arbitrary line clamp utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static LineClampBuilder Token(string value) => new(value.StartsWith("line-clamp-") ? value : "line-clamp-" + value);
}
