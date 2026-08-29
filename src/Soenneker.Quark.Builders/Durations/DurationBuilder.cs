namespace Soenneker.Quark;

/// <summary>
/// Represents the duration builder.
/// </summary>
[TailwindPrefix("duration-", Responsive = true)]
public sealed class DurationBuilder : ResponsiveUtilityBuilder<DurationBuilder>
{
    internal DurationBuilder()
    {
    }

    internal DurationBuilder(DurationEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DurationBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public DurationBuilder Is0 => ChainValue(DurationEnum.Is0Value);
    /// <summary>
    /// Gets or sets is75.
    /// </summary>
    public DurationBuilder Is75 => ChainValue(DurationEnum.Is75Value);
    /// <summary>
    /// Gets or sets is100.
    /// </summary>
    public DurationBuilder Is100 => ChainValue(DurationEnum.Is100Value);
    /// <summary>
    /// Gets or sets is150.
    /// </summary>
    public DurationBuilder Is150 => ChainValue(DurationEnum.Is150Value);
    /// <summary>
    /// Gets or sets is200.
    /// </summary>
    public DurationBuilder Is200 => ChainValue(DurationEnum.Is200Value);
    /// <summary>
    /// Gets or sets is300.
    /// </summary>
    public DurationBuilder Is300 => ChainValue(DurationEnum.Is300Value);
    /// <summary>
    /// Gets or sets is500.
    /// </summary>
    public DurationBuilder Is500 => ChainValue(DurationEnum.Is500Value);
    /// <summary>
    /// Gets or sets is700.
    /// </summary>
    public DurationBuilder Is700 => ChainValue(DurationEnum.Is700Value);
    /// <summary>
    /// Gets or sets is1000.
    /// </summary>
    public DurationBuilder Is1000 => ChainValue(DurationEnum.Is1000Value);
    /// <summary>
    /// Adds an arbitrary duration utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DurationBuilder Token(string value) => ChainValue(NormalizeDurationClass(value));


    private static string NormalizeDurationClass(string value)
    {
        if (value.Length == 0)
            return string.Empty;

        return value.StartsWith("duration-") ? value : "duration-" + value;
    }
}
