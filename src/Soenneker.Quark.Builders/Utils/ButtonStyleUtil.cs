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
            "destructive" => "border border-transparent bg-destructive/10 text-destructive hover:bg-destructive/20 focus-visible:border-destructive/40 focus-visible:ring-destructive/20 dark:bg-destructive/20 dark:hover:bg-destructive/30 dark:focus-visible:ring-destructive/40",
            "outline" => "border-border bg-background hover:bg-muted hover:text-foreground aria-expanded:bg-muted aria-expanded:text-foreground dark:border-input dark:bg-input/30 dark:hover:bg-input/50",
            "secondary" => "border border-transparent bg-secondary text-secondary-foreground hover:bg-secondary/80 aria-expanded:bg-secondary aria-expanded:text-secondary-foreground",
            "ghost" => "border border-transparent hover:bg-muted hover:text-foreground aria-expanded:bg-muted aria-expanded:text-foreground dark:hover:bg-muted/50",
            "link" => "border border-transparent text-primary underline-offset-4 hover:underline",
            _ => "border border-transparent bg-primary text-primary-foreground [a]:hover:bg-primary/80",
        };
    }

    public static string GetSizeClass(string? size)
    {
        return size switch
        {
            "xs" => "h-6 gap-1 rounded-[min(var(--radius-md),10px)] px-2 text-xs in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3",
            "sm" => "h-7 gap-1 rounded-[min(var(--radius-md),12px)] px-2.5 text-[0.8rem] in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3.5",
            "lg" => "h-9 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2",
            "icon" => "size-8",
            "icon-xs" => "size-6 rounded-[min(var(--radius-md),10px)] in-data-[slot=button-group]:rounded-lg [&_svg:not([class*='size-'])]:size-3",
            "icon-sm" => "size-7 rounded-[min(var(--radius-md),12px)] in-data-[slot=button-group]:rounded-lg",
            "icon-lg" => "size-9",
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
