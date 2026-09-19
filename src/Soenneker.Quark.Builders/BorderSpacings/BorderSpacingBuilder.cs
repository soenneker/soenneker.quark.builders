namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for table border spacing, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("border-spacing-", Responsive = true)]
public sealed class BorderSpacingBuilder : FinalClassUtilityBuilder<BorderSpacingBuilder>
{
    private string _axis = "";

    internal BorderSpacingBuilder()
    {
    }

    internal BorderSpacingBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Selects the x axis for the next utility only.</summary>
    public BorderSpacingBuilder OnX
    {
        get
        {
            _axis = "x-";
            return this;
        }
    }

    /// <summary>Selects the y axis for the next utility only.</summary>
    public BorderSpacingBuilder OnY
    {
        get
        {
            _axis = "y-";
            return this;
        }
    }

    /// <summary>Adds <c>border-spacing-0</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is0 => Token("0");

    /// <summary>Adds <c>border-spacing-0.5</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is0_5 => Token("0.5");

    /// <summary>Adds <c>border-spacing-1</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is1 => Token("1");

    /// <summary>Adds <c>border-spacing-1.5</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is1_5 => Token("1.5");

    /// <summary>Adds <c>border-spacing-2</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is2 => Token("2");

    /// <summary>Adds <c>border-spacing-2.5</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is2_5 => Token("2.5");

    /// <summary>Adds <c>border-spacing-3</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is3 => Token("3");

    /// <summary>Adds <c>border-spacing-3.5</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is3_5 => Token("3.5");

    /// <summary>Adds <c>border-spacing-4</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is4 => Token("4");

    /// <summary>Adds <c>border-spacing-5</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is5 => Token("5");

    /// <summary>Adds <c>border-spacing-6</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is6 => Token("6");

    /// <summary>Adds <c>border-spacing-8</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is8 => Token("8");

    /// <summary>Adds <c>border-spacing-10</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is10 => Token("10");

    /// <summary>Adds <c>border-spacing-12</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is12 => Token("12");

    /// <summary>Adds <c>border-spacing-16</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is16 => Token("16");

    /// <summary>Adds <c>border-spacing-20</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is20 => Token("20");

    /// <summary>Adds <c>border-spacing-24</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is24 => Token("24");

    /// <summary>Adds <c>border-spacing-32</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is32 => Token("32");

    /// <summary>Adds <c>border-spacing-40</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is40 => Token("40");

    /// <summary>Adds <c>border-spacing-48</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is48 => Token("48");

    /// <summary>Adds <c>border-spacing-64</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is64 => Token("64");

    /// <summary>Adds <c>border-spacing-96</c> (or its selected axis variant).</summary>
    public BorderSpacingBuilder Is96 => Token("96");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BorderSpacingBuilder Token(string value)
    {
        string prefix = "border-spacing-" + _axis;
        _axis = "";
        // Complete utilities retain their explicit axis; suffixes use the pending axis.
        if (value.StartsWith("border-spacing-", System.StringComparison.Ordinal))
            return ChainClass(value);

        return ChainClass(UtilityToken.WithPrefix(value, prefix));
    }
}
