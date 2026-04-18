using System.Collections.Generic;

namespace Soenneker.Quark;

public sealed class VariantBuilder : ICssBuilder
{
    private readonly ICssBuilder _builder;
    private readonly List<string> _modifiers = new(4);
    private static readonly HashSet<string> _responsiveModifiers = new(System.StringComparer.Ordinal)
    {
        "sm",
        "md",
        "lg",
        "xl",
        "2xl"
    };

    internal VariantBuilder(ICssBuilder builder)
    {
        _builder = builder;
    }

    public VariantBuilder Hover => Chain("hover");
    public VariantBuilder Focus => Chain("focus");
    public VariantBuilder FocusVisible => Chain("focus-visible");
    public VariantBuilder Active => Chain("active");
    public VariantBuilder Disabled => Chain("disabled");
    public VariantBuilder Dark => Chain("dark");
    public VariantBuilder Visited => Chain("visited");
    public VariantBuilder Checked => Chain("checked");
    public VariantBuilder Open => Chain("open");
    public VariantBuilder First => Chain("first");
    public VariantBuilder Last => Chain("last");
    public VariantBuilder Odd => Chain("odd");
    public VariantBuilder Even => Chain("even");
    public VariantBuilder Before => Chain("before");
    public VariantBuilder After => Chain("after");
    public VariantBuilder OnBase => ChainBreakpoint(BreakpointType.Base);
    public VariantBuilder OnSm => ChainBreakpoint(BreakpointType.Sm);
    public VariantBuilder OnMd => ChainBreakpoint(BreakpointType.Md);
    public VariantBuilder OnLg => ChainBreakpoint(BreakpointType.Lg);
    public VariantBuilder OnXl => ChainBreakpoint(BreakpointType.Xl);
    public VariantBuilder On2xl => ChainBreakpoint(BreakpointType.Xxl);
    public VariantBuilder Placeholder => Chain("placeholder");
    public VariantBuilder Selection => Chain("selection");
    public VariantBuilder Marker => Chain("marker");
    public VariantBuilder FirstLetter => Chain("first-letter");
    public VariantBuilder FirstLine => Chain("first-line");
    public VariantBuilder File => Chain("file");
    public VariantBuilder Backdrop => Chain("backdrop");
    public VariantBuilder GroupHover => Chain("group-hover");
    public VariantBuilder GroupFocus => Chain("group-focus");
    public VariantBuilder PeerHover => Chain("peer-hover");
    public VariantBuilder PeerFocus => Chain("peer-focus");

    public VariantBuilder Data(string attribute, string value) => Chain($"data-[{attribute}={value}]");
    public VariantBuilder DataState(string value) => Chain($"data-[state={value}]");
    public VariantBuilder Aria(string attribute) => Chain($"aria-{attribute}");
    public VariantBuilder Aria(string attribute, string value) => Chain($"aria-[{attribute}={value}]");
    public VariantBuilder Group(string modifier) => Chain($"group-{modifier}");
    public VariantBuilder Group(string modifier, string name) => Chain($"group-{modifier}/{name}");
    public VariantBuilder Peer(string modifier) => Chain($"peer-{modifier}");
    public VariantBuilder Peer(string modifier, string name) => Chain($"peer-{modifier}/{name}");
    public VariantBuilder Has(string selector) => Chain($"has-[{selector}]");
    public VariantBuilder Not(string selector) => Chain($"not-[{selector}]");
    public VariantBuilder Supports(string condition) => Chain($"supports-[{condition}]");
    public VariantBuilder Modifier(string modifier) => Chain(modifier);
    public VariantBuilder Modifiers(params string[] modifiers)
    {
        for (var i = 0; i < modifiers.Length; i++)
        {
            string modifier = modifiers[i];

            if (!string.IsNullOrWhiteSpace(modifier))
                _modifiers.Add(modifier);
        }

        return this;
    }

    public VariantBuilder Custom(string modifier) => Chain(modifier);

    private VariantBuilder Chain(string modifier)
    {
        _modifiers.Add(modifier);
        return this;
    }

    private VariantBuilder ChainBreakpoint(BreakpointType breakpoint)
    {
        string token = BreakpointUtil.GetBreakpointToken(breakpoint);

        for (var i = _modifiers.Count - 1; i >= 0; i--)
        {
            if (_responsiveModifiers.Contains(_modifiers[i]))
                _modifiers.RemoveAt(i);
        }

        if (token.Length > 0)
            _modifiers.Insert(0, token);

        return this;
    }

    public string ToClass() => BreakpointUtil.ApplyTailwindModifiers(_builder.ToClass(), _modifiers);

    public string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
