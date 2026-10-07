namespace Soenneker.Quark;

/// <summary>
/// Represents the duration builder.
/// </summary>
[TailwindPrefix("duration-", Responsive = true)]
public sealed class DurationBuilder : FinalClassUtilityBuilder<DurationBuilder>
{
    internal DurationBuilder()
    {
    }

    internal DurationBuilder(DurationEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal DurationBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public DurationBuilder Is0 => ChainClass(DurationEnum.Is0Value);
    /// <summary>
    /// Gets or sets is75.
    /// </summary>
    public DurationBuilder Is75 => ChainClass(DurationEnum.Is75Value);
    /// <summary>
    /// Gets or sets is100.
    /// </summary>
    public DurationBuilder Is100 => ChainClass(DurationEnum.Is100Value);
    /// <summary>
    /// Gets or sets is150.
    /// </summary>
    public DurationBuilder Is150 => ChainClass(DurationEnum.Is150Value);
    /// <summary>
    /// Gets or sets is200.
    /// </summary>
    public DurationBuilder Is200 => ChainClass(DurationEnum.Is200Value);
    /// <summary>
    /// Gets or sets is300.
    /// </summary>
    public DurationBuilder Is300 => ChainClass(DurationEnum.Is300Value);
    /// <summary>
    /// Gets or sets is500.
    /// </summary>
    public DurationBuilder Is500 => ChainClass(DurationEnum.Is500Value);
    /// <summary>
    /// Gets or sets is700.
    /// </summary>
    public DurationBuilder Is700 => ChainClass(DurationEnum.Is700Value);
    /// <summary>
    /// Gets or sets is1000.
    /// </summary>
    public DurationBuilder Is1000 => ChainClass(DurationEnum.Is1000Value);
    /// <summary>
    /// Adds an arbitrary duration utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DurationBuilder Token(string value) => ChainClass(("duration-" + value));



}
