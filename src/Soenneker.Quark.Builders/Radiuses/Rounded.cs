namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned rounded utility.
/// </summary>
public static class Rounded
{
    /// <summary>
    /// Default theme radius: `rounded` with no suffix — in Tailwind’s default config typically `0.25rem` (maps to shadcn `--radius` usage when you align tokens).
    /// </summary>
    public static RoundedBuilder Default => new RoundedBuilder().Default;
    /// <summary>
    /// <c>rounded-none</c> — <c>border-radius: 0</c> on the selected corners (fully square corners).
    /// </summary>
    public static RoundedBuilder None => new RoundedBuilder().None;
    /// <summary>
    /// `rounded-sm` — small radius (default theme `0.125rem`).
    /// </summary>
    public static RoundedBuilder Sm => new RoundedBuilder().Sm;
    /// <summary>
    /// `rounded-md` — medium radius (default theme `0.375rem`); common for cards and inputs in shadcn.
    /// </summary>
    public static RoundedBuilder Md => new RoundedBuilder().Md;
    /// <summary>
    /// `rounded-lg` — large radius (default theme `0.5rem`).
    /// </summary>
    public static RoundedBuilder Lg => new RoundedBuilder().Lg;
    /// <summary>
    /// `rounded-xl` — extra-large radius (default theme `0.75rem`).
    /// </summary>
    public static RoundedBuilder Xl => new RoundedBuilder().Xl;
    /// <summary>
    /// `rounded-2xl` — 2× XL radius (default theme `1rem`).
    /// </summary>
    public static RoundedBuilder TwoXl => new RoundedBuilder().TwoXl;
    /// <summary>
    /// `rounded-3xl` — very large radius (default theme `1.5rem`).
    /// </summary>
    public static RoundedBuilder ThreeXl => new RoundedBuilder().ThreeXl;
    /// <summary>
    /// “Full” extremum for this utility. For border radius this is `rounded-full` (`border-radius: 9999px`), producing pills/circles; for width/height often `100%` (`w-full` / `h-full`).
    /// </summary>
    public static RoundedBuilder Full => new RoundedBuilder().Full;

    /// <summary>
    /// Targets all corners (`rounded-*` with no corner suffix).
    /// </summary>
    public static RoundedBuilder All => new RoundedBuilder().All;
    /// <summary>
    /// Top corners only (`rounded-t-*`).
    /// </summary>
    public static RoundedBuilder Top => new RoundedBuilder().Top;
    /// <summary>
    /// Bottom corners only (`rounded-b-*`).
    /// </summary>
    public static RoundedBuilder Bottom => new RoundedBuilder().Bottom;
    /// <summary>
    /// Left corners only (`rounded-l-*`).
    /// </summary>
    public static RoundedBuilder Left => new RoundedBuilder().Left;
    /// <summary>
    /// Right corners only (`rounded-r-*`).
    /// </summary>
    public static RoundedBuilder Right => new RoundedBuilder().Right;

    /// <summary>
    /// Top-left corner only (`rounded-tl-*`).
    /// </summary>
    public static RoundedBuilder TopLeft => new RoundedBuilder().TopLeft;
    /// <summary>
    /// Top-right corner only (`rounded-tr-*`).
    /// </summary>
    public static RoundedBuilder TopRight => new RoundedBuilder().TopRight;
    /// <summary>
    /// Bottom-left corner only (`rounded-bl-*`).
    /// </summary>
    public static RoundedBuilder BottomLeft => new RoundedBuilder().BottomLeft;
    /// <summary>
    /// Bottom-right corner only (`rounded-br-*`).
    /// </summary>
    public static RoundedBuilder BottomRight => new RoundedBuilder().BottomRight;

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint. In Tailwind’s mobile‑first model, unprefixed utilities apply from 0px unless a larger breakpoint overrides them.
    /// </summary>
    public static RoundedBuilder OnBase => new RoundedBuilder().OnBase;
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public static RoundedBuilder OnSm => new RoundedBuilder().OnSm;
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public static RoundedBuilder OnMd => new RoundedBuilder().OnMd;
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public static RoundedBuilder OnLg => new RoundedBuilder().OnLg;
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public static RoundedBuilder OnXl => new RoundedBuilder().OnXl;
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public static RoundedBuilder On2xl => new RoundedBuilder().On2xl;

    /// <summary>
    /// Custom <c>rounded-*</c> suffix: theme scale key, arbitrary length (for example <c>[2vw]</c>), or CSS variable reference aligned with shadcn’s <c>--radius</c> pattern.
    /// </summary>
    /// <param name="value">The segment after <c>rounded-</c> (and any corner prefix such as <c>tl-</c>).</param>
    public static RoundedBuilder Token(string value) => new RoundedBuilder().Token(value);
}