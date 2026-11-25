namespace Soenneker.Quark;

/// <summary>
/// Border color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
[TailwindModifiers(typeof(BorderColorBuilder), IncludeColorPalettes = true)]
public static partial class BorderColor
{
    /// <summary>Applies a percentage from 0 through 100 to the next color utility.</summary>
    public static BorderColorBuilder WithOpacity(int percent) => new BorderColorBuilder().WithOpacity(percent);

    /// <summary>Uses the <c>sidebar</c> theme color.</summary>
    public static BorderColorBuilder Sidebar => Token("sidebar");

    /// <summary>Uses the <c>sidebar-foreground</c> theme color.</summary>
    public static BorderColorBuilder SidebarForeground => Token("sidebar-foreground");

    /// <summary>Uses the <c>sidebar-primary</c> theme color.</summary>
    public static BorderColorBuilder SidebarPrimary => Token("sidebar-primary");

    /// <summary>Uses the <c>sidebar-primary-foreground</c> theme color.</summary>
    public static BorderColorBuilder SidebarPrimaryForeground => Token("sidebar-primary-foreground");

    /// <summary>Uses the <c>sidebar-accent</c> theme color.</summary>
    public static BorderColorBuilder SidebarAccent => Token("sidebar-accent");

    /// <summary>Uses the <c>sidebar-accent-foreground</c> theme color.</summary>
    public static BorderColorBuilder SidebarAccentForeground => Token("sidebar-accent-foreground");

    /// <summary>Uses the <c>sidebar-border</c> theme color.</summary>
    public static BorderColorBuilder SidebarBorder => Token("sidebar-border");

    /// <summary>Uses the <c>sidebar-ring</c> theme color.</summary>
    public static BorderColorBuilder SidebarRing => Token("sidebar-ring");

    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public static BorderColorBuilder Primary => new(BorderColorEnum.PrimaryValue);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public static BorderColorBuilder Secondary => new(BorderColorEnum.SecondaryValue);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public static BorderColorBuilder Destructive => new(BorderColorEnum.DestructiveValue);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public static BorderColorBuilder Muted => new(BorderColorEnum.MutedValue);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public static BorderColorBuilder Accent => new(BorderColorEnum.AccentValue);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public static BorderColorBuilder Popover => new(BorderColorEnum.PopoverValue);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public static BorderColorBuilder Card => new(BorderColorEnum.CardValue);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public static BorderColorBuilder Background => new(BorderColorEnum.BackgroundValue);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public static BorderColorBuilder Border => new(BorderColorEnum.BorderValue);
    /// <summary>
    /// Gets or sets input.
    /// </summary>
    public static BorderColorBuilder Input => new(BorderColorEnum.InputValue);
    /// <summary>
    /// Gets or sets ring.
    /// </summary>
    public static BorderColorBuilder Ring => new(BorderColorEnum.RingValue);
    /// <summary>
    /// Gets or sets current.
    /// </summary>
    public static BorderColorBuilder Current => new(BorderColorEnum.CurrentValue);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public static BorderColorBuilder White => new(BorderColorEnum.WhiteValue);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public static BorderColorBuilder Black => new(BorderColorEnum.BlackValue);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public static BorderColorBuilder Transparent => new(BorderColorEnum.TransparentValue);

    /// <summary>
    /// Creates a border color builder from a Tailwind color token suffix such as <c>primary/30</c>, <c>zinc-300</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BorderColorBuilder Token(string token) => new("border-" + token);

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>border-primary/30</c>.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BorderColorBuilder Utility(string utility) => new(utility);
}
