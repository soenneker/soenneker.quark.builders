using System.Collections.Generic;

namespace Soenneker.Quark;

public sealed class VariantBuilder : ICssBuilder
{
    private readonly ICssBuilder _builder;
    private readonly List<string> _modifiers = new(4);

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
    public VariantBuilder GroupHover => Chain("group-hover");
    public VariantBuilder GroupFocus => Chain("group-focus");
    public VariantBuilder PeerHover => Chain("peer-hover");
    public VariantBuilder PeerFocus => Chain("peer-focus");

    public VariantBuilder Data(string attribute, string value) => Chain($"data-[{attribute}={value}]");
    public VariantBuilder DataState(string value) => Chain($"data-[state={value}]");
    public VariantBuilder Aria(string attribute) => Chain($"aria-{attribute}");
    public VariantBuilder Aria(string attribute, string value) => Chain($"aria-[{attribute}={value}]");
    public VariantBuilder Group(string modifier) => Chain($"group-{modifier}");
    public VariantBuilder Peer(string modifier) => Chain($"peer-{modifier}");
    public VariantBuilder Custom(string modifier) => Chain(modifier);

    private VariantBuilder Chain(string modifier)
    {
        _modifiers.Add(modifier);
        return this;
    }

    public string ToClass() => BreakpointUtil.ApplyTailwindModifiers(_builder.ToClass(), _modifiers);

    public string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
