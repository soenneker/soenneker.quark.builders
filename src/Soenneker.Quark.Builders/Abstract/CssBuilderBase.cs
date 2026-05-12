namespace Soenneker.Quark;

public abstract class CssBuilderBase : ICssBuilder
{
    public VariantBuilder Hover => Variant.Of(this).Hover;
    public VariantBuilder OnHover => Variant.Of(this).Hover;
    public VariantBuilder Focus => Variant.Of(this).Focus;
    public VariantBuilder OnFocus => Variant.Of(this).Focus;
    public VariantBuilder FocusVisible => Variant.Of(this).FocusVisible;
    public VariantBuilder OnFocusVisible => Variant.Of(this).FocusVisible;
    public VariantBuilder Active => Variant.Of(this).Active;
    public VariantBuilder OnActive => Variant.Of(this).Active;
    public VariantBuilder Disabled => Variant.Of(this).Disabled;
    public VariantBuilder OnDisabled => Variant.Of(this).Disabled;
    public VariantBuilder Dark => Variant.Of(this).Dark;
    public VariantBuilder OnDark => Variant.Of(this).Dark;
    public VariantBuilder Visited => Variant.Of(this).Visited;
    public VariantBuilder OnVisited => Variant.Of(this).Visited;
    public VariantBuilder Checked => Variant.Of(this).Checked;
    public VariantBuilder OnChecked => Variant.Of(this).Checked;
    public VariantBuilder Open => Variant.Of(this).Open;
    public VariantBuilder OnOpen => Variant.Of(this).Open;
    public VariantBuilder First => Variant.Of(this).First;
    public VariantBuilder OnFirst => Variant.Of(this).First;
    public VariantBuilder Last => Variant.Of(this).Last;
    public VariantBuilder OnLast => Variant.Of(this).Last;
    public VariantBuilder Odd => Variant.Of(this).Odd;
    public VariantBuilder OnOdd => Variant.Of(this).Odd;
    public VariantBuilder Even => Variant.Of(this).Even;
    public VariantBuilder OnEven => Variant.Of(this).Even;
    public VariantBuilder Before => Variant.Of(this).Before;
    public VariantBuilder OnBefore => Variant.Of(this).Before;
    public VariantBuilder After => Variant.Of(this).After;
    public VariantBuilder OnAfter => Variant.Of(this).After;
    public VariantBuilder Placeholder => Variant.Of(this).Placeholder;
    public VariantBuilder OnPlaceholder => Variant.Of(this).Placeholder;
    public VariantBuilder Selection => Variant.Of(this).Selection;
    public VariantBuilder OnSelection => Variant.Of(this).Selection;
    public VariantBuilder Marker => Variant.Of(this).Marker;
    public VariantBuilder OnMarker => Variant.Of(this).Marker;
    public VariantBuilder FirstLetter => Variant.Of(this).FirstLetter;
    public VariantBuilder OnFirstLetter => Variant.Of(this).FirstLetter;
    public VariantBuilder FirstLine => Variant.Of(this).FirstLine;
    public VariantBuilder OnFirstLine => Variant.Of(this).FirstLine;
    public VariantBuilder File => Variant.Of(this).File;
    public VariantBuilder OnFile => Variant.Of(this).File;
    public VariantBuilder Backdrop => Variant.Of(this).Backdrop;
    public VariantBuilder OnBackdrop => Variant.Of(this).Backdrop;
    public VariantBuilder GroupHover => Variant.Of(this).GroupHover;
    public VariantBuilder OnGroupHover => Variant.Of(this).GroupHover;
    public VariantBuilder GroupFocus => Variant.Of(this).GroupFocus;
    public VariantBuilder OnGroupFocus => Variant.Of(this).GroupFocus;
    public VariantBuilder PeerHover => Variant.Of(this).PeerHover;
    public VariantBuilder OnPeerHover => Variant.Of(this).PeerHover;
    public VariantBuilder PeerFocus => Variant.Of(this).PeerFocus;
    public VariantBuilder OnPeerFocus => Variant.Of(this).PeerFocus;

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
    public new TBuilder OnHover => SetPendingModifier("hover");
    public new TBuilder OnFocus => SetPendingModifier("focus");
    public new TBuilder OnFocusVisible => SetPendingModifier("focus-visible");
    public TBuilder OnFocusWithin => SetPendingModifier("focus-within");
    public new TBuilder OnActive => SetPendingModifier("active");
    public new TBuilder OnVisited => SetPendingModifier("visited");
    public TBuilder OnTarget => SetPendingModifier("target");
    public new TBuilder OnOpen => SetPendingModifier("open");
    public new TBuilder OnDisabled => SetPendingModifier("disabled");
    public TBuilder OnEnabled => SetPendingModifier("enabled");
    public new TBuilder OnChecked => SetPendingModifier("checked");
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
    public new TBuilder OnDark => SetPendingModifier("dark");
    public new TBuilder OnFirst => SetPendingModifier("first");
    public new TBuilder OnLast => SetPendingModifier("last");
    public TBuilder OnOnly => SetPendingModifier("only");
    public new TBuilder OnOdd => SetPendingModifier("odd");
    public new TBuilder OnEven => SetPendingModifier("even");
    public TBuilder OnEmpty => SetPendingModifier("empty");
    public new TBuilder OnBefore => SetPendingModifier("before");
    public new TBuilder OnAfter => SetPendingModifier("after");
    public new TBuilder OnPlaceholder => SetPendingModifier("placeholder");
    public new TBuilder OnSelection => SetPendingModifier("selection");
    public new TBuilder OnMarker => SetPendingModifier("marker");
    public new TBuilder OnFirstLetter => SetPendingModifier("first-letter");
    public new TBuilder OnFirstLine => SetPendingModifier("first-line");
    public new TBuilder OnFile => SetPendingModifier("file");
    public new TBuilder OnBackdrop => SetPendingModifier("backdrop");
    public new TBuilder OnGroupHover => SetPendingModifier("group-hover");
    public new TBuilder OnGroupFocus => SetPendingModifier("group-focus");
    public TBuilder OnGroupFocusVisible => SetPendingModifier("group-focus-visible");
    public TBuilder OnGroupActive => SetPendingModifier("group-active");
    public TBuilder OnGroupVisited => SetPendingModifier("group-visited");
    public TBuilder OnGroupDisabled => SetPendingModifier("group-disabled");
    public TBuilder OnGroupChecked => SetPendingModifier("group-checked");
    public TBuilder OnGroupOpen => SetPendingModifier("group-open");
    public new TBuilder OnPeerHover => SetPendingModifier("peer-hover");
    public new TBuilder OnPeerFocus => SetPendingModifier("peer-focus");
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
            string[] existingModifiers = _pendingModifierChain.Split(':');
            var insertIndex = 0;

            while (insertIndex < existingModifiers.Length && IsBreakpointModifier(existingModifiers[insertIndex]))
            {
                insertIndex++;
            }

            if (insertIndex == 0)
                _pendingModifierChain = $"{modifier}:{_pendingModifierChain}";
            else if (insertIndex == existingModifiers.Length)
                _pendingModifierChain = $"{_pendingModifierChain}:{modifier}";
            else
                _pendingModifierChain = $"{string.Join(":", existingModifiers[..insertIndex])}:{modifier}:{string.Join(":", existingModifiers[insertIndex..])}";
        }
        else
        {
            _pendingModifierChain = $"{_pendingModifierChain}:{modifier}";
        }

        return (TBuilder)this;
    }

    private static bool IsBreakpointModifier(string modifier)
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
}
