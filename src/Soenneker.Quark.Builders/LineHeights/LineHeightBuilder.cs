using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

public sealed class LineHeightBuilder : ResponsiveUtilityBuilder<LineHeightBuilder>
{
    private string _lastValue;

    internal LineHeightBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
        _lastValue = NormalizeValue(value);
    }

    public LineHeightBuilder Is1 => Set("1");
    public LineHeightBuilder None => Set("none");
    public LineHeightBuilder Tight => Set("tight");
    public LineHeightBuilder Snug => Set("snug");
    public LineHeightBuilder Normal => Set("normal");
    public LineHeightBuilder Relaxed => Set("relaxed");
    public LineHeightBuilder Loose => Set("loose");
    public LineHeightBuilder Large => Set("relaxed");
    public LineHeightBuilder Token(string value) => Set(value);

    public LineHeightBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public LineHeightBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public LineHeightBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public LineHeightBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public LineHeightBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public LineHeightBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    private LineHeightBuilder Set(string value)
    {
        _lastValue = value;
        return ChainValue($"leading-{value}");
    }

    public override string ToStyle() => _lastValue switch
    {
        "1" => "line-height: calc(var(--spacing) * 1)",
        "none" => "line-height: 1",
        "tight" => "line-height: 1.25",
        "snug" => "line-height: 1.375",
        "normal" => "line-height: 1.5",
        "relaxed" => "line-height: 1.625",
        "loose" => "line-height: 2",
        _ => string.Empty
    };

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string NormalizeValue(string value) =>
        value.StartsWith("leading-", System.StringComparison.Ordinal) ? value["leading-".Length..] : value;
}
