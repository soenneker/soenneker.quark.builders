namespace Soenneker.Quark;

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

    public DurationBuilder Is0 => ChainValue(DurationEnum.Is0Value);
    public DurationBuilder Is75 => ChainValue(DurationEnum.Is75Value);
    public DurationBuilder Is100 => ChainValue(DurationEnum.Is100Value);
    public DurationBuilder Is150 => ChainValue(DurationEnum.Is150Value);
    public DurationBuilder Is200 => ChainValue(DurationEnum.Is200Value);
    public DurationBuilder Is300 => ChainValue(DurationEnum.Is300Value);
    public DurationBuilder Is500 => ChainValue(DurationEnum.Is500Value);
    public DurationBuilder Is700 => ChainValue(DurationEnum.Is700Value);
    public DurationBuilder Is1000 => ChainValue(DurationEnum.Is1000Value);
    public DurationBuilder Token(string value) => ChainValue(NormalizeDurationClass(value));


    private static string NormalizeDurationClass(string value)
    {
        if (value.Length == 0)
            return string.Empty;

        return value.StartsWith("duration-") ? value : "duration-" + value;
    }
}
