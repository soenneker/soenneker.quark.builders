namespace Soenneker.Quark;

/// <summary>
/// Represents the background image builder.
/// </summary>
[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundImageBuilder : FinalClassUtilityBuilder<BackgroundImageBuilder>
{
    internal BackgroundImageBuilder() {}
    internal BackgroundImageBuilder(BackgroundImageEnum value) : base(value.Value) {}
    internal BackgroundImageBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public BackgroundImageBuilder None => ChainClass(BackgroundImageEnum.None.Value);
    /// <summary>
    /// Gets or sets linear to t.
    /// </summary>
    public BackgroundImageBuilder LinearToT => ChainClass(BackgroundImageEnum.LinearToT.Value);
    /// <summary>
    /// Gets or sets linear to r.
    /// </summary>
    public BackgroundImageBuilder LinearToR => ChainClass(BackgroundImageEnum.LinearToR.Value);
    /// <summary>
    /// Gets or sets linear to b.
    /// </summary>
    public BackgroundImageBuilder LinearToB => ChainClass(BackgroundImageEnum.LinearToB.Value);
    /// <summary>
    /// Gets or sets linear to l.
    /// </summary>
    public BackgroundImageBuilder LinearToL => ChainClass(BackgroundImageEnum.LinearToL.Value);
    /// <summary>
    /// Gets or sets radial.
    /// </summary>
    public BackgroundImageBuilder Radial => ChainClass(BackgroundImageEnum.Radial.Value);
    /// <summary>
    /// Gets or sets conic.
    /// </summary>
    public BackgroundImageBuilder Conic => ChainClass(BackgroundImageEnum.Conic.Value);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public BackgroundImageBuilder Token(string value) => ChainClass(value.StartsWith("bg-") ? value : $"bg-{value}");
}
