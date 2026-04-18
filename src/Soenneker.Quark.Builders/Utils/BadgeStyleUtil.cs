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
            "secondary" => "bg-secondary text-secondary-foreground [a&]:hover:bg-secondary/80",
            "destructive" => "bg-destructive text-white [a&]:hover:bg-destructive/80 focus-visible:ring-destructive/20 dark:focus-visible:ring-destructive/40 dark:bg-destructive/60",
            "outline" => "border-border text-foreground [a&]:hover:bg-muted [a&]:hover:text-muted-foreground",
            "ghost" => "[a&]:hover:bg-muted [a&]:hover:text-muted-foreground",
            "link" => "text-primary underline-offset-4 [a&]:hover:underline",
            _ => "bg-primary text-primary-foreground [a&]:hover:bg-primary/80",
        };
    }
}
