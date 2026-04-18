namespace Soenneker.Quark;

/// <summary>
/// Canonical shadcn button recipe helpers used by Button and button-adjacent components.
/// This owns the component-level class contract and should stay aligned with the crawled shad output.
/// </summary>
public static class ButtonStyleUtil
{
    public static string GetVariantClass(string? variant)
    {
        return variant switch
        {
            "destructive" => "border-transparent bg-destructive text-white hover:bg-destructive/90 focus-visible:ring-destructive/20 dark:bg-destructive/60 dark:focus-visible:ring-destructive/40",
            "outline" => "border-border bg-background hover:bg-muted hover:text-foreground aria-expanded:bg-muted aria-expanded:text-foreground dark:border-input dark:bg-input/30 dark:hover:bg-input/50",
            "secondary" => "border-transparent bg-secondary text-secondary-foreground hover:bg-secondary/80",
            "ghost" => "border-transparent hover:bg-muted hover:text-foreground dark:hover:bg-accent/50",
            "link" => "border-transparent text-primary underline-offset-4 hover:underline",
            _ => "border-transparent bg-primary text-primary-foreground hover:bg-primary/90",
        };
    }

    public static string GetSizeClass(string? size)
    {
        return size switch
        {
            "xs" => "h-7 gap-1 rounded-md px-2 text-xs has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3",
            "sm" => "h-8 gap-1.5 rounded-md px-3 has-data-[icon=inline-end]:pr-2.5 has-data-[icon=inline-start]:pl-2.5",
            "lg" => "h-10 gap-1.5 px-6 has-data-[icon=inline-end]:pr-4 has-data-[icon=inline-start]:pl-4",
            "icon" => "size-8",
            "icon-xs" => "size-6 rounded-md [&_svg:not([class*='size-'])]:size-3",
            "icon-sm" => "size-8 rounded-md",
            "icon-lg" => "size-10",
            _ => "h-8 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2"
        };
    }

    public static string GetInputGroupSizeClass(string? size)
    {
        return size switch
        {
            "sm" => "h-8 gap-1.5 px-2.5",
            "icon-xs" => "size-6 rounded-[calc(var(--radius)-5px)] p-0 [&>svg:not([class*='size-'])]:size-3",
            "icon-sm" => "size-8 p-0",
            _ => "h-6 gap-1 rounded-[calc(var(--radius)-5px)] px-2 [&>svg:not([class*='size-'])]:size-3.5"
        };
    }

    public static string GetSizeDataAttribute(string? size)
    {
        return size switch
        {
            "xs" => "xs",
            "sm" => "sm",
            "lg" => "lg",
            "icon" => "icon",
            "icon-xs" => "icon-xs",
            "icon-sm" => "icon-sm",
            "icon-lg" => "icon-lg",
            _ => "default"
        };
    }
}
