namespace Soenneker.Quark;

internal interface IColorTokenFactory<out TBuilder>
{
    /// <summary>Adds a color token to its original builder.</summary>
    /// <param name="token">The color token.</param>
    /// <returns>The configured builder.</returns>
    TBuilder Token(string token);
}
