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
    public VariantBuilder OnHover => Chain("hover");
    public VariantBuilder Focus => Chain("focus");
    public VariantBuilder OnFocus => Chain("focus");
    public VariantBuilder FocusVisible => Chain("focus-visible");
    public VariantBuilder OnFocusVisible => Chain("focus-visible");
    public VariantBuilder Active => Chain("active");
    public VariantBuilder OnActive => Chain("active");
    public VariantBuilder Disabled => Chain("disabled");
    public VariantBuilder OnDisabled => Chain("disabled");
    public VariantBuilder Dark => Chain("dark");
    public VariantBuilder OnDark => Chain("dark");
    public VariantBuilder Visited => Chain("visited");
    public VariantBuilder OnVisited => Chain("visited");
    public VariantBuilder Checked => Chain("checked");
    public VariantBuilder OnChecked => Chain("checked");
    public VariantBuilder Open => Chain("open");
    public VariantBuilder OnOpen => Chain("open");
    public VariantBuilder First => Chain("first");
    public VariantBuilder OnFirst => Chain("first");
    public VariantBuilder Last => Chain("last");
    public VariantBuilder OnLast => Chain("last");
    public VariantBuilder Odd => Chain("odd");
    public VariantBuilder OnOdd => Chain("odd");
    public VariantBuilder Even => Chain("even");
    public VariantBuilder OnEven => Chain("even");
    public VariantBuilder Before => Chain("before");
    public VariantBuilder OnBefore => Chain("before");
    public VariantBuilder After => Chain("after");
    public VariantBuilder OnAfter => Chain("after");
    public VariantBuilder OnBase => ChainBreakpoint(BreakpointType.Base);
    public VariantBuilder OnSm => ChainBreakpoint(BreakpointType.Sm);
    public VariantBuilder OnMd => ChainBreakpoint(BreakpointType.Md);
    public VariantBuilder OnLg => ChainBreakpoint(BreakpointType.Lg);
    public VariantBuilder OnXl => ChainBreakpoint(BreakpointType.Xl);
    public VariantBuilder On2xl => ChainBreakpoint(BreakpointType.Xxl);
    public VariantBuilder OnMaxSm => Chain("max-sm");
    public VariantBuilder OnMaxMd => Chain("max-md");
    public VariantBuilder OnMaxLg => Chain("max-lg");
    public VariantBuilder OnMaxXl => Chain("max-xl");
    public VariantBuilder OnContainerSm => Chain("@sm");
    public VariantBuilder OnContainerMd => Chain("@md");
    public VariantBuilder OnContainerLg => Chain("@lg");
    public VariantBuilder OnContainerXl => Chain("@xl");
    public VariantBuilder OnContainer2xl => Chain("@2xl");
    public VariantBuilder OnContainerMaxSm => Chain("@max-sm");
    public VariantBuilder OnContainerMaxMd => Chain("@max-md");
    public VariantBuilder OnContainer => Chain("@container");
    public VariantBuilder OnContainerNormal => Chain("@container-normal");
    public VariantBuilder FocusWithin => Chain("focus-within");
    public VariantBuilder OnFocusWithin => Chain("focus-within");
    public VariantBuilder Target => Chain("target");
    public VariantBuilder OnTarget => Chain("target");
    public VariantBuilder Enabled => Chain("enabled");
    public VariantBuilder OnEnabled => Chain("enabled");
    public VariantBuilder Indeterminate => Chain("indeterminate");
    public VariantBuilder OnIndeterminate => Chain("indeterminate");
    public VariantBuilder Default => Chain("default");
    public VariantBuilder OnDefault => Chain("default");
    public VariantBuilder Required => Chain("required");
    public VariantBuilder OnRequired => Chain("required");
    public VariantBuilder Optional => Chain("optional");
    public VariantBuilder OnOptional => Chain("optional");
    public VariantBuilder Valid => Chain("valid");
    public VariantBuilder OnValid => Chain("valid");
    public VariantBuilder Invalid => Chain("invalid");
    public VariantBuilder OnInvalid => Chain("invalid");
    public VariantBuilder InRange => Chain("in-range");
    public VariantBuilder OnInRange => Chain("in-range");
    public VariantBuilder OutOfRange => Chain("out-of-range");
    public VariantBuilder OnOutOfRange => Chain("out-of-range");
    public VariantBuilder PlaceholderShown => Chain("placeholder-shown");
    public VariantBuilder OnPlaceholderShown => Chain("placeholder-shown");
    public VariantBuilder ReadOnly => Chain("read-only");
    public VariantBuilder OnReadOnly => Chain("read-only");
    public VariantBuilder ReadWrite => Chain("read-write");
    public VariantBuilder OnReadWrite => Chain("read-write");
    public VariantBuilder Autofill => Chain("autofill");
    public VariantBuilder OnAutofill => Chain("autofill");
    public VariantBuilder MotionSafe => Chain("motion-safe");
    public VariantBuilder OnMotionSafe => Chain("motion-safe");
    public VariantBuilder MotionReduce => Chain("motion-reduce");
    public VariantBuilder OnMotionReduce => Chain("motion-reduce");
    public VariantBuilder ContrastMore => Chain("contrast-more");
    public VariantBuilder OnContrastMore => Chain("contrast-more");
    public VariantBuilder ContrastLess => Chain("contrast-less");
    public VariantBuilder OnContrastLess => Chain("contrast-less");
    public VariantBuilder ForcedColors => Chain("forced-colors");
    public VariantBuilder OnForcedColors => Chain("forced-colors");
    public VariantBuilder Portrait => Chain("portrait");
    public VariantBuilder OnPortrait => Chain("portrait");
    public VariantBuilder Landscape => Chain("landscape");
    public VariantBuilder OnLandscape => Chain("landscape");
    public VariantBuilder Print => Chain("print");
    public VariantBuilder OnPrint => Chain("print");
    public VariantBuilder Rtl => Chain("rtl");
    public VariantBuilder OnRtl => Chain("rtl");
    public VariantBuilder Ltr => Chain("ltr");
    public VariantBuilder OnLtr => Chain("ltr");
    public VariantBuilder Only => Chain("only");
    public VariantBuilder OnOnly => Chain("only");
    public VariantBuilder Empty => Chain("empty");
    public VariantBuilder OnEmpty => Chain("empty");
    public VariantBuilder Placeholder => Chain("placeholder");
    public VariantBuilder OnPlaceholder => Chain("placeholder");
    public VariantBuilder Selection => Chain("selection");
    public VariantBuilder OnSelection => Chain("selection");
    public VariantBuilder Marker => Chain("marker");
    public VariantBuilder OnMarker => Chain("marker");
    public VariantBuilder FirstLetter => Chain("first-letter");
    public VariantBuilder OnFirstLetter => Chain("first-letter");
    public VariantBuilder FirstLine => Chain("first-line");
    public VariantBuilder OnFirstLine => Chain("first-line");
    public VariantBuilder File => Chain("file");
    public VariantBuilder OnFile => Chain("file");
    public VariantBuilder Backdrop => Chain("backdrop");
    public VariantBuilder OnBackdrop => Chain("backdrop");
    public VariantBuilder GroupHover => Chain("group-hover");
    public VariantBuilder OnGroupHover => Chain("group-hover");
    public VariantBuilder GroupFocus => Chain("group-focus");
    public VariantBuilder OnGroupFocus => Chain("group-focus");
    public VariantBuilder GroupFocusVisible => Chain("group-focus-visible");
    public VariantBuilder OnGroupFocusVisible => Chain("group-focus-visible");
    public VariantBuilder GroupActive => Chain("group-active");
    public VariantBuilder OnGroupActive => Chain("group-active");
    public VariantBuilder GroupVisited => Chain("group-visited");
    public VariantBuilder OnGroupVisited => Chain("group-visited");
    public VariantBuilder GroupDisabled => Chain("group-disabled");
    public VariantBuilder OnGroupDisabled => Chain("group-disabled");
    public VariantBuilder GroupChecked => Chain("group-checked");
    public VariantBuilder OnGroupChecked => Chain("group-checked");
    public VariantBuilder GroupOpen => Chain("group-open");
    public VariantBuilder OnGroupOpen => Chain("group-open");
    public VariantBuilder PeerHover => Chain("peer-hover");
    public VariantBuilder OnPeerHover => Chain("peer-hover");
    public VariantBuilder PeerFocus => Chain("peer-focus");
    public VariantBuilder OnPeerFocus => Chain("peer-focus");
    public VariantBuilder PeerFocusVisible => Chain("peer-focus-visible");
    public VariantBuilder OnPeerFocusVisible => Chain("peer-focus-visible");
    public VariantBuilder PeerActive => Chain("peer-active");
    public VariantBuilder OnPeerActive => Chain("peer-active");
    public VariantBuilder PeerDisabled => Chain("peer-disabled");
    public VariantBuilder OnPeerDisabled => Chain("peer-disabled");
    public VariantBuilder PeerChecked => Chain("peer-checked");
    public VariantBuilder OnPeerChecked => Chain("peer-checked");
    public VariantBuilder PeerInvalid => Chain("peer-invalid");
    public VariantBuilder OnPeerInvalid => Chain("peer-invalid");
    public VariantBuilder PeerRequired => Chain("peer-required");
    public VariantBuilder OnPeerRequired => Chain("peer-required");
    public VariantBuilder PeerPlaceholderShown => Chain("peer-placeholder-shown");
    public VariantBuilder OnPeerPlaceholderShown => Chain("peer-placeholder-shown");
    public VariantBuilder PeerOpen => Chain("peer-open");
    public VariantBuilder OnPeerOpen => Chain("peer-open");
    public VariantBuilder AriaChecked => Chain("aria-checked");
    public VariantBuilder OnAriaChecked => Chain("aria-checked");
    public VariantBuilder AriaDisabled => Chain("aria-disabled");
    public VariantBuilder OnAriaDisabled => Chain("aria-disabled");
    public VariantBuilder AriaExpanded => Chain("aria-expanded");
    public VariantBuilder OnAriaExpanded => Chain("aria-expanded");
    public VariantBuilder AriaHidden => Chain("aria-hidden");
    public VariantBuilder OnAriaHidden => Chain("aria-hidden");
    public VariantBuilder AriaPressed => Chain("aria-pressed");
    public VariantBuilder OnAriaPressed => Chain("aria-pressed");
    public VariantBuilder AriaReadonly => Chain("aria-readonly");
    public VariantBuilder OnAriaReadonly => Chain("aria-readonly");
    public VariantBuilder AriaRequired => Chain("aria-required");
    public VariantBuilder OnAriaRequired => Chain("aria-required");
    public VariantBuilder AriaSelected => Chain("aria-selected");
    public VariantBuilder OnAriaSelected => Chain("aria-selected");

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
