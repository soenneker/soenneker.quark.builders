namespace Soenneker.Quark;

/// <summary>
/// Max-width utility with fluent API. Tailwind-first (max-w-*).
/// </summary>
public static class MaxWidth
{
    /// <summary>
    /// Fluent step for `Is None` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsNone => new("max-w-none");
    /// <summary>
    /// Fluent step for `Is Xs` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsXs => new("max-w-xs");
    /// <summary>
    /// Fluent step for `Is Sm` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsSm => new("max-w-sm");
    /// <summary>
    /// Fluent step for `Is Md` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsMd => new("max-w-md");
    /// <summary>
    /// Fluent step for `Is Lg` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsLg => new("max-w-lg");
    /// <summary>
    /// Fluent step for `Is Xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsXl => new("max-w-xl");
    /// <summary>
    /// Fluent step for `Is2xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder Is2xl => new("max-w-2xl");
    /// <summary>
    /// Fluent step for `Is3xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder Is3xl => new("max-w-3xl");
    /// <summary>
    /// Fluent step for `Is4xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder Is4xl => new("max-w-4xl");
    /// <summary>
    /// Fluent step for `Is5xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder Is5xl => new("max-w-5xl");
    /// <summary>
    /// Fluent step for `Is6xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder Is6xl => new("max-w-6xl");
    /// <summary>
    /// Fluent step for `Is7xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder Is7xl => new("max-w-7xl");
    /// <summary>
    /// Fluent step for `Is Full` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsFull => new("max-w-full");
    /// <summary>
    /// Fluent step for `Is Min` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsMin => new("max-w-min");
    /// <summary>
    /// Fluent step for `Is Max` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsMax => new("max-w-max");
    /// <summary>
    /// Fluent step for `Is Fit` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsFit => new("max-w-fit");
    /// <summary>
    /// Fluent step for `Is Screen` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsScreen => new("max-w-screen");
    /// <summary>
    /// Fluent step for `Is Prose` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static MaxWidthBuilder IsProse => new("max-w-prose");

    /// <summary>
    /// Create from an arbitrary Tailwind max-width token (e.g. "4xl", "[56rem]", "[75ch]").
    /// </summary>
    public static MaxWidthBuilder Token(string token) => new(token.StartsWith("max-w-") ? token : "max-w-" + token);
}
