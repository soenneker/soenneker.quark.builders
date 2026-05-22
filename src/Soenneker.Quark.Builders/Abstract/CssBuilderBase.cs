using System;

namespace Soenneker.Quark;

public abstract class CssBuilderBase : ICssBuilder
{
    public VariantBuilder Data(string attribute, string value) => Variant.Of(this).Data(attribute, value);
    public VariantBuilder DataState(string value) => Variant.Of(this).DataState(value);
    public VariantBuilder Aria(string attribute) => Variant.Of(this).Aria(attribute);
    public VariantBuilder Aria(string attribute, string value) => Variant.Of(this).Aria(attribute, value);
    public VariantBuilder Group(string modifier) => Variant.Of(this).Group(modifier);
    public VariantBuilder Group(string modifier, string name) => Variant.Of(this).Group(modifier, name);
    public VariantBuilder Peer(string modifier) => Variant.Of(this).Peer(modifier);
    public VariantBuilder Peer(string modifier, string name) => Variant.Of(this).Peer(modifier, name);
    public VariantBuilder Has(string selector) => Variant.Of(this).Has(selector);
    public VariantBuilder Not(string selector) => Variant.Of(this).Not(selector);
    public VariantBuilder Supports(string condition) => Variant.Of(this).Supports(condition);
    public VariantBuilder Modifier(string modifier) => Variant.Of(this).Modifier(modifier);
    public VariantBuilder Modifiers(params string[] modifiers) => Variant.Of(this).Modifiers(modifiers);
    public VariantBuilder Custom(string modifier) => Variant.Of(this).Custom(modifier);

    public abstract string ToClass();

    public virtual string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}

public abstract class CssBuilderBase<TBuilder> : CssBuilderBase where TBuilder : CssBuilderBase<TBuilder>
{
    private string? _pendingModifierChain;

    public new TBuilder Modifier(string modifier) => SetPendingModifier(modifier);
    public new TBuilder Custom(string modifier) => SetPendingModifier(modifier);

    public new TBuilder Modifiers(params string[] modifiers)
    {
        for (var i = 0; i < modifiers.Length; i++)
        {
            string modifier = modifiers[i];

            if (!string.IsNullOrWhiteSpace(modifier))
                SetPendingModifier(modifier);
        }

        return (TBuilder)this;
    }

    public TBuilder OnSm => SetPendingModifier("sm");
    public TBuilder OnBase => (TBuilder)this;
    public TBuilder OnMd => SetPendingModifier("md");
    public TBuilder OnLg => SetPendingModifier("lg");
    public TBuilder OnXl => SetPendingModifier("xl");
    public TBuilder On2xl => SetPendingModifier("2xl");
    public TBuilder OnMaxSm => SetPendingModifier("max-sm");
    public TBuilder OnMaxMd => SetPendingModifier("max-md");
    public TBuilder OnMaxLg => SetPendingModifier("max-lg");
    public TBuilder OnMaxXl => SetPendingModifier("max-xl");
    public TBuilder OnContainerSm => SetPendingModifier("@sm");
    public TBuilder OnContainerMd => SetPendingModifier("@md");
    public TBuilder OnContainerLg => SetPendingModifier("@lg");
    public TBuilder OnContainerXl => SetPendingModifier("@xl");
    public TBuilder OnContainer2xl => SetPendingModifier("@2xl");
    public TBuilder OnContainerMaxSm => SetPendingModifier("@max-sm");
    public TBuilder OnContainerMaxMd => SetPendingModifier("@max-md");
    public TBuilder OnContainer => SetPendingModifier("@container");
    public TBuilder OnContainerNormal => SetPendingModifier("@container-normal");
    public TBuilder OnHover => SetPendingModifier("hover");
    public TBuilder OnFocus => SetPendingModifier("focus");
    public TBuilder OnFocusVisible => SetPendingModifier("focus-visible");
    public TBuilder OnFocusWithin => SetPendingModifier("focus-within");
    public TBuilder OnActive => SetPendingModifier("active");
    public TBuilder OnVisited => SetPendingModifier("visited");
    public TBuilder OnTarget => SetPendingModifier("target");
    public TBuilder OnOpen => SetPendingModifier("open");
    public TBuilder OnDisabled => SetPendingModifier("disabled");
    public TBuilder OnEnabled => SetPendingModifier("enabled");
    public TBuilder OnChecked => SetPendingModifier("checked");
    public TBuilder OnIndeterminate => SetPendingModifier("indeterminate");
    public TBuilder OnDefault => SetPendingModifier("default");
    public TBuilder OnRequired => SetPendingModifier("required");
    public TBuilder OnOptional => SetPendingModifier("optional");
    public TBuilder OnValid => SetPendingModifier("valid");
    public TBuilder OnInvalid => SetPendingModifier("invalid");
    public TBuilder OnInRange => SetPendingModifier("in-range");
    public TBuilder OnOutOfRange => SetPendingModifier("out-of-range");
    public TBuilder OnPlaceholderShown => SetPendingModifier("placeholder-shown");
    public TBuilder OnReadOnly => SetPendingModifier("read-only");
    public TBuilder OnReadWrite => SetPendingModifier("read-write");
    public TBuilder OnAutofill => SetPendingModifier("autofill");
    public TBuilder OnMotionSafe => SetPendingModifier("motion-safe");
    public TBuilder OnMotionReduce => SetPendingModifier("motion-reduce");
    public TBuilder OnContrastMore => SetPendingModifier("contrast-more");
    public TBuilder OnContrastLess => SetPendingModifier("contrast-less");
    public TBuilder OnForcedColors => SetPendingModifier("forced-colors");
    public TBuilder OnPortrait => SetPendingModifier("portrait");
    public TBuilder OnLandscape => SetPendingModifier("landscape");
    public TBuilder OnPrint => SetPendingModifier("print");
    public TBuilder OnRtl => SetPendingModifier("rtl");
    public TBuilder OnLtr => SetPendingModifier("ltr");
    public TBuilder OnDark => SetPendingModifier("dark");
    public TBuilder OnFirst => SetPendingModifier("first");
    public TBuilder OnLast => SetPendingModifier("last");
    public TBuilder OnOnly => SetPendingModifier("only");
    public TBuilder OnOdd => SetPendingModifier("odd");
    public TBuilder OnEven => SetPendingModifier("even");
    public TBuilder OnEmpty => SetPendingModifier("empty");
    public TBuilder OnBefore => SetPendingModifier("before");
    public TBuilder OnAfter => SetPendingModifier("after");
    public TBuilder OnPlaceholder => SetPendingModifier("placeholder");
    public TBuilder OnSelection => SetPendingModifier("selection");
    public TBuilder OnMarker => SetPendingModifier("marker");
    public TBuilder OnFirstLetter => SetPendingModifier("first-letter");
    public TBuilder OnFirstLine => SetPendingModifier("first-line");
    public TBuilder OnFile => SetPendingModifier("file");
    public TBuilder OnBackdrop => SetPendingModifier("backdrop");
    public TBuilder OnGroupHover => SetPendingModifier("group-hover");
    public TBuilder OnGroupFocus => SetPendingModifier("group-focus");
    public TBuilder OnGroupFocusVisible => SetPendingModifier("group-focus-visible");
    public TBuilder OnGroupActive => SetPendingModifier("group-active");
    public TBuilder OnGroupVisited => SetPendingModifier("group-visited");
    public TBuilder OnGroupDisabled => SetPendingModifier("group-disabled");
    public TBuilder OnGroupChecked => SetPendingModifier("group-checked");
    public TBuilder OnGroupOpen => SetPendingModifier("group-open");
    public TBuilder OnPeerHover => SetPendingModifier("peer-hover");
    public TBuilder OnPeerFocus => SetPendingModifier("peer-focus");
    public TBuilder OnPeerFocusVisible => SetPendingModifier("peer-focus-visible");
    public TBuilder OnPeerActive => SetPendingModifier("peer-active");
    public TBuilder OnPeerDisabled => SetPendingModifier("peer-disabled");
    public TBuilder OnPeerChecked => SetPendingModifier("peer-checked");
    public TBuilder OnPeerInvalid => SetPendingModifier("peer-invalid");
    public TBuilder OnPeerRequired => SetPendingModifier("peer-required");
    public TBuilder OnPeerPlaceholderShown => SetPendingModifier("peer-placeholder-shown");
    public TBuilder OnPeerOpen => SetPendingModifier("peer-open");
    public TBuilder OnAriaChecked => SetPendingModifier("aria-checked");
    public TBuilder OnAriaDisabled => SetPendingModifier("aria-disabled");
    public TBuilder OnAriaExpanded => SetPendingModifier("aria-expanded");
    public TBuilder OnAriaHidden => SetPendingModifier("aria-hidden");
    public TBuilder OnAriaPressed => SetPendingModifier("aria-pressed");
    public TBuilder OnAriaReadonly => SetPendingModifier("aria-readonly");
    public TBuilder OnAriaRequired => SetPendingModifier("aria-required");
    public TBuilder OnAriaSelected => SetPendingModifier("aria-selected");

    private TBuilder SetPendingModifier(string modifier)
    {
        if (_pendingModifierChain is null)
        {
            _pendingModifierChain = modifier;
            return (TBuilder)this;
        }

        if (IsBreakpointModifier(modifier))
        {
            _pendingModifierChain = AppendModifierChain(_pendingModifierChain, modifier);
        }
        else
        {
            _pendingModifierChain = $"{_pendingModifierChain}:{modifier}";
        }

        return (TBuilder)this;
    }

    protected static string AppendModifierChain(string? existingModifierChain, string modifier)
    {
        if (string.IsNullOrEmpty(existingModifierChain))
            return modifier;

        if (!IsBreakpointModifier(modifier))
            return $"{existingModifierChain}:{modifier}";

        int insertIndex = GetBreakpointPrefixLength(existingModifierChain);

        if (insertIndex <= 0)
            return $"{modifier}:{existingModifierChain}";

        if (insertIndex >= existingModifierChain.Length)
            return $"{existingModifierChain}:{modifier}";

        return $"{existingModifierChain[..insertIndex]}:{modifier}:{existingModifierChain[(insertIndex + 1)..]}";
    }

    private static int GetBreakpointPrefixLength(string modifierChain)
    {
        var segmentStart = 0;
        var prefixEnd = -1;

        for (var i = 0; i <= modifierChain.Length; i++)
        {
            if (i < modifierChain.Length && modifierChain[i] != ':')
                continue;

            ReadOnlySpan<char> segment = modifierChain.AsSpan(segmentStart, i - segmentStart);

            if (!IsBreakpointModifier(segment))
                break;

            prefixEnd = i;
            segmentStart = i + 1;
        }

        return prefixEnd;
    }

    protected static bool IsBreakpointModifier(string modifier)
    {
        return modifier is "sm" or "md" or "lg" or "xl" or "2xl" or "max-sm" or "max-md" or "max-lg" or "max-xl"
            or "@sm" or "@md" or "@lg" or "@xl" or "@2xl" or "@max-sm" or "@max-md";
    }

    protected static bool IsBreakpointModifier(ReadOnlySpan<char> modifier)
    {
        return modifier is "sm" or "md" or "lg" or "xl" or "2xl" or "max-sm" or "max-md" or "max-lg" or "max-xl"
            or "@sm" or "@md" or "@lg" or "@xl" or "@2xl" or "@max-sm" or "@max-md";
    }

    protected string? ConsumePendingModifierChain()
    {
        string? modifiers = _pendingModifierChain;
        _pendingModifierChain = null;
        return modifiers;
    }

    protected string? PendingModifierChain => _pendingModifierChain;
}
