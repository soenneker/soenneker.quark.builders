namespace Soenneker.Quark;

/// <summary>
/// Shared shadcn badge token-to-class helpers.
/// </summary>
public static class BadgeStyleUtil
{
    public static string GetVariantClass(string? variant)
    {
        return variant switch
        {
            "secondary" => "bg-secondary text-secondary-foreground [a]:hover:bg-secondary/80",
            "destructive" => "bg-destructive/10 text-destructive [a]:hover:bg-destructive/20 focus-visible:ring-destructive/20 dark:bg-destructive/20 dark:focus-visible:ring-destructive/40",
            "outline" => "border-border text-foreground [a]:hover:bg-muted [a]:hover:text-muted-foreground",
            "ghost" => "hover:bg-muted hover:text-muted-foreground dark:hover:bg-muted/50",
            "link" => "text-primary underline-offset-4 [a]:hover:underline",
            _ => "bg-primary text-primary-foreground [a]:hover:bg-primary/80",
        };
    }
}
