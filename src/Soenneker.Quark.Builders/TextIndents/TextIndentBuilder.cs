namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for first-line indentation, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("indent-", Responsive = true)]
public sealed class TextIndentBuilder : FinalClassUtilityBuilder<TextIndentBuilder>
{
    internal TextIndentBuilder()
    {
    }

    internal TextIndentBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>indent-0</c>.</summary>
    public TextIndentBuilder Is0 => ChainClass("indent-0");

    /// <summary>Adds <c>indent-0.5</c>.</summary>
    public TextIndentBuilder Is0_5 => ChainClass("indent-0.5");

    /// <summary>Adds <c>indent-1</c>.</summary>
    public TextIndentBuilder Is1 => ChainClass("indent-1");

    /// <summary>Adds <c>indent-1.5</c>.</summary>
    public TextIndentBuilder Is1_5 => ChainClass("indent-1.5");

    /// <summary>Adds <c>indent-2</c>.</summary>
    public TextIndentBuilder Is2 => ChainClass("indent-2");

    /// <summary>Adds <c>indent-2.5</c>.</summary>
    public TextIndentBuilder Is2_5 => ChainClass("indent-2.5");

    /// <summary>Adds <c>indent-3</c>.</summary>
    public TextIndentBuilder Is3 => ChainClass("indent-3");

    /// <summary>Adds <c>indent-3.5</c>.</summary>
    public TextIndentBuilder Is3_5 => ChainClass("indent-3.5");

    /// <summary>Adds <c>indent-4</c>.</summary>
    public TextIndentBuilder Is4 => ChainClass("indent-4");

    /// <summary>Adds <c>indent-5</c>.</summary>
    public TextIndentBuilder Is5 => ChainClass("indent-5");

    /// <summary>Adds <c>indent-6</c>.</summary>
    public TextIndentBuilder Is6 => ChainClass("indent-6");

    /// <summary>Adds <c>indent-8</c>.</summary>
    public TextIndentBuilder Is8 => ChainClass("indent-8");

    /// <summary>Adds <c>indent-10</c>.</summary>
    public TextIndentBuilder Is10 => ChainClass("indent-10");

    /// <summary>Adds <c>indent-12</c>.</summary>
    public TextIndentBuilder Is12 => ChainClass("indent-12");

    /// <summary>Adds <c>indent-16</c>.</summary>
    public TextIndentBuilder Is16 => ChainClass("indent-16");

    /// <summary>Adds <c>indent-20</c>.</summary>
    public TextIndentBuilder Is20 => ChainClass("indent-20");

    /// <summary>Adds <c>indent-24</c>.</summary>
    public TextIndentBuilder Is24 => ChainClass("indent-24");

    /// <summary>Adds <c>indent-32</c>.</summary>
    public TextIndentBuilder Is32 => ChainClass("indent-32");

    /// <summary>Adds <c>indent-40</c>.</summary>
    public TextIndentBuilder Is40 => ChainClass("indent-40");

    /// <summary>Adds <c>indent-48</c>.</summary>
    public TextIndentBuilder Is48 => ChainClass("indent-48");

    /// <summary>Adds <c>indent-64</c>.</summary>
    public TextIndentBuilder Is64 => ChainClass("indent-64");

    /// <summary>Adds <c>indent-96</c>.</summary>
    public TextIndentBuilder Is96 => ChainClass("indent-96");

    /// <summary>Adds <c>-indent-1</c>.</summary>
    public TextIndentBuilder Negative1 => ChainClass("-indent-1");

    /// <summary>Adds <c>-indent-2</c>.</summary>
    public TextIndentBuilder Negative2 => ChainClass("-indent-2");

    /// <summary>Adds <c>-indent-4</c>.</summary>
    public TextIndentBuilder Negative4 => ChainClass("-indent-4");

    /// <summary>Adds <c>-indent-8</c>.</summary>
    public TextIndentBuilder Negative8 => ChainClass("-indent-8");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public TextIndentBuilder Token(string value) => ChainClass(UtilityToken.WithSignedPrefix(value, "indent-"));
}
