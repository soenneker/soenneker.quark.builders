namespace Soenneker.Quark;

/// <summary>
/// Entry points for responsive shadcn-style button sizing.
/// </summary>
public static class ButtonSizes
{
    public static ButtonSizeBuilder Default => new("h-8 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");
    public static ButtonSizeBuilder Xs => new("h-6 gap-1 rounded-[min(var(--radius-md),10px)] px-2 text-xs in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3");
    public static ButtonSizeBuilder Sm => new("h-7 gap-1 rounded-[min(var(--radius-md),12px)] px-2.5 text-[0.8rem] in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3.5");
    public static ButtonSizeBuilder Lg => new("h-9 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");
    public static ButtonSizeBuilder Icon => new("size-8");
    public static ButtonSizeBuilder IconXs => new("size-6 rounded-[min(var(--radius-md),10px)] in-data-[slot=button-group]:rounded-lg [&_svg:not([class*='size-'])]:size-3");
    public static ButtonSizeBuilder IconSm => new("size-7 rounded-[min(var(--radius-md),12px)] in-data-[slot=button-group]:rounded-lg");
    public static ButtonSizeBuilder IconLg => new("size-9");

    public static ButtonSizeBuilder Token(string value) => new(value);
}
