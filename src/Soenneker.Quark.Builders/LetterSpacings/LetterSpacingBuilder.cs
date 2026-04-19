using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

public sealed class LetterSpacingBuilder : ResponsiveUtilityBuilder<LetterSpacingBuilder>
{
    private string _lastValue;

    internal LetterSpacingBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
        _lastValue = NormalizeValue(value);
    }

    public LetterSpacingBuilder Tighter => Set("tighter");
    public LetterSpacingBuilder Tight => Set("tight");
    public LetterSpacingBuilder Normal => Set("normal");
    public LetterSpacingBuilder Wide => Set("wide");
    public LetterSpacingBuilder Wider => Set("wider");
    public LetterSpacingBuilder Widest => Set("widest");
    public LetterSpacingBuilder Token(string value) => Set(value);

    public LetterSpacingBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public LetterSpacingBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public LetterSpacingBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public LetterSpacingBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public LetterSpacingBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public LetterSpacingBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    private LetterSpacingBuilder Set(string value)
    {
        _lastValue = value;
        return ChainValue($"tracking-{value}");
    }

    public override string ToStyle() => _lastValue switch
    {
        "tighter" => "letter-spacing: -0.05em",
        "tight" => "letter-spacing: -0.025em",
        "normal" => "letter-spacing: 0em",
        "wide" => "letter-spacing: 0.025em",
        "wider" => "letter-spacing: 0.05em",
        "widest" => "letter-spacing: 0.1em",
        _ => string.Empty
    };

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string NormalizeValue(string value) =>
        value.StartsWith("tracking-", System.StringComparison.Ordinal) ? value["tracking-".Length..] : value;
}
