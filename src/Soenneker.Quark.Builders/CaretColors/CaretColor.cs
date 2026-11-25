namespace Soenneker.Quark;

/// <summary>
/// Static utility for caret color. Tailwind: caret-*.
/// </summary>
[TailwindModifiers(typeof(CaretColorBuilder), IncludeColorPalettes = true)]
public static partial class CaretColor
{
    /// <summary>Applies a percentage from 0 through 100 to the next color utility.</summary>
    public static CaretColorBuilder WithOpacity(int percent) => new CaretColorBuilder().WithOpacity(percent);

    /// <summary>Uses the <c>sidebar</c> theme color.</summary>
    public static CaretColorBuilder Sidebar => Token("sidebar");

    /// <summary>Uses the <c>sidebar-foreground</c> theme color.</summary>
    public static CaretColorBuilder SidebarForeground => Token("sidebar-foreground");

    /// <summary>Uses the <c>sidebar-primary</c> theme color.</summary>
    public static CaretColorBuilder SidebarPrimary => Token("sidebar-primary");

    /// <summary>Uses the <c>sidebar-primary-foreground</c> theme color.</summary>
    public static CaretColorBuilder SidebarPrimaryForeground => Token("sidebar-primary-foreground");

    /// <summary>Uses the <c>sidebar-accent</c> theme color.</summary>
    public static CaretColorBuilder SidebarAccent => Token("sidebar-accent");

    /// <summary>Uses the <c>sidebar-accent-foreground</c> theme color.</summary>
    public static CaretColorBuilder SidebarAccentForeground => Token("sidebar-accent-foreground");

    /// <summary>Uses the <c>sidebar-border</c> theme color.</summary>
    public static CaretColorBuilder SidebarBorder => Token("sidebar-border");

    /// <summary>Uses the <c>sidebar-ring</c> theme color.</summary>
    public static CaretColorBuilder SidebarRing => Token("sidebar-ring");

    /// <summary>
    /// Fluent step for `Primary` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static CaretColorBuilder Primary => new(CaretColorEnum.PrimaryValue);
    /// <summary>
    /// Fully transparent color (`transparent`).
    /// </summary>
    public static CaretColorBuilder Transparent => new(CaretColorEnum.TransparentValue);
    /// <summary>
    /// `currentColor` — uses the element’s computed `color` (common for icons and rings).
    /// </summary>
    public static CaretColorBuilder Current => new(CaretColorEnum.CurrentValue);

    /// <summary>
    /// Creates a caret color builder from a Tailwind color token suffix such as <c>blue-500</c> or <c>[var(--brand)]</c>.
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static CaretColorBuilder Token(string token) => new("caret-" + token);

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>caret-blue-500</c>.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static CaretColorBuilder Utility(string utility) => new(utility);
}
