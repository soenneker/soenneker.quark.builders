using System.Collections.Generic;

namespace Soenneker.Quark;

/// <inheritdoc cref="ICssBuilder"/>
public sealed class VariantBuilder : ICssBuilder
{
    private readonly ICssBuilder _builder;
    private readonly List<string> _modifiers = new(4);
    internal VariantBuilder(ICssBuilder builder)
    {
        _builder = builder;
    }

    /// <summary>
    /// Gets or sets hover.
    /// </summary>
    public VariantBuilder Hover => Chain("hover");
    /// <summary>
    /// Gets or sets on hover.
    /// </summary>
    public VariantBuilder OnHover => Chain("hover");
    /// <summary>
    /// Gets or sets focus.
    /// </summary>
    public VariantBuilder Focus => Chain("focus");
    /// <summary>
    /// Gets or sets on focus.
    /// </summary>
    public VariantBuilder OnFocus => Chain("focus");
    /// <summary>
    /// Gets or sets focus visible.
    /// </summary>
    public VariantBuilder FocusVisible => Chain("focus-visible");
    /// <summary>
    /// Gets or sets on focus visible.
    /// </summary>
    public VariantBuilder OnFocusVisible => Chain("focus-visible");
    /// <summary>
    /// Gets or sets active.
    /// </summary>
    public VariantBuilder Active => Chain("active");
    /// <summary>
    /// Gets or sets on active.
    /// </summary>
    public VariantBuilder OnActive => Chain("active");
    /// <summary>
    /// Gets or sets disabled.
    /// </summary>
    public VariantBuilder Disabled => Chain("disabled");
    /// <summary>
    /// Gets or sets on disabled.
    /// </summary>
    public VariantBuilder OnDisabled => Chain("disabled");
    /// <summary>
    /// Gets or sets dark.
    /// </summary>
    public VariantBuilder Dark => Chain("dark");
    /// <summary>
    /// Gets or sets on dark.
    /// </summary>
    public VariantBuilder OnDark => Chain("dark");
    /// <summary>
    /// Gets or sets visited.
    /// </summary>
    public VariantBuilder Visited => Chain("visited");
    /// <summary>
    /// Gets or sets on visited.
    /// </summary>
    public VariantBuilder OnVisited => Chain("visited");
    /// <summary>
    /// Gets or sets checked.
    /// </summary>
    public VariantBuilder Checked => Chain("checked");
    /// <summary>
    /// Gets or sets on checked.
    /// </summary>
    public VariantBuilder OnChecked => Chain("checked");
    /// <summary>
    /// Gets or sets open.
    /// </summary>
    public VariantBuilder Open => Chain("open");
    /// <summary>
    /// Gets or sets on open.
    /// </summary>
    public VariantBuilder OnOpen => Chain("open");
    /// <summary>
    /// Gets or sets first.
    /// </summary>
    public VariantBuilder First => Chain("first");
    /// <summary>
    /// Gets or sets on first.
    /// </summary>
    public VariantBuilder OnFirst => Chain("first");
    /// <summary>
    /// Gets or sets last.
    /// </summary>
    public VariantBuilder Last => Chain("last");
    /// <summary>
    /// Gets or sets on last.
    /// </summary>
    public VariantBuilder OnLast => Chain("last");
    /// <summary>
    /// Gets or sets odd.
    /// </summary>
    public VariantBuilder Odd => Chain("odd");
    /// <summary>
    /// Gets or sets on odd.
    /// </summary>
    public VariantBuilder OnOdd => Chain("odd");
    /// <summary>
    /// Gets or sets even.
    /// </summary>
    public VariantBuilder Even => Chain("even");
    /// <summary>
    /// Gets or sets on even.
    /// </summary>
    public VariantBuilder OnEven => Chain("even");
    /// <summary>
    /// Gets or sets before.
    /// </summary>
    public VariantBuilder Before => Chain("before");
    /// <summary>
    /// Gets or sets on before.
    /// </summary>
    public VariantBuilder OnBefore => Chain("before");
    /// <summary>
    /// Gets or sets after.
    /// </summary>
    public VariantBuilder After => Chain("after");
    /// <summary>
    /// Gets or sets on after.
    /// </summary>
    public VariantBuilder OnAfter => Chain("after");
    /// <summary>
    /// Gets or sets on base.
    /// </summary>
    public VariantBuilder OnBase => ChainBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Gets or sets on sm.
    /// </summary>
    public VariantBuilder OnSm => ChainBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Gets or sets on md.
    /// </summary>
    public VariantBuilder OnMd => ChainBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Gets or sets on lg.
    /// </summary>
    public VariantBuilder OnLg => ChainBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Gets or sets on xl.
    /// </summary>
    public VariantBuilder OnXl => ChainBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Gets or sets on2xl.
    /// </summary>
    public VariantBuilder On2xl => ChainBreakpoint(BreakpointType.Xxl);
    /// <summary>
    /// Gets or sets on max sm.
    /// </summary>
    public VariantBuilder OnMaxSm => Chain("max-sm");
    /// <summary>
    /// Gets or sets on max md.
    /// </summary>
    public VariantBuilder OnMaxMd => Chain("max-md");
    /// <summary>
    /// Gets or sets on max lg.
    /// </summary>
    public VariantBuilder OnMaxLg => Chain("max-lg");
    /// <summary>
    /// Gets or sets on max xl.
    /// </summary>
    public VariantBuilder OnMaxXl => Chain("max-xl");
    /// <summary>
    /// Gets or sets on container sm.
    /// </summary>
    public VariantBuilder OnContainerSm => Chain("@sm");
    /// <summary>
    /// Gets or sets on container md.
    /// </summary>
    public VariantBuilder OnContainerMd => Chain("@md");
    /// <summary>
    /// Gets or sets on container lg.
    /// </summary>
    public VariantBuilder OnContainerLg => Chain("@lg");
    /// <summary>
    /// Gets or sets on container xl.
    /// </summary>
    public VariantBuilder OnContainerXl => Chain("@xl");
    /// <summary>
    /// Gets or sets on container2xl.
    /// </summary>
    public VariantBuilder OnContainer2xl => Chain("@2xl");
    /// <summary>
    /// Gets or sets on container max sm.
    /// </summary>
    public VariantBuilder OnContainerMaxSm => Chain("@max-sm");
    /// <summary>
    /// Gets or sets on container max md.
    /// </summary>
    public VariantBuilder OnContainerMaxMd => Chain("@max-md");
    /// <summary>
    /// Gets or sets on container.
    /// </summary>
    public VariantBuilder OnContainer => Chain("@container");
    /// <summary>
    /// Gets or sets on container normal.
    /// </summary>
    public VariantBuilder OnContainerNormal => Chain("@container-normal");
    /// <summary>
    /// Gets or sets focus within.
    /// </summary>
    public VariantBuilder FocusWithin => Chain("focus-within");
    /// <summary>
    /// Gets or sets on focus within.
    /// </summary>
    public VariantBuilder OnFocusWithin => Chain("focus-within");
    /// <summary>
    /// Gets or sets target.
    /// </summary>
    public VariantBuilder Target => Chain("target");
    /// <summary>
    /// Gets or sets on target.
    /// </summary>
    public VariantBuilder OnTarget => Chain("target");
    /// <summary>
    /// Gets or sets enabled.
    /// </summary>
    public VariantBuilder Enabled => Chain("enabled");
    /// <summary>
    /// Gets or sets on enabled.
    /// </summary>
    public VariantBuilder OnEnabled => Chain("enabled");
    /// <summary>
    /// Gets or sets indeterminate.
    /// </summary>
    public VariantBuilder Indeterminate => Chain("indeterminate");
    /// <summary>
    /// Gets or sets on indeterminate.
    /// </summary>
    public VariantBuilder OnIndeterminate => Chain("indeterminate");
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public VariantBuilder Default => Chain("default");
    /// <summary>
    /// Gets or sets on default.
    /// </summary>
    public VariantBuilder OnDefault => Chain("default");
    /// <summary>
    /// Gets or sets required.
    /// </summary>
    public VariantBuilder Required => Chain("required");
    /// <summary>
    /// Gets or sets on required.
    /// </summary>
    public VariantBuilder OnRequired => Chain("required");
    /// <summary>
    /// Gets or sets optional.
    /// </summary>
    public VariantBuilder Optional => Chain("optional");
    /// <summary>
    /// Gets or sets on optional.
    /// </summary>
    public VariantBuilder OnOptional => Chain("optional");
    /// <summary>
    /// Gets or sets valid.
    /// </summary>
    public VariantBuilder Valid => Chain("valid");
    /// <summary>
    /// Gets or sets on valid.
    /// </summary>
    public VariantBuilder OnValid => Chain("valid");
    /// <summary>
    /// Gets or sets invalid.
    /// </summary>
    public VariantBuilder Invalid => Chain("invalid");
    /// <summary>
    /// Gets or sets on invalid.
    /// </summary>
    public VariantBuilder OnInvalid => Chain("invalid");
    /// <summary>
    /// Gets or sets in range.
    /// </summary>
    public VariantBuilder InRange => Chain("in-range");
    /// <summary>
    /// Gets or sets on in range.
    /// </summary>
    public VariantBuilder OnInRange => Chain("in-range");
    /// <summary>
    /// Gets or sets out of range.
    /// </summary>
    public VariantBuilder OutOfRange => Chain("out-of-range");
    /// <summary>
    /// Gets or sets on out of range.
    /// </summary>
    public VariantBuilder OnOutOfRange => Chain("out-of-range");
    /// <summary>
    /// Gets or sets placeholder shown.
    /// </summary>
    public VariantBuilder PlaceholderShown => Chain("placeholder-shown");
    /// <summary>
    /// Gets or sets on placeholder shown.
    /// </summary>
    public VariantBuilder OnPlaceholderShown => Chain("placeholder-shown");
    /// <summary>
    /// Gets or sets read only.
    /// </summary>
    public VariantBuilder ReadOnly => Chain("read-only");
    /// <summary>
    /// Gets or sets on read only.
    /// </summary>
    public VariantBuilder OnReadOnly => Chain("read-only");
    /// <summary>
    /// Gets or sets read write.
    /// </summary>
    public VariantBuilder ReadWrite => Chain("read-write");
    /// <summary>
    /// Gets or sets on read write.
    /// </summary>
    public VariantBuilder OnReadWrite => Chain("read-write");
    /// <summary>
    /// Gets or sets autofill.
    /// </summary>
    public VariantBuilder Autofill => Chain("autofill");
    /// <summary>
    /// Gets or sets on autofill.
    /// </summary>
    public VariantBuilder OnAutofill => Chain("autofill");
    /// <summary>
    /// Gets or sets motion safe.
    /// </summary>
    public VariantBuilder MotionSafe => Chain("motion-safe");
    /// <summary>
    /// Gets or sets on motion safe.
    /// </summary>
    public VariantBuilder OnMotionSafe => Chain("motion-safe");
    /// <summary>
    /// Gets or sets motion reduce.
    /// </summary>
    public VariantBuilder MotionReduce => Chain("motion-reduce");
    /// <summary>
    /// Gets or sets on motion reduce.
    /// </summary>
    public VariantBuilder OnMotionReduce => Chain("motion-reduce");
    /// <summary>
    /// Gets or sets contrast more.
    /// </summary>
    public VariantBuilder ContrastMore => Chain("contrast-more");
    /// <summary>
    /// Gets or sets on contrast more.
    /// </summary>
    public VariantBuilder OnContrastMore => Chain("contrast-more");
    /// <summary>
    /// Gets or sets contrast less.
    /// </summary>
    public VariantBuilder ContrastLess => Chain("contrast-less");
    /// <summary>
    /// Gets or sets on contrast less.
    /// </summary>
    public VariantBuilder OnContrastLess => Chain("contrast-less");
    /// <summary>
    /// Gets or sets forced colors.
    /// </summary>
    public VariantBuilder ForcedColors => Chain("forced-colors");
    /// <summary>
    /// Gets or sets on forced colors.
    /// </summary>
    public VariantBuilder OnForcedColors => Chain("forced-colors");
    /// <summary>
    /// Gets or sets portrait.
    /// </summary>
    public VariantBuilder Portrait => Chain("portrait");
    /// <summary>
    /// Gets or sets on portrait.
    /// </summary>
    public VariantBuilder OnPortrait => Chain("portrait");
    /// <summary>
    /// Gets or sets landscape.
    /// </summary>
    public VariantBuilder Landscape => Chain("landscape");
    /// <summary>
    /// Gets or sets on landscape.
    /// </summary>
    public VariantBuilder OnLandscape => Chain("landscape");
    /// <summary>
    /// Gets or sets print.
    /// </summary>
    public VariantBuilder Print => Chain("print");
    /// <summary>
    /// Gets or sets on print.
    /// </summary>
    public VariantBuilder OnPrint => Chain("print");
    /// <summary>
    /// Gets or sets rtl.
    /// </summary>
    public VariantBuilder Rtl => Chain("rtl");
    /// <summary>
    /// Gets or sets on rtl.
    /// </summary>
    public VariantBuilder OnRtl => Chain("rtl");
    /// <summary>
    /// Gets or sets ltr.
    /// </summary>
    public VariantBuilder Ltr => Chain("ltr");
    /// <summary>
    /// Gets or sets on ltr.
    /// </summary>
    public VariantBuilder OnLtr => Chain("ltr");
    /// <summary>
    /// Gets or sets only.
    /// </summary>
    public VariantBuilder Only => Chain("only");
    /// <summary>
    /// Gets or sets on only.
    /// </summary>
    public VariantBuilder OnOnly => Chain("only");
    /// <summary>
    /// Gets or sets empty.
    /// </summary>
    public VariantBuilder Empty => Chain("empty");
    /// <summary>
    /// Gets or sets on empty.
    /// </summary>
    public VariantBuilder OnEmpty => Chain("empty");
    /// <summary>
    /// Gets or sets placeholder.
    /// </summary>
    public VariantBuilder Placeholder => Chain("placeholder");
    /// <summary>
    /// Gets or sets on placeholder.
    /// </summary>
    public VariantBuilder OnPlaceholder => Chain("placeholder");
    /// <summary>
    /// Gets or sets selection.
    /// </summary>
    public VariantBuilder Selection => Chain("selection");
    /// <summary>
    /// Gets or sets on selection.
    /// </summary>
    public VariantBuilder OnSelection => Chain("selection");
    /// <summary>
    /// Gets or sets marker.
    /// </summary>
    public VariantBuilder Marker => Chain("marker");
    /// <summary>
    /// Gets or sets on marker.
    /// </summary>
    public VariantBuilder OnMarker => Chain("marker");
    /// <summary>
    /// Gets or sets first letter.
    /// </summary>
    public VariantBuilder FirstLetter => Chain("first-letter");
    /// <summary>
    /// Gets or sets on first letter.
    /// </summary>
    public VariantBuilder OnFirstLetter => Chain("first-letter");
    /// <summary>
    /// Gets or sets first line.
    /// </summary>
    public VariantBuilder FirstLine => Chain("first-line");
    /// <summary>
    /// Gets or sets on first line.
    /// </summary>
    public VariantBuilder OnFirstLine => Chain("first-line");
    /// <summary>
    /// Gets or sets file.
    /// </summary>
    public VariantBuilder File => Chain("file");
    /// <summary>
    /// Gets or sets on file.
    /// </summary>
    public VariantBuilder OnFile => Chain("file");
    /// <summary>
    /// Gets or sets backdrop.
    /// </summary>
    public VariantBuilder Backdrop => Chain("backdrop");
    /// <summary>
    /// Gets or sets on backdrop.
    /// </summary>
    public VariantBuilder OnBackdrop => Chain("backdrop");
    /// <summary>
    /// Gets or sets group hover.
    /// </summary>
    public VariantBuilder GroupHover => Chain("group-hover");
    /// <summary>
    /// Gets or sets on group hover.
    /// </summary>
    public VariantBuilder OnGroupHover => Chain("group-hover");
    /// <summary>
    /// Gets or sets group focus.
    /// </summary>
    public VariantBuilder GroupFocus => Chain("group-focus");
    /// <summary>
    /// Gets or sets on group focus.
    /// </summary>
    public VariantBuilder OnGroupFocus => Chain("group-focus");
    /// <summary>
    /// Gets or sets group focus visible.
    /// </summary>
    public VariantBuilder GroupFocusVisible => Chain("group-focus-visible");
    /// <summary>
    /// Gets or sets on group focus visible.
    /// </summary>
    public VariantBuilder OnGroupFocusVisible => Chain("group-focus-visible");
    /// <summary>
    /// Gets or sets group active.
    /// </summary>
    public VariantBuilder GroupActive => Chain("group-active");
    /// <summary>
    /// Gets or sets on group active.
    /// </summary>
    public VariantBuilder OnGroupActive => Chain("group-active");
    /// <summary>
    /// Gets or sets group visited.
    /// </summary>
    public VariantBuilder GroupVisited => Chain("group-visited");
    /// <summary>
    /// Gets or sets on group visited.
    /// </summary>
    public VariantBuilder OnGroupVisited => Chain("group-visited");
    /// <summary>
    /// Gets or sets group disabled.
    /// </summary>
    public VariantBuilder GroupDisabled => Chain("group-disabled");
    /// <summary>
    /// Gets or sets on group disabled.
    /// </summary>
    public VariantBuilder OnGroupDisabled => Chain("group-disabled");
    /// <summary>
    /// Gets or sets group checked.
    /// </summary>
    public VariantBuilder GroupChecked => Chain("group-checked");
    /// <summary>
    /// Gets or sets on group checked.
    /// </summary>
    public VariantBuilder OnGroupChecked => Chain("group-checked");
    /// <summary>
    /// Gets or sets group open.
    /// </summary>
    public VariantBuilder GroupOpen => Chain("group-open");
    /// <summary>
    /// Gets or sets on group open.
    /// </summary>
    public VariantBuilder OnGroupOpen => Chain("group-open");
    /// <summary>
    /// Gets or sets peer hover.
    /// </summary>
    public VariantBuilder PeerHover => Chain("peer-hover");
    /// <summary>
    /// Gets or sets on peer hover.
    /// </summary>
    public VariantBuilder OnPeerHover => Chain("peer-hover");
    /// <summary>
    /// Gets or sets peer focus.
    /// </summary>
    public VariantBuilder PeerFocus => Chain("peer-focus");
    /// <summary>
    /// Gets or sets on peer focus.
    /// </summary>
    public VariantBuilder OnPeerFocus => Chain("peer-focus");
    /// <summary>
    /// Gets or sets peer focus visible.
    /// </summary>
    public VariantBuilder PeerFocusVisible => Chain("peer-focus-visible");
    /// <summary>
    /// Gets or sets on peer focus visible.
    /// </summary>
    public VariantBuilder OnPeerFocusVisible => Chain("peer-focus-visible");
    /// <summary>
    /// Gets or sets peer active.
    /// </summary>
    public VariantBuilder PeerActive => Chain("peer-active");
    /// <summary>
    /// Gets or sets on peer active.
    /// </summary>
    public VariantBuilder OnPeerActive => Chain("peer-active");
    /// <summary>
    /// Gets or sets peer disabled.
    /// </summary>
    public VariantBuilder PeerDisabled => Chain("peer-disabled");
    /// <summary>
    /// Gets or sets on peer disabled.
    /// </summary>
    public VariantBuilder OnPeerDisabled => Chain("peer-disabled");
    /// <summary>
    /// Gets or sets peer checked.
    /// </summary>
    public VariantBuilder PeerChecked => Chain("peer-checked");
    /// <summary>
    /// Gets or sets on peer checked.
    /// </summary>
    public VariantBuilder OnPeerChecked => Chain("peer-checked");
    /// <summary>
    /// Gets or sets peer invalid.
    /// </summary>
    public VariantBuilder PeerInvalid => Chain("peer-invalid");
    /// <summary>
    /// Gets or sets on peer invalid.
    /// </summary>
    public VariantBuilder OnPeerInvalid => Chain("peer-invalid");
    /// <summary>
    /// Gets or sets peer required.
    /// </summary>
    public VariantBuilder PeerRequired => Chain("peer-required");
    /// <summary>
    /// Gets or sets on peer required.
    /// </summary>
    public VariantBuilder OnPeerRequired => Chain("peer-required");
    /// <summary>
    /// Gets or sets peer placeholder shown.
    /// </summary>
    public VariantBuilder PeerPlaceholderShown => Chain("peer-placeholder-shown");
    /// <summary>
    /// Gets or sets on peer placeholder shown.
    /// </summary>
    public VariantBuilder OnPeerPlaceholderShown => Chain("peer-placeholder-shown");
    /// <summary>
    /// Gets or sets peer open.
    /// </summary>
    public VariantBuilder PeerOpen => Chain("peer-open");
    /// <summary>
    /// Gets or sets on peer open.
    /// </summary>
    public VariantBuilder OnPeerOpen => Chain("peer-open");
    /// <summary>
    /// Gets or sets aria checked.
    /// </summary>
    public VariantBuilder AriaChecked => Chain("aria-checked");
    /// <summary>
    /// Gets or sets on aria checked.
    /// </summary>
    public VariantBuilder OnAriaChecked => Chain("aria-checked");
    /// <summary>
    /// Gets or sets aria disabled.
    /// </summary>
    public VariantBuilder AriaDisabled => Chain("aria-disabled");
    /// <summary>
    /// Gets or sets on aria disabled.
    /// </summary>
    public VariantBuilder OnAriaDisabled => Chain("aria-disabled");
    /// <summary>
    /// Gets or sets aria expanded.
    /// </summary>
    public VariantBuilder AriaExpanded => Chain("aria-expanded");
    /// <summary>
    /// Gets or sets on aria expanded.
    /// </summary>
    public VariantBuilder OnAriaExpanded => Chain("aria-expanded");
    /// <summary>
    /// Gets or sets aria hidden.
    /// </summary>
    public VariantBuilder AriaHidden => Chain("aria-hidden");
    /// <summary>
    /// Gets or sets on aria hidden.
    /// </summary>
    public VariantBuilder OnAriaHidden => Chain("aria-hidden");
    /// <summary>
    /// Gets or sets aria pressed.
    /// </summary>
    public VariantBuilder AriaPressed => Chain("aria-pressed");
    /// <summary>
    /// Gets or sets on aria pressed.
    /// </summary>
    public VariantBuilder OnAriaPressed => Chain("aria-pressed");
    /// <summary>
    /// Gets or sets aria readonly.
    /// </summary>
    public VariantBuilder AriaReadonly => Chain("aria-readonly");
    /// <summary>
    /// Gets or sets on aria readonly.
    /// </summary>
    public VariantBuilder OnAriaReadonly => Chain("aria-readonly");
    /// <summary>
    /// Gets or sets aria required.
    /// </summary>
    public VariantBuilder AriaRequired => Chain("aria-required");
    /// <summary>
    /// Gets or sets on aria required.
    /// </summary>
    public VariantBuilder OnAriaRequired => Chain("aria-required");
    /// <summary>
    /// Gets or sets aria selected.
    /// </summary>
    public VariantBuilder AriaSelected => Chain("aria-selected");
    /// <summary>
    /// Gets or sets on aria selected.
    /// </summary>
    public VariantBuilder OnAriaSelected => Chain("aria-selected");

    /// <summary>
    /// Executes the data operation.
    /// </summary>
    /// <param name="attribute">The attribute.</param>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Data(string attribute, string value) => Chain($"data-[{attribute}={value}]");
    /// <summary>
    /// Executes the data state operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder DataState(string value) => Chain($"data-[state={value}]");
    /// <summary>
    /// Executes the aria operation.
    /// </summary>
    /// <param name="attribute">The attribute.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Aria(string attribute) => Chain($"aria-{attribute}");
    /// <summary>
    /// Executes the aria operation.
    /// </summary>
    /// <param name="attribute">The attribute.</param>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Aria(string attribute, string value) => Chain($"aria-[{attribute}={value}]");
    /// <summary>
    /// Executes the group operation.
    /// </summary>
    /// <param name="modifier">The modifier.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Group(string modifier) => Chain($"group-{modifier}");
    /// <summary>
    /// Executes the group operation.
    /// </summary>
    /// <param name="modifier">The modifier.</param>
    /// <param name="name">The name.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Group(string modifier, string name) => Chain($"group-{modifier}/{name}");
    /// <summary>
    /// Executes the peer operation.
    /// </summary>
    /// <param name="modifier">The modifier.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Peer(string modifier) => Chain($"peer-{modifier}");
    /// <summary>
    /// Executes the peer operation.
    /// </summary>
    /// <param name="modifier">The modifier.</param>
    /// <param name="name">The name.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Peer(string modifier, string name) => Chain($"peer-{modifier}/{name}");
    /// <summary>
    /// Executes the has operation.
    /// </summary>
    /// <param name="selector">The selector.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Has(string selector) => Chain($"has-[{selector}]");
    /// <summary>
    /// Executes the not operation.
    /// </summary>
    /// <param name="selector">The selector.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Not(string selector) => Chain($"not-[{selector}]");
    /// <summary>
    /// Executes the supports operation.
    /// </summary>
    /// <param name="condition">The condition.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Supports(string condition) => Chain($"supports-[{condition}]");
    /// <summary>
    /// Executes the modifier operation.
    /// </summary>
    /// <param name="modifier">The modifier.</param>
    /// <returns>The result of the operation.</returns>
    public VariantBuilder Modifier(string modifier) => Chain(modifier);
    /// <summary>
    /// Executes the modifiers operation.
    /// </summary>
    /// <param name="modifiers">The modifiers.</param>
    /// <returns>The result of the operation.</returns>
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

    /// <summary>
    /// Executes the custom operation.
    /// </summary>
    /// <param name="modifier">The modifier.</param>
    /// <returns>The result of the operation.</returns>
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
            if (IsResponsiveModifier(_modifiers[i]))
                _modifiers.RemoveAt(i);
        }

        if (token.Length > 0)
            _modifiers.Insert(0, token);

        return this;
    }

    public string ToClass() => BreakpointUtil.ApplyTailwindModifiers(_builder.ToClass(), _modifiers);

    public string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();

    private static bool IsResponsiveModifier(string modifier)
    {
        return modifier is "sm" or "md" or "lg" or "xl" or "2xl";
    }
}
