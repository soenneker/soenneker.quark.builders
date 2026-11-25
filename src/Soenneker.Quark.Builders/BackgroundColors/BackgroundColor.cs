namespace Soenneker.Quark;

/// <summary>
/// Background color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
[TailwindModifiers(typeof(BackgroundColorBuilder), IncludeColorPalettes = true)]
public static partial class BackgroundColor
{
    /// <summary>Applies a percentage from 0 through 100 to the next color utility.</summary>
    public static BackgroundColorBuilder WithOpacity(int percent) => new BackgroundColorBuilder().WithOpacity(percent);

    /// <summary>Uses the <c>sidebar</c> theme color.</summary>
    public static BackgroundColorBuilder Sidebar => Token("sidebar");

    /// <summary>Uses the <c>sidebar-foreground</c> theme color.</summary>
    public static BackgroundColorBuilder SidebarForeground => Token("sidebar-foreground");

    /// <summary>Uses the <c>sidebar-primary</c> theme color.</summary>
    public static BackgroundColorBuilder SidebarPrimary => Token("sidebar-primary");

    /// <summary>Uses the <c>sidebar-primary-foreground</c> theme color.</summary>
    public static BackgroundColorBuilder SidebarPrimaryForeground => Token("sidebar-primary-foreground");

    /// <summary>Uses the <c>sidebar-accent</c> theme color.</summary>
    public static BackgroundColorBuilder SidebarAccent => Token("sidebar-accent");

    /// <summary>Uses the <c>sidebar-accent-foreground</c> theme color.</summary>
    public static BackgroundColorBuilder SidebarAccentForeground => Token("sidebar-accent-foreground");

    /// <summary>Uses the <c>sidebar-border</c> theme color.</summary>
    public static BackgroundColorBuilder SidebarBorder => Token("sidebar-border");

    /// <summary>Uses the <c>sidebar-ring</c> theme color.</summary>
    public static BackgroundColorBuilder SidebarRing => Token("sidebar-ring");

    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public static BackgroundColorBuilder Primary => new(BackgroundColorEnum.PrimaryValue);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public static BackgroundColorBuilder Secondary => new(BackgroundColorEnum.SecondaryValue);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public static BackgroundColorBuilder Destructive => new(BackgroundColorEnum.DestructiveValue);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public static BackgroundColorBuilder Muted => new(BackgroundColorEnum.MutedValue);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public static BackgroundColorBuilder Accent => new(BackgroundColorEnum.AccentValue);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public static BackgroundColorBuilder Popover => new(BackgroundColorEnum.PopoverValue);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public static BackgroundColorBuilder Card => new(BackgroundColorEnum.CardValue);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public static BackgroundColorBuilder Background => new(BackgroundColorEnum.BackgroundValue);
    /// <summary>
    /// Gets or sets foreground.
    /// </summary>
    public static BackgroundColorBuilder Foreground => new(BackgroundColorEnum.ForegroundValue);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public static BackgroundColorBuilder Border => new(BackgroundColorEnum.BorderValue);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public static BackgroundColorBuilder White => new(BackgroundColorEnum.WhiteValue);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public static BackgroundColorBuilder Black => new(BackgroundColorEnum.BlackValue);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public static BackgroundColorBuilder Transparent => new(BackgroundColorEnum.TransparentValue);

    /// <summary>
    /// Creates a background color builder from a Tailwind color token suffix such as <c>primary/20</c>, <c>zinc-900</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BackgroundColorBuilder Token(string token) => new("bg-" + token);

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>bg-primary/20</c>.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BackgroundColorBuilder Utility(string utility) => new(utility);
}
