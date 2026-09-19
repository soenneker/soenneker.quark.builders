namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for translation on both axes or a selected axis, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("translate-", Responsive = true)]
public sealed class TranslateBuilder : FinalClassUtilityBuilder<TranslateBuilder>
{
    private string _axis = "";

    internal TranslateBuilder()
    {
    }

    internal TranslateBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Selects the x axis for the next utility only.</summary>
    public TranslateBuilder OnX
    {
        get
        {
            _axis = "x-";
            return this;
        }
    }

    /// <summary>Selects the y axis for the next utility only.</summary>
    public TranslateBuilder OnY
    {
        get
        {
            _axis = "y-";
            return this;
        }
    }

    /// <summary>Adds <c>translate-0</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is0 => Token("0");

    /// <summary>Adds <c>translate-0.5</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is0_5 => Token("0.5");

    /// <summary>Adds <c>translate-1</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is1 => Token("1");

    /// <summary>Adds <c>translate-1.5</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is1_5 => Token("1.5");

    /// <summary>Adds <c>translate-2</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is2 => Token("2");

    /// <summary>Adds <c>translate-2.5</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is2_5 => Token("2.5");

    /// <summary>Adds <c>translate-3</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is3 => Token("3");

    /// <summary>Adds <c>translate-3.5</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is3_5 => Token("3.5");

    /// <summary>Adds <c>translate-4</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is4 => Token("4");

    /// <summary>Adds <c>translate-5</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is5 => Token("5");

    /// <summary>Adds <c>translate-6</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is6 => Token("6");

    /// <summary>Adds <c>translate-8</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is8 => Token("8");

    /// <summary>Adds <c>translate-10</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is10 => Token("10");

    /// <summary>Adds <c>translate-12</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is12 => Token("12");

    /// <summary>Adds <c>translate-16</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is16 => Token("16");

    /// <summary>Adds <c>translate-20</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is20 => Token("20");

    /// <summary>Adds <c>translate-24</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is24 => Token("24");

    /// <summary>Adds <c>translate-32</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is32 => Token("32");

    /// <summary>Adds <c>translate-40</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is40 => Token("40");

    /// <summary>Adds <c>translate-48</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is48 => Token("48");

    /// <summary>Adds <c>translate-64</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is64 => Token("64");

    /// <summary>Adds <c>translate-96</c> (or its selected axis variant).</summary>
    public TranslateBuilder Is96 => Token("96");

    /// <summary>Adds <c>translate-px</c> (or its selected axis variant).</summary>
    public TranslateBuilder Px => Token("px");

    /// <summary>Adds <c>translate-1/2</c> (or its selected axis variant).</summary>
    public TranslateBuilder Half => Token("1/2");

    /// <summary>Adds <c>translate-full</c> (or its selected axis variant).</summary>
    public TranslateBuilder Full => Token("full");

    /// <summary>Adds <c>translate-none</c>, clearing translation on every axis.</summary>
    public TranslateBuilder None => Token("translate-none");

    /// <summary>Adds <c>-translate-1</c> (or its selected axis variant).</summary>
    public TranslateBuilder Negative1 => Token("-1");

    /// <summary>Adds <c>-translate-2</c> (or its selected axis variant).</summary>
    public TranslateBuilder Negative2 => Token("-2");

    /// <summary>Adds <c>-translate-4</c> (or its selected axis variant).</summary>
    public TranslateBuilder Negative4 => Token("-4");

    /// <summary>Adds <c>-translate-8</c> (or its selected axis variant).</summary>
    public TranslateBuilder Negative8 => Token("-8");

    /// <summary>Adds <c>-translate-1/2</c> (or its selected axis variant).</summary>
    public TranslateBuilder NegativeHalf => Token("-1/2");

    /// <summary>Adds <c>-translate-full</c> (or its selected axis variant).</summary>
    public TranslateBuilder NegativeFull => Token("-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public TranslateBuilder Token(string value)
    {
        string prefix = "translate-" + _axis;
        _axis = "";
        // Complete utilities retain their explicit axis; suffixes use the pending axis.
        if (value.StartsWith("translate-", System.StringComparison.Ordinal) ||
            value.StartsWith("-translate-", System.StringComparison.Ordinal))
            return ChainClass(value);

        return ChainClass(UtilityToken.WithSignedPrefix(value, prefix));
    }
}
