using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Defines the visual style variant for a Button component.
/// Follows shadcn/ui design system using CSS custom properties.
/// </summary>
[EnumValue<string>]
public sealed partial class ButtonVariant
{
    /// <summary>Default primary button style (solid background).</summary>
    public static readonly ButtonVariant Default = new("default", "border-transparent bg-primary text-primary-foreground [a]:hover:bg-primary/80");

    /// <summary>Destructive action style (delete, remove).</summary>
    public static readonly ButtonVariant Destructive = new("destructive", "border-transparent bg-destructive/10 text-destructive hover:bg-destructive/20 focus-visible:border-destructive/40 focus-visible:ring-destructive/20 dark:bg-destructive/20 dark:hover:bg-destructive/30 dark:focus-visible:ring-destructive/40");

    /// <summary>Outlined style with transparent background and border.</summary>
    public static readonly ButtonVariant Outline = new("outline", "border-border bg-background hover:bg-muted hover:text-foreground aria-expanded:bg-muted aria-expanded:text-foreground dark:border-input dark:bg-input/30 dark:hover:bg-input/50");

    /// <summary>Secondary style with muted background.</summary>
    public static readonly ButtonVariant Secondary = new("secondary", "border-transparent bg-secondary text-secondary-foreground hover:bg-secondary/80 aria-expanded:bg-secondary aria-expanded:text-secondary-foreground");

    /// <summary>Ghost style - no background, shows on hover.</summary>
    public static readonly ButtonVariant Ghost = new("ghost", "border-transparent hover:bg-muted hover:text-foreground aria-expanded:bg-muted aria-expanded:text-foreground dark:hover:bg-muted/50");

    /// <summary>Link-styled button (underlined text).</summary>
    public static readonly ButtonVariant Link = new("link", "border-transparent text-primary underline-offset-4 hover:underline");

    public string Class { get; } = string.Empty;

    private ButtonVariant(string value, string cssClass) : this(value)
    {
        Class = cssClass;
    }
}
