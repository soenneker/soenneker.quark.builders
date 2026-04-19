namespace Soenneker.Quark;

/// <summary>
/// Entry points for responsive shadcn-style toggle sizing.
/// </summary>
public static class ToggleSizes
{
    public static ToggleSizeBuilder Default => new("h-8 min-w-8 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");
    public static ToggleSizeBuilder Sm => new("h-7 min-w-7 rounded-[min(var(--radius-md),12px)] px-2.5 text-[0.8rem] has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3.5");
    public static ToggleSizeBuilder Lg => new("h-9 min-w-9 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");

    public static ToggleSizeBuilder Token(string value) => new(value);
}
