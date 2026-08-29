namespace Soenneker.Quark;

/// <summary>
/// Static utility for accent color. Tailwind: accent-*.
/// </summary>
[TailwindModifiers(typeof(AccentColorBuilder), IncludeColorPalettes = true)]
public static partial class AccentColor
{
    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public static AccentColorBuilder Auto => new(AccentColorEnum.Auto);
    /// <summary>
    /// `accent-primary` — uses your theme primary (shadcn maps this to CSS variables).
    /// </summary>
    public static AccentColorBuilder Primary => new(AccentColorEnum.Primary);
    /// <summary>
    /// Fully transparent color (`transparent`).
    /// </summary>
    public static AccentColorBuilder Transparent => new(AccentColorEnum.Transparent);
    /// <summary>
    /// `currentColor` — uses the element’s computed `color` (common for icons and rings).
    /// </summary>
    public static AccentColorBuilder Current => new(AccentColorEnum.Current);

    /// <summary>
    /// Creates an accent color builder from a Tailwind color token suffix such as <c>blue-500</c> or <c>[var(--brand)]</c>.
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static AccentColorBuilder Token(string token) => new(ColorUtility.CreateClass("accent-", token));

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>accent-blue-500</c>.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static AccentColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("accent-", utility));
}
