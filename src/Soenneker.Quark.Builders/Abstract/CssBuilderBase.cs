using System;

namespace Soenneker.Quark;

public abstract class CssBuilderBase : ICssBuilder
{
    /// <summary>
    /// Adds a Tailwind data-attribute variant for the specified attribute and value.
    /// </summary>
    /// <param name="attribute">HTML attribute used by the variant.</param>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Data(string attribute, string value) => Variant.Of(this).Data(attribute, value);
    /// <summary>
    /// Adds a Tailwind data-state variant for the specified state value.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder DataState(string value) => Variant.Of(this).DataState(value);
    /// <summary>
    /// Adds a Tailwind ARIA variant for the specified attribute and value.
    /// </summary>
    /// <param name="attribute">HTML attribute used by the variant.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Aria(string attribute) => Variant.Of(this).Aria(attribute);
    /// <summary>
    /// Adds a Tailwind ARIA variant for the specified attribute and value.
    /// </summary>
    /// <param name="attribute">HTML attribute used by the variant.</param>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Aria(string attribute, string value) => Variant.Of(this).Aria(attribute, value);
    /// <summary>
    /// Adds a Tailwind group variant, optionally scoped to a named group.
    /// </summary>
    /// <param name="modifier">Modifier to append to the pending utility.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Group(string modifier) => Variant.Of(this).Group(modifier);
    /// <summary>
    /// Adds a Tailwind group variant, optionally scoped to a named group.
    /// </summary>
    /// <param name="modifier">Modifier to append to the pending utility.</param>
    /// <param name="name">Optional name used to scope the generated variant.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Group(string modifier, string name) => Variant.Of(this).Group(modifier, name);
    /// <summary>
    /// Adds a Tailwind peer variant, optionally scoped to a named peer.
    /// </summary>
    /// <param name="modifier">Modifier to append to the pending utility.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Peer(string modifier) => Variant.Of(this).Peer(modifier);
    /// <summary>
    /// Adds a Tailwind peer variant, optionally scoped to a named peer.
    /// </summary>
    /// <param name="modifier">Modifier to append to the pending utility.</param>
    /// <param name="name">Optional name used to scope the generated variant.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Peer(string modifier, string name) => Variant.Of(this).Peer(modifier, name);
    /// <summary>
    /// Adds a Tailwind variant that applies when the element contains the specified selector.
    /// </summary>
    /// <param name="selector">CSS selector used by the variant.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Has(string selector) => Variant.Of(this).Has(selector);
    /// <summary>
    /// Adds a Tailwind variant that excludes the specified selector.
    /// </summary>
    /// <param name="selector">CSS selector used by the variant.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Not(string selector) => Variant.Of(this).Not(selector);
    /// <summary>
    /// Adds a Tailwind variant guarded by the specified CSS feature query.
    /// </summary>
    /// <param name="condition">CSS feature condition used by the variant.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Supports(string condition) => Variant.Of(this).Supports(condition);
    /// <summary>
    /// Adds the specified modifier to the pending utility.
    /// </summary>
    /// <param name="modifier">Modifier to append to the pending utility.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Modifier(string modifier) => Variant.Of(this).Modifier(modifier);
    /// <summary>
    /// Adds each specified modifier to the pending utility.
    /// </summary>
    /// <param name="modifiers">Modifiers to append to the pending utility, in order.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Modifiers(params string[] modifiers) => Variant.Of(this).Modifiers(modifiers);
    /// <summary>
    /// Adds the supplied custom utility token without interpreting its value.
    /// </summary>
    /// <param name="modifier">Modifier to append to the pending utility.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public VariantBuilder Custom(string modifier) => Variant.Of(this).Custom(modifier);

    public abstract string ToClass();

    public virtual string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}

/// <summary>
/// Represents the css builder base.
/// </summary>
/// <typeparam name="TBuilder">The TBuilder type.</typeparam>
public abstract class CssBuilderBase<TBuilder> : CssBuilderBase where TBuilder : CssBuilderBase<TBuilder>
{
    private string? _pendingModifierChain;

    /// <summary>
    /// Adds the specified modifier to the pending utility.
    /// </summary>
    /// <param name="modifier">Modifier to append to the pending utility.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public new TBuilder Modifier(string modifier) => SetPendingModifier(modifier);
    /// <summary>
    /// Adds the supplied custom utility token without interpreting its value.
    /// </summary>
    /// <param name="modifier">Modifier to append to the pending utility.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public new TBuilder Custom(string modifier) => SetPendingModifier(modifier);

    /// <summary>
    /// Adds each specified modifier to the pending utility.
    /// </summary>
    /// <param name="modifiers">Modifiers to append to the pending utility, in order.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
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

    /// <summary>
    /// Gets or sets on sm.
    /// </summary>
    public TBuilder OnSm => SetPendingModifier("sm");
    /// <summary>
    /// Gets or sets on base.
    /// </summary>
    public TBuilder OnBase => (TBuilder)this;
    /// <summary>
    /// Gets or sets on md.
    /// </summary>
    public TBuilder OnMd => SetPendingModifier("md");
    /// <summary>
    /// Gets or sets on lg.
    /// </summary>
    public TBuilder OnLg => SetPendingModifier("lg");
    /// <summary>
    /// Gets or sets on xl.
    /// </summary>
    public TBuilder OnXl => SetPendingModifier("xl");
    /// <summary>
    /// Gets or sets on2xl.
    /// </summary>
    public TBuilder On2xl => SetPendingModifier("2xl");
    /// <summary>
    /// Gets or sets on max sm.
    /// </summary>
    public TBuilder OnMaxSm => SetPendingModifier("max-sm");
    /// <summary>
    /// Gets or sets on max md.
    /// </summary>
    public TBuilder OnMaxMd => SetPendingModifier("max-md");
    /// <summary>
    /// Gets or sets on max lg.
    /// </summary>
    public TBuilder OnMaxLg => SetPendingModifier("max-lg");
    /// <summary>
    /// Gets or sets on max xl.
    /// </summary>
    public TBuilder OnMaxXl => SetPendingModifier("max-xl");
    /// <summary>
    /// Gets or sets on container sm.
    /// </summary>
    public TBuilder OnContainerSm => SetPendingModifier("@sm");
    /// <summary>
    /// Gets or sets on container md.
    /// </summary>
    public TBuilder OnContainerMd => SetPendingModifier("@md");
    /// <summary>
    /// Gets or sets on container lg.
    /// </summary>
    public TBuilder OnContainerLg => SetPendingModifier("@lg");
    /// <summary>
    /// Gets or sets on container xl.
    /// </summary>
    public TBuilder OnContainerXl => SetPendingModifier("@xl");
    /// <summary>
    /// Gets or sets on container2xl.
    /// </summary>
    public TBuilder OnContainer2xl => SetPendingModifier("@2xl");
    /// <summary>
    /// Gets or sets on container max sm.
    /// </summary>
    public TBuilder OnContainerMaxSm => SetPendingModifier("@max-sm");
    /// <summary>
    /// Gets or sets on container max md.
    /// </summary>
    public TBuilder OnContainerMaxMd => SetPendingModifier("@max-md");
    /// <summary>
    /// Gets or sets on container.
    /// </summary>
    public TBuilder OnContainer => SetPendingModifier("@container");
    /// <summary>
    /// Gets or sets on container normal.
    /// </summary>
    public TBuilder OnContainerNormal => SetPendingModifier("@container-normal");
    /// <summary>
    /// Gets or sets on hover.
    /// </summary>
    public TBuilder OnHover => SetPendingModifier("hover");
    /// <summary>
    /// Gets or sets on focus.
    /// </summary>
    public TBuilder OnFocus => SetPendingModifier("focus");
    /// <summary>
    /// Gets or sets on focus visible.
    /// </summary>
    public TBuilder OnFocusVisible => SetPendingModifier("focus-visible");
    /// <summary>
    /// Gets or sets on focus within.
    /// </summary>
    public TBuilder OnFocusWithin => SetPendingModifier("focus-within");
    /// <summary>
    /// Gets or sets on active.
    /// </summary>
    public TBuilder OnActive => SetPendingModifier("active");
    /// <summary>
    /// Gets or sets on visited.
    /// </summary>
    public TBuilder OnVisited => SetPendingModifier("visited");
    /// <summary>
    /// Gets or sets on target.
    /// </summary>
    public TBuilder OnTarget => SetPendingModifier("target");
    /// <summary>
    /// Gets or sets on open.
    /// </summary>
    public TBuilder OnOpen => SetPendingModifier("open");
    /// <summary>
    /// Gets or sets on disabled.
    /// </summary>
    public TBuilder OnDisabled => SetPendingModifier("disabled");
    /// <summary>
    /// Gets or sets on enabled.
    /// </summary>
    public TBuilder OnEnabled => SetPendingModifier("enabled");
    /// <summary>
    /// Gets or sets on checked.
    /// </summary>
    public TBuilder OnChecked => SetPendingModifier("checked");
    /// <summary>
    /// Gets or sets on indeterminate.
    /// </summary>
    public TBuilder OnIndeterminate => SetPendingModifier("indeterminate");
    /// <summary>
    /// Gets or sets on default.
    /// </summary>
    public TBuilder OnDefault => SetPendingModifier("default");
    /// <summary>
    /// Gets or sets on required.
    /// </summary>
    public TBuilder OnRequired => SetPendingModifier("required");
    /// <summary>
    /// Gets or sets on optional.
    /// </summary>
    public TBuilder OnOptional => SetPendingModifier("optional");
    /// <summary>
    /// Gets or sets on valid.
    /// </summary>
    public TBuilder OnValid => SetPendingModifier("valid");
    /// <summary>
    /// Gets or sets on invalid.
    /// </summary>
    public TBuilder OnInvalid => SetPendingModifier("invalid");
    /// <summary>
    /// Gets or sets on in range.
    /// </summary>
    public TBuilder OnInRange => SetPendingModifier("in-range");
    /// <summary>
    /// Gets or sets on out of range.
    /// </summary>
    public TBuilder OnOutOfRange => SetPendingModifier("out-of-range");
    /// <summary>
    /// Gets or sets on placeholder shown.
    /// </summary>
    public TBuilder OnPlaceholderShown => SetPendingModifier("placeholder-shown");
    /// <summary>
    /// Gets or sets on read only.
    /// </summary>
    public TBuilder OnReadOnly => SetPendingModifier("read-only");
    /// <summary>
    /// Gets or sets on read write.
    /// </summary>
    public TBuilder OnReadWrite => SetPendingModifier("read-write");
    /// <summary>
    /// Gets or sets on autofill.
    /// </summary>
    public TBuilder OnAutofill => SetPendingModifier("autofill");
    /// <summary>
    /// Gets or sets on motion safe.
    /// </summary>
    public TBuilder OnMotionSafe => SetPendingModifier("motion-safe");
    /// <summary>
    /// Gets or sets on motion reduce.
    /// </summary>
    public TBuilder OnMotionReduce => SetPendingModifier("motion-reduce");
    /// <summary>
    /// Gets or sets on contrast more.
    /// </summary>
    public TBuilder OnContrastMore => SetPendingModifier("contrast-more");
    /// <summary>
    /// Gets or sets on contrast less.
    /// </summary>
    public TBuilder OnContrastLess => SetPendingModifier("contrast-less");
    /// <summary>
    /// Gets or sets on forced colors.
    /// </summary>
    public TBuilder OnForcedColors => SetPendingModifier("forced-colors");
    /// <summary>
    /// Gets or sets on portrait.
    /// </summary>
    public TBuilder OnPortrait => SetPendingModifier("portrait");
    /// <summary>
    /// Gets or sets on landscape.
    /// </summary>
    public TBuilder OnLandscape => SetPendingModifier("landscape");
    /// <summary>
    /// Gets or sets on print.
    /// </summary>
    public TBuilder OnPrint => SetPendingModifier("print");
    /// <summary>
    /// Gets or sets on rtl.
    /// </summary>
    public TBuilder OnRtl => SetPendingModifier("rtl");
    /// <summary>
    /// Gets or sets on ltr.
    /// </summary>
    public TBuilder OnLtr => SetPendingModifier("ltr");
    /// <summary>
    /// Gets or sets on dark.
    /// </summary>
    public TBuilder OnDark => SetPendingModifier("dark");
    /// <summary>
    /// Gets or sets on first.
    /// </summary>
    public TBuilder OnFirst => SetPendingModifier("first");
    /// <summary>
    /// Gets or sets on last.
    /// </summary>
    public TBuilder OnLast => SetPendingModifier("last");
    /// <summary>
    /// Gets or sets on only.
    /// </summary>
    public TBuilder OnOnly => SetPendingModifier("only");
    /// <summary>
    /// Gets or sets on odd.
    /// </summary>
    public TBuilder OnOdd => SetPendingModifier("odd");
    /// <summary>
    /// Gets or sets on even.
    /// </summary>
    public TBuilder OnEven => SetPendingModifier("even");
    /// <summary>
    /// Gets or sets on empty.
    /// </summary>
    public TBuilder OnEmpty => SetPendingModifier("empty");
    /// <summary>
    /// Gets or sets on before.
    /// </summary>
    public TBuilder OnBefore => SetPendingModifier("before");
    /// <summary>
    /// Gets or sets on after.
    /// </summary>
    public TBuilder OnAfter => SetPendingModifier("after");
    /// <summary>
    /// Gets or sets on placeholder.
    /// </summary>
    public TBuilder OnPlaceholder => SetPendingModifier("placeholder");
    /// <summary>
    /// Gets or sets on selection.
    /// </summary>
    public TBuilder OnSelection => SetPendingModifier("selection");
    /// <summary>
    /// Gets or sets on marker.
    /// </summary>
    public TBuilder OnMarker => SetPendingModifier("marker");
    /// <summary>
    /// Gets or sets on first letter.
    /// </summary>
    public TBuilder OnFirstLetter => SetPendingModifier("first-letter");
    /// <summary>
    /// Gets or sets on first line.
    /// </summary>
    public TBuilder OnFirstLine => SetPendingModifier("first-line");
    /// <summary>
    /// Gets or sets on file.
    /// </summary>
    public TBuilder OnFile => SetPendingModifier("file");
    /// <summary>
    /// Gets or sets on backdrop.
    /// </summary>
    public TBuilder OnBackdrop => SetPendingModifier("backdrop");
    /// <summary>
    /// Gets or sets on group hover.
    /// </summary>
    public TBuilder OnGroupHover => SetPendingModifier("group-hover");
    /// <summary>
    /// Gets or sets on group focus.
    /// </summary>
    public TBuilder OnGroupFocus => SetPendingModifier("group-focus");
    /// <summary>
    /// Gets or sets on group focus visible.
    /// </summary>
    public TBuilder OnGroupFocusVisible => SetPendingModifier("group-focus-visible");
    /// <summary>
    /// Gets or sets on group active.
    /// </summary>
    public TBuilder OnGroupActive => SetPendingModifier("group-active");
    /// <summary>
    /// Gets or sets on group visited.
    /// </summary>
    public TBuilder OnGroupVisited => SetPendingModifier("group-visited");
    /// <summary>
    /// Gets or sets on group disabled.
    /// </summary>
    public TBuilder OnGroupDisabled => SetPendingModifier("group-disabled");
    /// <summary>
    /// Gets or sets on group checked.
    /// </summary>
    public TBuilder OnGroupChecked => SetPendingModifier("group-checked");
    /// <summary>
    /// Gets or sets on group open.
    /// </summary>
    public TBuilder OnGroupOpen => SetPendingModifier("group-open");
    /// <summary>
    /// Gets or sets on peer hover.
    /// </summary>
    public TBuilder OnPeerHover => SetPendingModifier("peer-hover");
    /// <summary>
    /// Gets or sets on peer focus.
    /// </summary>
    public TBuilder OnPeerFocus => SetPendingModifier("peer-focus");
    /// <summary>
    /// Gets or sets on peer focus visible.
    /// </summary>
    public TBuilder OnPeerFocusVisible => SetPendingModifier("peer-focus-visible");
    /// <summary>
    /// Gets or sets on peer active.
    /// </summary>
    public TBuilder OnPeerActive => SetPendingModifier("peer-active");
    /// <summary>
    /// Gets or sets on peer disabled.
    /// </summary>
    public TBuilder OnPeerDisabled => SetPendingModifier("peer-disabled");
    /// <summary>
    /// Gets or sets on peer checked.
    /// </summary>
    public TBuilder OnPeerChecked => SetPendingModifier("peer-checked");
    /// <summary>
    /// Gets or sets on peer invalid.
    /// </summary>
    public TBuilder OnPeerInvalid => SetPendingModifier("peer-invalid");
    /// <summary>
    /// Gets or sets on peer required.
    /// </summary>
    public TBuilder OnPeerRequired => SetPendingModifier("peer-required");
    /// <summary>
    /// Gets or sets on peer placeholder shown.
    /// </summary>
    public TBuilder OnPeerPlaceholderShown => SetPendingModifier("peer-placeholder-shown");
    /// <summary>
    /// Gets or sets on peer open.
    /// </summary>
    public TBuilder OnPeerOpen => SetPendingModifier("peer-open");
    /// <summary>
    /// Gets or sets on aria checked.
    /// </summary>
    public TBuilder OnAriaChecked => SetPendingModifier("aria-checked");
    /// <summary>
    /// Gets or sets on aria disabled.
    /// </summary>
    public TBuilder OnAriaDisabled => SetPendingModifier("aria-disabled");
    /// <summary>
    /// Gets or sets on aria expanded.
    /// </summary>
    public TBuilder OnAriaExpanded => SetPendingModifier("aria-expanded");
    /// <summary>
    /// Gets or sets on aria hidden.
    /// </summary>
    public TBuilder OnAriaHidden => SetPendingModifier("aria-hidden");
    /// <summary>
    /// Gets or sets on aria pressed.
    /// </summary>
    public TBuilder OnAriaPressed => SetPendingModifier("aria-pressed");
    /// <summary>
    /// Gets or sets on aria readonly.
    /// </summary>
    public TBuilder OnAriaReadonly => SetPendingModifier("aria-readonly");
    /// <summary>
    /// Gets or sets on aria required.
    /// </summary>
    public TBuilder OnAriaRequired => SetPendingModifier("aria-required");
    /// <summary>
    /// Gets or sets on aria selected.
    /// </summary>
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
