namespace Soenneker.Quark;

/// <summary>
/// Shared shadcn button token-to-class helpers used by components and builders.
/// </summary>
public static class ButtonStyleUtil
{
    public static string GetVariantClass(string? variant)
    {
        return variant switch
        {
            "destructive" => "bg-destructive text-white hover:bg-destructive/90 focus-visible:ring-destructive/20 dark:bg-destructive/60 dark:focus-visible:ring-destructive/40",
            "outline" => "border bg-background shadow-xs hover:bg-accent hover:text-accent-foreground dark:border-input dark:bg-input/30 dark:hover:bg-input/50",
            "secondary" => "bg-secondary text-secondary-foreground hover:bg-secondary/80",
            "ghost" => "hover:bg-accent hover:text-accent-foreground dark:hover:bg-accent/50",
            "link" => "text-primary underline-offset-4 hover:underline",
            _ => "bg-primary text-primary-foreground hover:bg-primary/90",
        };
    }

    public static string GetSizeClass(string? size)
    {
        return size switch
        {
            "xs" => "h-6 gap-1 px-2 text-xs has-[>svg]:px-1.5 [&_svg:not([class*='size-'])]:size-3",
            "sm" => "h-8 gap-1.5 px-3 has-[>svg]:px-2.5",
            "lg" => "h-10 px-6 has-[>svg]:px-4",
            "icon" => "size-9",
            "icon-xs" => "size-6 [&_svg:not([class*='size-'])]:size-3",
            "icon-sm" => "size-8",
            "icon-lg" => "size-10",
            _ => "h-9 px-4 py-2 has-[>svg]:px-3",
        };
    }

    public static string GetInputGroupSizeClass(string? size)
    {
        return size switch
        {
            "sm" => "h-8 gap-1.5 px-2.5 has-[>svg]:px-2.5",
            "icon-xs" => "size-6 rounded-[calc(var(--radius)-5px)] p-0 has-[>svg]:p-0 [&>svg:not([class*='size-'])]:size-3",
            "icon-sm" => "size-8 p-0 has-[>svg]:p-0",
            _ => "h-6 gap-1 rounded-[calc(var(--radius)-5px)] px-2 has-[>svg]:px-2 [&>svg:not([class*='size-'])]:size-3.5"
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
