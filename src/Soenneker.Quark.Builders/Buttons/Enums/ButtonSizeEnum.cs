using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Button size tokens and utility groups following shadcn/ui conventions.
/// </summary>
[EnumValue<string>]
public sealed partial class ButtonSizeEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly ButtonSizeEnum Default = new("default", "h-8 gap-1.5 rounded-lg px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");
    /// <summary>
    /// The xs.
    /// </summary>
    public static readonly ButtonSizeEnum Xs = new("xs", "h-6 gap-1 rounded-[min(var(--radius-md),10px)] px-2 text-xs in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3 [&_svg[data-slot=icon]]:size-3");
    /// <summary>
    /// The sm.
    /// </summary>
    public static readonly ButtonSizeEnum Sm = new("sm", "h-7 gap-1 rounded-[min(var(--radius-md),12px)] px-2.5 text-[0.8rem] leading-normal in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3.5 [&_svg[data-slot=icon]]:size-3.5");
    /// <summary>
    /// The lg.
    /// </summary>
    public static readonly ButtonSizeEnum Lg = new("lg", "h-9 gap-1.5 rounded-lg px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2");
    /// <summary>
    /// The icon.
    /// </summary>
    public static readonly ButtonSizeEnum Icon = new("icon", "size-8 rounded-lg");
    /// <summary>
    /// The icon xs.
    /// </summary>
    public static readonly ButtonSizeEnum IconXs = new("icon-xs", "size-6 rounded-[min(var(--radius-md),10px)] in-data-[slot=button-group]:rounded-lg [&_svg:not([class*='size-'])]:size-3 [&_svg[data-slot=icon]]:size-3");
    /// <summary>
    /// The icon sm.
    /// </summary>
    public static readonly ButtonSizeEnum IconSm = new("icon-sm", "size-7 rounded-[min(var(--radius-md),12px)] in-data-[slot=button-group]:rounded-lg");
    /// <summary>
    /// The icon lg.
    /// </summary>
    public static readonly ButtonSizeEnum IconLg = new("icon-lg", "size-9 rounded-lg");

    /// <summary>
    /// Gets class.
    /// </summary>
    public string Class { get; } = string.Empty;

    private ButtonSizeEnum(string value, string cssClass) : this(value)
    {
        Class = cssClass;
    }
}
