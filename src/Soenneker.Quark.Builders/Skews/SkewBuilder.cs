namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for skew angles on both axes or a selected axis, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("skew-", Responsive = true)]
public sealed class SkewBuilder : FinalClassUtilityBuilder<SkewBuilder>
{
    private string _axis = "";

    internal SkewBuilder()
    {
    }

    internal SkewBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Selects the x axis for the next utility only.</summary>
    public SkewBuilder OnX
    {
        get
        {
            _axis = "x-";
            return this;
        }
    }

    /// <summary>Selects the y axis for the next utility only.</summary>
    public SkewBuilder OnY
    {
        get
        {
            _axis = "y-";
            return this;
        }
    }

    /// <summary>Adds <c>skew-0</c> (or its selected axis variant).</summary>
    public SkewBuilder Is0 => Token("0");

    /// <summary>Adds <c>skew-1</c> (or its selected axis variant).</summary>
    public SkewBuilder Is1 => Token("1");

    /// <summary>Adds <c>skew-2</c> (or its selected axis variant).</summary>
    public SkewBuilder Is2 => Token("2");

    /// <summary>Adds <c>skew-3</c> (or its selected axis variant).</summary>
    public SkewBuilder Is3 => Token("3");

    /// <summary>Adds <c>skew-6</c> (or its selected axis variant).</summary>
    public SkewBuilder Is6 => Token("6");

    /// <summary>Adds <c>skew-12</c> (or its selected axis variant).</summary>
    public SkewBuilder Is12 => Token("12");

    /// <summary>Adds <c>-skew-1</c> (or its selected axis variant).</summary>
    public SkewBuilder Negative1 => Token("-1");

    /// <summary>Adds <c>-skew-2</c> (or its selected axis variant).</summary>
    public SkewBuilder Negative2 => Token("-2");

    /// <summary>Adds <c>-skew-3</c> (or its selected axis variant).</summary>
    public SkewBuilder Negative3 => Token("-3");

    /// <summary>Adds <c>-skew-6</c> (or its selected axis variant).</summary>
    public SkewBuilder Negative6 => Token("-6");

    /// <summary>Adds <c>-skew-12</c> (or its selected axis variant).</summary>
    public SkewBuilder Negative12 => Token("-12");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public SkewBuilder Token(string value)
    {
        string prefix = "skew-" + _axis;
        _axis = "";
        // Complete utilities retain their explicit axis; suffixes use the pending axis.
        if (value.StartsWith("skew-", System.StringComparison.Ordinal) ||
            value.StartsWith("-skew-", System.StringComparison.Ordinal))
            return ChainClass(value);

        return ChainClass(UtilityToken.WithSignedPrefix(value, prefix));
    }
}
