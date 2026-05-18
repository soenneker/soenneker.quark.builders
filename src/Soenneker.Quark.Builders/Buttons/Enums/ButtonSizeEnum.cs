using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Button size utility groups following shadcn/ui conventions.
/// </summary>
[EnumValue<string>]
public sealed partial class ButtonSizeEnum
{
    public static readonly ButtonSizeEnum Default = new("h-8 gap-1.5 rounded-lg px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");
    public static readonly ButtonSizeEnum Xs = new("h-6 gap-1 rounded-[min(var(--radius-md),10px)] px-2 text-xs in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3 [&_svg[data-slot=icon]]:size-3");
    public static readonly ButtonSizeEnum Sm = new("h-7 gap-1 rounded-[min(var(--radius-md),12px)] px-2.5 text-[0.8rem] leading-normal in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3.5 [&_svg[data-slot=icon]]:size-3.5");
    public static readonly ButtonSizeEnum Lg = new("h-9 gap-1.5 rounded-lg px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");
    public static readonly ButtonSizeEnum Icon = new("size-8 rounded-lg");
    public static readonly ButtonSizeEnum IconXs = new("size-6 rounded-[min(var(--radius-md),10px)] in-data-[slot=button-group]:rounded-lg [&_svg:not([class*='size-'])]:size-3 [&_svg[data-slot=icon]]:size-3");
    public static readonly ButtonSizeEnum IconSm = new("size-7 rounded-[min(var(--radius-md),12px)] in-data-[slot=button-group]:rounded-lg");
    public static readonly ButtonSizeEnum IconLg = new("size-9 rounded-lg");
}
