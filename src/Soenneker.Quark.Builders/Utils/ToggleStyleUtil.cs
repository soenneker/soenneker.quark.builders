namespace Soenneker.Quark;

/// <summary>
/// Shared shadcn toggle token-to-class helpers.
/// </summary>
public static class ToggleStyleUtil
{
    public static string GetVariantClass(string? variant)
    {
        return variant switch
        {
            "outline" => "border border-input bg-transparent hover:bg-muted",
            _ => "bg-transparent"
        };
    }

    public static string GetGroupVariantClass(string? variant)
    {
        return variant switch
        {
            "outline" => "data-[variant=outline]:shadow-xs",
            _ => string.Empty
        };
    }

    public static string GetSizeClass(string? size, bool includeShrink)
    {
        string prefix = includeShrink ? "shrink-0 " : string.Empty;

        return size switch
        {
            "small" => $"{prefix}h-7 min-w-7 rounded-[min(var(--radius-md),12px)] px-2.5 text-[0.8rem] has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3.5",
            "large" => $"{prefix}h-9 min-w-9 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2",
            _ => $"{prefix}h-8 min-w-8 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2"
        };
    }
}
