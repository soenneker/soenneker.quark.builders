namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for first-line indentation.
/// </summary>
[TailwindModifiers(typeof(TextIndentBuilder))]
public static partial class TextIndent
{
    /// <summary>Adds <c>indent-0</c>.</summary>
    public static TextIndentBuilder Is0 => new("indent-0");

    /// <summary>Adds <c>indent-0.5</c>.</summary>
    public static TextIndentBuilder Is0_5 => new("indent-0.5");

    /// <summary>Adds <c>indent-1</c>.</summary>
    public static TextIndentBuilder Is1 => new("indent-1");

    /// <summary>Adds <c>indent-1.5</c>.</summary>
    public static TextIndentBuilder Is1_5 => new("indent-1.5");

    /// <summary>Adds <c>indent-2</c>.</summary>
    public static TextIndentBuilder Is2 => new("indent-2");

    /// <summary>Adds <c>indent-2.5</c>.</summary>
    public static TextIndentBuilder Is2_5 => new("indent-2.5");

    /// <summary>Adds <c>indent-3</c>.</summary>
    public static TextIndentBuilder Is3 => new("indent-3");

    /// <summary>Adds <c>indent-3.5</c>.</summary>
    public static TextIndentBuilder Is3_5 => new("indent-3.5");

    /// <summary>Adds <c>indent-4</c>.</summary>
    public static TextIndentBuilder Is4 => new("indent-4");

    /// <summary>Adds <c>indent-5</c>.</summary>
    public static TextIndentBuilder Is5 => new("indent-5");

    /// <summary>Adds <c>indent-6</c>.</summary>
    public static TextIndentBuilder Is6 => new("indent-6");

    /// <summary>Adds <c>indent-8</c>.</summary>
    public static TextIndentBuilder Is8 => new("indent-8");

    /// <summary>Adds <c>indent-10</c>.</summary>
    public static TextIndentBuilder Is10 => new("indent-10");

    /// <summary>Adds <c>indent-12</c>.</summary>
    public static TextIndentBuilder Is12 => new("indent-12");

    /// <summary>Adds <c>indent-16</c>.</summary>
    public static TextIndentBuilder Is16 => new("indent-16");

    /// <summary>Adds <c>indent-20</c>.</summary>
    public static TextIndentBuilder Is20 => new("indent-20");

    /// <summary>Adds <c>indent-24</c>.</summary>
    public static TextIndentBuilder Is24 => new("indent-24");

    /// <summary>Adds <c>indent-32</c>.</summary>
    public static TextIndentBuilder Is32 => new("indent-32");

    /// <summary>Adds <c>indent-40</c>.</summary>
    public static TextIndentBuilder Is40 => new("indent-40");

    /// <summary>Adds <c>indent-48</c>.</summary>
    public static TextIndentBuilder Is48 => new("indent-48");

    /// <summary>Adds <c>indent-64</c>.</summary>
    public static TextIndentBuilder Is64 => new("indent-64");

    /// <summary>Adds <c>indent-96</c>.</summary>
    public static TextIndentBuilder Is96 => new("indent-96");

    /// <summary>Adds <c>-indent-1</c>.</summary>
    public static TextIndentBuilder Negative1 => new("-indent-1");

    /// <summary>Adds <c>-indent-2</c>.</summary>
    public static TextIndentBuilder Negative2 => new("-indent-2");

    /// <summary>Adds <c>-indent-4</c>.</summary>
    public static TextIndentBuilder Negative4 => new("-indent-4");

    /// <summary>Adds <c>-indent-8</c>.</summary>
    public static TextIndentBuilder Negative8 => new("-indent-8");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static TextIndentBuilder Token(string value) => new(UtilityToken.WithSignedPrefix(value, "indent-"));
}
