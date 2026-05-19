using Soenneker.Tests.HostedUnit;
using AwesomeAssertions;

namespace Soenneker.Quark.Builders.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class QuarkBuildersTests : HostedUnitTest
{
    public QuarkBuildersTests(Host host) : base(host)
    {
    }

    [Test]
    public void ButtonSizeBuilder_builds_responsive_size_classes()
    {
        string result = ButtonSize.Default.OnMd.IconSm.ToClass();

        result.Should().Be("h-8 gap-1.5 rounded-lg px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2 md:size-7 md:rounded-[min(var(--radius-md),12px)] md:in-data-[slot=button-group]:rounded-lg");
    }

    [Test]
    public void ButtonSizeBuilder_builds_multiple_responsive_size_classes()
    {
        string result = ButtonSize.Xs.OnLg.Sm.On2xl.Lg.ToClass();

        result.Should().Contain("h-6");
        result.Should().Contain("text-xs");
        result.Should().Contain("lg:h-7");
        result.Should().Contain("lg:text-[0.8rem]");
        result.Should().Contain("2xl:h-9");
        result.Should().Contain("2xl:px-2.5");
    }

    [Test]
    public void ButtonSizeEnum_exposes_token_and_class_values()
    {
        ButtonSizeEnum.Default.Value.Should().Be("default");
        ButtonSizeEnum.Default.Class.Should().Contain("h-8");
        ButtonSizeEnum.Xs.Value.Should().Be("xs");
        ButtonSizeEnum.Xs.Class.Should().Contain("text-xs");
        ButtonSizeEnum.Sm.Value.Should().Be("sm");
        ButtonSizeEnum.Sm.Class.Should().Contain("text-[0.8rem]");
        ButtonSizeEnum.Lg.Value.Should().Be("lg");
        ButtonSizeEnum.Lg.Class.Should().Contain("h-9");
        ButtonSizeEnum.Icon.Value.Should().Be("icon");
        ButtonSizeEnum.Icon.Class.Should().Be("size-8 rounded-lg");
        ButtonSizeEnum.IconXs.Value.Should().Be("icon-xs");
        ButtonSizeEnum.IconXs.Class.Should().Contain("size-6");
        ButtonSizeEnum.IconSm.Value.Should().Be("icon-sm");
        ButtonSizeEnum.IconSm.Class.Should().Contain("size-7");
        ButtonSizeEnum.IconLg.Value.Should().Be("icon-lg");
        ButtonSizeEnum.IconLg.Class.Should().Be("size-9 rounded-lg");
    }

    [Test]
    public void ButtonSizeBuilder_css_value_to_string_uses_enum_class_values()
    {
        CssValue<ButtonSizeBuilder> defaultSize = ButtonSize.Default;
        CssValue<ButtonSizeBuilder> xs = ButtonSize.Xs;
        CssValue<ButtonSizeBuilder> sm = ButtonSize.Sm;
        CssValue<ButtonSizeBuilder> lg = ButtonSize.Lg;
        CssValue<ButtonSizeBuilder> icon = ButtonSize.Icon;
        CssValue<ButtonSizeBuilder> iconXs = ButtonSize.IconXs;
        CssValue<ButtonSizeBuilder> iconSm = ButtonSize.IconSm;
        CssValue<ButtonSizeBuilder> iconLg = ButtonSize.IconLg;

        defaultSize.ToString().Should().Be(ButtonSizeEnum.Default.Class);
        xs.ToString().Should().Be(ButtonSizeEnum.Xs.Class);
        sm.ToString().Should().Be(ButtonSizeEnum.Sm.Class);
        lg.ToString().Should().Be(ButtonSizeEnum.Lg.Class);
        icon.ToString().Should().Be(ButtonSizeEnum.Icon.Class);
        iconXs.ToString().Should().Be(ButtonSizeEnum.IconXs.Class);
        iconSm.ToString().Should().Be(ButtonSizeEnum.IconSm.Class);
        iconLg.ToString().Should().Be(ButtonSizeEnum.IconLg.Class);
    }

    [Test]
    public void ButtonVariant_exposes_token_and_class_values()
    {
        ButtonVariant.Default.Value.Should().Be("default");
        ButtonVariant.Default.Class.Should().Be("border-transparent bg-primary text-primary-foreground [a]:hover:bg-primary/80");
        ButtonVariant.Destructive.Value.Should().Be("destructive");
        ButtonVariant.Destructive.Class.Should().Contain("bg-destructive/10");
        ButtonVariant.Outline.Value.Should().Be("outline");
        ButtonVariant.Outline.Class.Should().Contain("border-border");
        ButtonVariant.Secondary.Value.Should().Be("secondary");
        ButtonVariant.Secondary.Class.Should().Contain("bg-secondary");
        ButtonVariant.Ghost.Value.Should().Be("ghost");
        ButtonVariant.Ghost.Class.Should().Contain("hover:bg-muted");
        ButtonVariant.Link.Value.Should().Be("link");
        ButtonVariant.Link.Class.Should().Contain("hover:underline");
    }

    [Test]
    public void ToggleSizeBuilder_builds_responsive_size_classes()
    {
        string result = ToggleSizes.Default.OnLg.Sm.ToClass();

        result.Should().Be("h-9 min-w-9 px-2 lg:h-8 lg:min-w-8 lg:px-1.5");
    }

    [Test]
    public void VariantBuilder_applies_ordered_tailwind_modifiers()
    {
        string result = Variant.Of(Tracking.Wide).Hover.FocusVisible.DataState("open").ToClass();

        result.Should().Be("hover:focus-visible:data-[state=open]:tracking-wide");
    }

    [Test]
    public void DisplayBuilder_supports_pending_on_variant_before_display_value()
    {
        string result = Display.OnHover.OnFocus.Flex.ToClass();

        result.Should().Be("hover:focus:flex");
    }

    [Test]
    public void ResponsiveUtilityBuilder_supports_pending_on_variants_before_utility_values()
    {
        string result = TextAlign.OnHover.Center.OnFocus.End.ToClass();
        string responsive = TextAlign.OnHover.OnMd.Center.ToClass();

        result.Should().Be("hover:text-center focus:text-end");
        responsive.Should().Be("md:hover:text-center");
    }

    [Test]
    public void TextColorBuilder_supports_pending_on_variants_before_color_values()
    {
        string result = TextColor.OnHover.Primary.OnFocus.Foreground.ToClass();

        result.Should().Be("hover:text-primary focus:text-foreground");
    }

    [Test]
    public void BackgroundColorBuilder_supports_pending_on_variants_before_color_values()
    {
        string result = BackgroundColor.OnHover.Accent.ToClass();

        result.Should().Be("hover:bg-accent");
    }

    [Test]
    public void BackgroundColorBuilder_supports_chained_pending_variants_with_opacity_tokens()
    {
        string result = BackgroundColor.OnDark.OnHover.Token("accent/50").ToClass();

        result.Should().Be("dark:hover:bg-accent/50");
    }

    [Test]
    public void Color_builders_support_static_palette_token_entrypoints()
    {
        BackgroundColor.Token("neutral-100").ToClass().Should().Be("bg-neutral-100");
        TextColor.Token("neutral-900").ToClass().Should().Be("text-neutral-900");
        AccentColor.Token("blue-500").ToClass().Should().Be("accent-blue-500");
        BorderColor.Token("zinc-300").ToClass().Should().Be("border-zinc-300");
        CaretColor.Token("rose-500").ToClass().Should().Be("caret-rose-500");
    }

    [Test]
    public void Color_builders_support_palette_family_shade_entrypoints()
    {
        BorderColor.Neutral.Is800.ToClass().Should().Be("border-neutral-800");
        TextColor.Slate.Is50.ToClass().Should().Be("text-slate-50");
        BackgroundColor.Neutral.Is100.ToClass().Should().Be("bg-neutral-100");
        RingColor.Blue.Is500.ToClass().Should().Be("ring-blue-500");
        AccentColor.Emerald.Is600.ToClass().Should().Be("accent-emerald-600");
        CaretColor.Rose.Is950.ToClass().Should().Be("caret-rose-950");
    }

    [Test]
    public void Color_palette_builders_support_all_tailwind_shades()
    {
        TextColor.Slate.Is50.ToClass().Should().Be("text-slate-50");
        TextColor.Slate.Is100.ToClass().Should().Be("text-slate-100");
        TextColor.Slate.Is200.ToClass().Should().Be("text-slate-200");
        TextColor.Slate.Is300.ToClass().Should().Be("text-slate-300");
        TextColor.Slate.Is400.ToClass().Should().Be("text-slate-400");
        TextColor.Slate.Is500.ToClass().Should().Be("text-slate-500");
        TextColor.Slate.Is600.ToClass().Should().Be("text-slate-600");
        TextColor.Slate.Is700.ToClass().Should().Be("text-slate-700");
        TextColor.Slate.Is800.ToClass().Should().Be("text-slate-800");
        TextColor.Slate.Is900.ToClass().Should().Be("text-slate-900");
        TextColor.Slate.Is950.ToClass().Should().Be("text-slate-950");
    }

    [Test]
    public void Color_palette_builders_support_pending_variants()
    {
        BorderColor.OnHover.Neutral.Is800.ToClass().Should().Be("hover:border-neutral-800");
        TextColor.OnDark.OnFocus.Slate.Is50.ToClass().Should().Be("dark:focus:text-slate-50");
    }

    [Test]
    public void BackgroundColorBuilder_supports_foreground_token()
    {
        string result = BackgroundColor.Foreground.OnDark.Primary.ToClass();

        result.Should().Be("bg-foreground dark:bg-primary");
    }

    [Test]
    public void BackgroundColorBuilder_consumes_pending_variants_per_color_value()
    {
        CssValue<BackgroundColorBuilder>? backgroundColor = null;

        backgroundColor ??= BackgroundColor.OnHover.Accent.OnDark.OnHover.Token("accent/50");

        backgroundColor.ToString().Should().Be("hover:bg-accent dark:hover:bg-accent/50");
    }

    [Test]
    public void Builders_support_pending_disabled_variant_before_utility_values()
    {
        string background = BackgroundColor.OnDisabled.Muted.ToClass();
        string display = Display.OnDisabled.None.ToClass();
        string responsive = TextAlign.OnDisabled.OnMd.Center.ToClass();

        background.Should().Be("disabled:bg-muted");
        display.Should().Be("disabled:hidden");
        responsive.Should().Be("md:disabled:text-center");
    }

    [Test]
    public void CssValue_nullable_slots_accept_on_hover_variant_with_coalesce_assignment()
    {
        CssValue<DisplayBuilder>? display = null;

        display ??= Display.OnHover.Flex;

        display.ToString().Should().Be("hover:flex");
    }

    [Test]
    public void VariantBuilder_builds_pseudo_element_utilities()
    {
        string rounded = Rounded.Full.After.ToClass();
        string border = BorderColor.Border.After.ToClass();

        rounded.Should().Be("after:rounded-full");
        border.Should().Be("after:border-border");
    }

    [Test]
    public void VariantBuilder_supports_arbitrary_modifier_chains()
    {
        string result = Variant.Of(Display.None)
            .Modifiers("md", "after")
            .ToClass();

        result.Should().Be("md:after:hidden");
    }

    [Test]
    public void VariantBuilder_supports_responsive_variant_chaining()
    {
        string rounded = Rounded.Full.After.OnMd.ToClass();
        string hidden = Display.None.Dark.Hover.OnLg.ToClass();

        rounded.Should().Be("md:after:rounded-full");
        hidden.Should().Be("lg:dark:hover:hidden");
    }

    [Test]
    public void CssBuilderBase_supports_named_group_and_peer_variants()
    {
        string group = Opacity.Is100.Group("data-[state=open]", "navigation-menu").ToClass();
        string peer = TextColor.Utility("text-sidebar-accent-foreground").Peer("data-[active=true]", "menu-button").ToClass();

        group.Should().Be("group-data-[state=open]/navigation-menu:opacity-100");
        peer.Should().Be("peer-data-[active=true]/menu-button:text-sidebar-accent-foreground");
    }

    [Test]
    public void CssValue_can_combine_base_and_variant_builders_for_single_slot()
    {
        CssValue<RoundedBuilder> value = CssValue<RoundedBuilder>.For(
            Rounded.Full,
            Rounded.Full.After
        );

        value.ToString().Should().Be("rounded-full after:rounded-full");
    }

    [Test]
    public void CssValue_can_append_additional_builders()
    {
        CssValue<RoundedBuilder> value = CssValue<RoundedBuilder>.For(Rounded.Full)
            .Add(Rounded.Full.After);

        value.ToString().Should().Be("rounded-full after:rounded-full");
    }

    [Test]
    public void CssValue_allows_direct_assignment_from_variant_builder()
    {
        CssValue<RoundedBuilder> value = Rounded.Full.After;

        value.ToString().Should().Be("after:rounded-full");
    }

    [Test]
    public void JustifyBuilder_builds_responsive_tailwind_classes()
    {
        string result = Justify.Start.OnMd.Between.ToClass();

        result.Should().Be("justify-start md:justify-between");
    }

    [Test]
    public void Split_alignment_builders_cover_shadcn_alignment_utilities()
    {
        string content = ContentAlign.Center.OnMd.Between.ToClass();
        string justifyItems = JustifyItemsAlign.Start.OnLg.End.ToClass();
        string justifySelf = JustifySelfAlign.Auto.OnMd.Center.ToClass();
        string text = TextAlign.Start.OnSm.Center.ToClass();

        content.Should().Be("content-center md:content-between");
        justifyItems.Should().Be("justify-items-start lg:justify-items-end");
        justifySelf.Should().Be("justify-self-auto md:justify-self-center");
        text.Should().Be("text-start sm:text-center");
    }

    [Test]
    public void DurationBuilder_builds_responsive_tailwind_classes()
    {
        string result = Duration.Is150.OnLg.Is300.ToClass();

        result.Should().Be("duration-150 lg:duration-300");
    }

    [Test]
    public void DurationBuilder_supports_zero_and_normalized_tokens()
    {
        Duration.Is0.OnHover.Token("duration-[375ms]").OnMd.Token("200").ToClass()
            .Should().Be("duration-0 hover:duration-[375ms] md:duration-200");
    }

    [Test]
    public void TransformBuilder_builds_transform_utilities()
    {
        string result = Transform.Gpu.OnMd.None.ToClass();

        result.Should().Be("transform-gpu md:transform-none");
    }

    [Test]
    public void DecorationLineBuilder_builds_decoration_line_utilities()
    {
        string result = DecorationLine.Underline.OnSm.LineThrough.ToClass();

        result.Should().Be("underline sm:line-through");
    }

    [Test]
    public void Typography_builders_support_arbitrary_tokens()
    {
        FontWeight.Token("[450]").OnSm.Token("font-[350]").ToClass().Should().Be("font-[450] sm:font-[350]");
        LineClamp.Is2.OnSm.Is3.Token("line-clamp-[7]").ToClass().Should().Be("line-clamp-2 sm:line-clamp-3 line-clamp-[7]");
        LineClamp.Token("3").OnMd.Token("line-clamp-[7]").ToClass().Should().Be("line-clamp-3 md:line-clamp-[7]");
    }

    [Test]
    public void CursorBuilder_builds_tailwind_cursor_classes()
    {
        string result = Cursor.Auto.OnMd.ZoomIn.ToClass();

        result.Should().Be("cursor-auto md:cursor-zoom-in");
    }

    [Test]
    public void ObjectPositionBuilder_builds_tailwind_object_position_classes()
    {
        string result = ObjectPosition.Center.OnLg.BottomRight.ToClass();

        result.Should().Be("object-center lg:object-bottom-right");
    }

    [Test]
    public void LeadingBuilder_builds_tailwind_leading_classes()
    {
        string result = Leading.None.Tight.Snug.Normal.Relaxed.Loose.ToClass();

        result.Should().Be("leading-none leading-tight leading-snug leading-normal leading-relaxed leading-loose");
    }

    [Test]
    public void LeadingBuilder_builds_responsive_named_tailwind_leading_classes()
    {
        string result = Leading.Tight.OnMd.Loose.ToClass();

        result.Should().Be("leading-tight md:leading-loose");
    }

    [Test]
    public void LeadingBuilder_builds_spacing_scale_line_height_classes()
    {
        Leading.Is1.ToClass().Should().Be("leading-1");
        Leading.Is6.OnMd.Is8.OnLg.Normal.ToClass().Should().Be("leading-6 md:leading-8 lg:leading-normal");
    }

    [Test]
    public void TrackingBuilder_builds_tailwind_tracking_classes()
    {
        string result = Tracking.Wide.OnSm.Widest.ToClass();

        result.Should().Be("tracking-wide sm:tracking-widest");
    }

    [Test]
    public void IsolationBuilder_builds_tailwind_isolation_classes()
    {
        string result = Isolation.Auto.OnLg.Isolate.ToClass();

        result.Should().Be("isolation-auto lg:isolation-isolate");
    }

    [Test]
    public void BackgroundBlendModeBuilder_builds_tailwind_background_blend_classes()
    {
        string result = BackgroundBlendMode.Multiply.OnXl.Screen.ToClass();

        result.Should().Be("bg-blend-multiply xl:bg-blend-screen");
    }

    [Test]
    public void GapBuilder_builds_directional_tailwind_gap_classes()
    {
        string result = Gap.Is2.Y.OnMd.Token("6").ToClass();

        result.Should().Be("gap-y-2 md:gap-6");
    }

    [Test]
    public void FlexBuilder_stores_full_tailwind_classes()
    {
        string result = Flex.Is1.OnMd.Auto.Token("2").ToClass();

        result.Should().Be("flex-1 md:flex-auto flex-2");
    }

    [Test]
    public void FlexBuilder_supports_wrap_utilities_for_flex_parameter_usage()
    {
        string result = Flex.Wrap.OnMd.NoWrap.WrapReverse.ToClass();

        result.Should().Be("flex-wrap md:flex-nowrap flex-wrap-reverse");
    }

    [Test]
    public void FlexDirectionBuilder_includes_flex_display_for_tailwind_container_utilities()
    {
        string result = FlexDirection.Col.OnMd.Row.ToClass();

        result.Should().Be("flex flex-col md:flex md:flex-row");
    }

    [Test]
    public void FlexWrapBuilder_includes_flex_display_for_tailwind_container_utilities()
    {
        string result = FlexWrap.Wrap.OnLg.NoWrap.ToClass();

        result.Should().Be("flex flex-wrap lg:flex lg:flex-nowrap");
    }

    [Test]
    public void GridTrackBuilders_emit_prefixed_responsive_classes()
    {
        GridCols.Is1.OnMd.Is3.Count(4).ToClass().Should().Be("grid-cols-1 md:grid-cols-3 grid-cols-4");
        GridRows.Is2.OnLg.Is4.Count(5).ToClass().Should().Be("grid-rows-2 lg:grid-rows-4 grid-rows-5");
    }

    [Test]
    public void ListStyleTypeBuilder_emits_tailwind_list_style_utilities()
    {
        ListStyleType.None.ToClass().Should().Be("list-none");
        ListStyleType.Disc.ToClass().Should().Be("list-disc");
        ListStyleType.Decimal.ToClass().Should().Be("list-decimal");
        ListStyleType.LowerAlpha.ToClass().Should().Be("list-[lower-alpha]");
        ListStyleType.DecimalLeadingZero.ToClass().Should().Be("list-[decimal-leading-zero]");
        ListStyleType.Square.ToString().Should().Be("list-[square]");
    }

    [Test]
    public void GapBuilder_stores_full_tailwind_classes_and_rewrites_axis_variants()
    {
        string result = Gap.Is1.OnMd.Is2.X.Token("6").Y.ToClass();

        result.Should().Be("gap-1 md:gap-x-2 gap-y-6");
    }

    [Test]
    public void PaddingBuilder_builds_axis_specific_tailwind_classes()
    {
        Padding.OnX.Is2.ToClass().Should().Be("px-2");
        Padding.OnY.Is3.ToClass().Should().Be("py-3");
        Padding.OnY.Is14.ToClass().Should().Be("py-14");
        Padding.OnY.Is20.ToClass().Should().Be("py-20");
        Padding.OnX.Is1_5.ToClass().Should().Be("px-1.5");
        Padding.OnX.Token("1.5").ToClass().Should().Be("px-1.5");
        Padding.Is2.OnX.ToClass().Should().Be("px-2");
        Padding.Is3.OnY.ToClass().Should().Be("py-3");
        Padding.Is2_5.OnX.Is0_5.OnY.ToClass().Should().Be("px-2.5 py-0.5");
        Padding.Token("1.5").OnX.Is4.OnY.ToClass().Should().Be("px-1.5 py-4");
        Padding.OnX.Is2.OnY.ToClass().Should().Be("px-2");
        Padding.OnX.Is2.OnY.Is1.ToClass().Should().Be("px-2 py-1");
    }

    [Test]
    public void SpaceBuilder_token_accepts_axis_or_full_utility_tokens()
    {
        Space.Token("y-3").ToClass().Should().Be("space-y-3");
        Space.Token("space-y-3").ToClass().Should().Be("space-y-3");
        Space.Y.Token("2").ToClass().Should().Be("space-y-2");
        Space.X.Is1_5.ToClass().Should().Be("space-x-1.5");
        Space.Y.Is1_5.ToClass().Should().Be("space-y-1.5");
        Space.X.Is2.Token("4").ToClass().Should().Be("space-x-2 space-x-4");
        Space.Y.Is2.Token("4").ToClass().Should().Be("space-y-2 space-y-4");
    }

    [Test]
    public void BackdropFilterBuilder_token_accepts_suffix_or_full_utility_tokens()
    {
        BackdropFilter.Token("blur-xl").ToClass().Should().Be("backdrop-blur-xl");
        BackdropFilter.Token("backdrop-blur-xl").ToClass().Should().Be("backdrop-blur-xl");
        BackdropFilter.Blur.Token("brightness-95").ToClass().Should().Be("backdrop-blur backdrop-brightness-95");
    }

    [Test]
    public void Shadcn_suite_token_values_have_fluent_members()
    {
        Gap.Is1_5.ToClass().Should().Be("gap-1.5");
        Margin.OnX.Negative1.FromTop.Is1_5.ToClass().Should().Be("-mx-1 mt-1.5");
        Padding.Is1_5.ToClass().Should().Be("p-1.5");
        Inset.Is1_5.FromTop.Is1_5.OnX.Is1_5.ToClass().Should().Be("inset-1.5 top-1.5 inset-x-1.5");
        Top.Is1_5.ToClass().Should().Be("top-1.5");
        Right.Is1_5.ToClass().Should().Be("right-1.5");
        Bottom.Is1_5.ToClass().Should().Be("bottom-1.5");
        Left.Is1_5.ToClass().Should().Be("left-1.5");
        Start.Is1_5.ToClass().Should().Be("start-1.5");
        End.Is1_5.ToClass().Should().Be("end-1.5");
        ScrollMargin.Is1_5.FromTop.Is1_5.ToClass().Should().Be("scroll-m-1.5 scroll-mt-1.5");
        ScrollPadding.Is1_5.FromTop.Is1_5.ToClass().Should().Be("scroll-p-1.5 scroll-pt-1.5");
        Size.Is1_5.Is3_5.Is4_5.Is6_5.ToClass().Should().Be("size-1.5 size-3.5 size-4.5 size-6.5");
        Height.Is0_5.Is5_5.Is72.ToClass().Should().Be("h-0.5 h-5.5 h-72");
        Width.Is0_5.Is64.Is72.ToClass().Should().Be("w-0.5 w-64 w-72");
        Leading.Is4_5.Is6_5.ToClass().Should().Be("leading-4.5 leading-6.5");
        Stroke.Current.ToClass().Should().Be("stroke-current");
        TextAlign.Left.OnMd.Right.ToClass().Should().Be("text-left md:text-right");
        RingColor.Ring50.ToClass().Should().Be("ring-ring/50");
    }

    [Test]
    public void PaddingBuilder_builds_responsive_axis_specific_tailwind_classes()
    {
        string result = Padding.OnX.Is4.OnMd.OnX.Is6.OnLg.OnY.Token("8").ToClass();

        result.Should().Be("px-4 md:px-6 lg:py-8");
    }

    [Test]
    public void BorderBuilder_builds_default_unsuffixed_border_classes()
    {
        string border = Border.Default.ToClass();
        string is1Border = Border.Is1.ToClass();
        string bottomIs1Border = Border.FromBottom.Is1.ToClass();
        string topBorder = Border.FromTop.Default.ToClass();
        string responsiveBorder = Border.Default.OnMd.Is2.ToClass();
        string transparentBorder = BorderColor.Transparent.ToClass();
        string trailingBottomBorder = Border.Is1.FromBottom.ToClass();

        border.Should().Be("border");
        is1Border.Should().Be("border");
        bottomIs1Border.Should().Be("border-b");
        topBorder.Should().Be("border-t");
        responsiveBorder.Should().Be("border md:border-2");
        transparentBorder.Should().Be("border-transparent");
        trailingBottomBorder.Should().Be("border-b");
    }

    [Test]
    public void Common_shadcn_tailwind_utility_forms_are_expressible()
    {
        Ring.Default.ToClass().Should().Be("ring");
        Rounded.Default.ToClass().Should().Be("rounded");
        Shadow.Default.ToClass().Should().Be("shadow");
        Truncate.Default.ToClass().Should().Be("truncate");
        BackgroundColor.Transparent.ToClass().Should().Be("bg-transparent");
        Divide.Border.ToClass().Should().Be("divide-border");
        Divide.X.OnMd.Dashed.ToClass().Should().Be("divide-x md:divide-dashed");
        RingOffset.Background.ToClass().Should().Be("ring-offset-background");
        RingOffset.Width("1").OnMd.Width("2").ToClass().Should().Be("ring-offset-1 md:ring-offset-2");
    }

    [Test]
    public void ScaleBuilder_builds_tailwind_transform_scale_classes()
    {
        string result = Scale.Scale95.Scale125.ToClass();

        result.Should().Be("scale-95 scale-125");
    }

    [Test]
    public void OutlineStyleBuilder_builds_tailwind_outline_classes()
    {
        string result = OutlineStyle.None.OnMd.Double.OnLg.Hidden.ToClass();

        result.Should().Be("outline-none md:outline-double lg:outline-hidden");
    }

    [Test]
    public void Common_missing_suite_defaults_are_expressible()
    {
        MinWidth.Is32.ToClass().Should().Be("min-w-32");
        ZIndex.Z0.OnMd.Z50.ToClass().Should().Be("z-0 md:z-50");
    }

    [Test]
    public void Common_tailwind_display_and_opacity_values_are_expressible()
    {
        Display.FlowRoot.OnMd.Contents.OnLg.TableHeaderGroup.ToClass().Should().Be("flow-root md:contents lg:table-header-group");
        Display.Token("list-item").OnHover.TableRowGroup.ToClass().Should().Be("list-item hover:table-row-group");

        Opacity.Is5.OnDisabled.Is50.OnMd.Is95.Token("[.37]").ToClass().Should().Be("opacity-5 disabled:opacity-50 md:opacity-95 opacity-[.37]");
    }

    [Test]
    public void Common_text_size_and_size_values_are_expressible()
    {
        TextSize.FiveXl.OnMd.NineXl.ToClass().Should().Be("text-5xl md:text-9xl");
        Size.IsFull.IsFit.IsPx.ToClass().Should().Be("size-full size-fit size-px");
    }

    [Test]
    public void Min_and_max_height_builders_cover_viewport_and_radix_tokens()
    {
        MinHeight.IsSvh.OnMd.IsDvh.Token("(--cell-size)").ToClass().Should().Be("min-h-svh md:min-h-dvh min-h-(--cell-size)");
        MaxHeight.Token("(--radix-select-content-available-height)").OnLg.IsScreen.ToClass().Should()
            .Be("max-h-(--radix-select-content-available-height) lg:max-h-screen");
    }

    [Test]
    public void Height_constraint_builders_support_static_variant_entrypoints()
    {
        MinHeight.OnHover.IsSvh.OnFocus.IsDvh.ToClass().Should().Be("hover:min-h-svh focus:min-h-dvh");
        MaxHeight.OnDark.OnHover.Token("(--radix-select-content-available-height)").ToClass()
            .Should().Be("dark:hover:max-h-(--radix-select-content-available-height)");
    }

    [Test]
    public void Bottom_supports_generated_static_variant_entrypoints()
    {
        Bottom.OnHover.Is4.OnDisabled.Token("bottom-[2px]").ToClass().Should().Be("hover:bottom-4 disabled:bottom-[2px]");
    }

    [Test]
    public void Border_supports_generated_static_variant_entrypoints()
    {
        Border.OnHover.Is2.OnDisabled.Token("[3px]").ToClass().Should().Be("hover:border-2 disabled:border-[3px]");
    }

    [Test]
    public void Generated_static_variant_entrypoints_cover_tailwind_modifier_families()
    {
        BackgroundColor.OnMaxMd.Primary.OnContainerSm.Secondary.OnFocusWithin.Accent.ToClass()
            .Should().Be("max-md:bg-primary @sm:bg-secondary focus-within:bg-accent");

        BackgroundColor.OnPeerPlaceholderShown.Muted.OnAriaSelected.Foreground.ToClass()
            .Should().Be("peer-placeholder-shown:bg-muted aria-selected:bg-foreground");

        Variant.Of(Display.Block).OnContainerMd.OnMotionReduce.OnGroupFocusVisible.ToClass()
            .Should().Be("@md:motion-reduce:group-focus-visible:block");
    }

    [Test]
    public void Common_color_builders_support_generated_static_variant_entrypoints()
    {
        AccentColor.OnHover.Primary.OnMaxMd.Current.ToClass()
            .Should().Be("hover:accent-primary max-md:accent-current");

        BorderColor.OnFocus.Border.OnAriaSelected.Primary.ToClass()
            .Should().Be("focus:border-border aria-selected:border-primary");

        CaretColor.OnFocusVisible.Primary.OnPeerInvalid.Transparent.ToClass()
            .Should().Be("focus-visible:caret-primary peer-invalid:caret-transparent");

        RingColor.OnGroupFocusVisible.Foreground.OnContainerMd.Token("primary/40").ToClass()
            .Should().Be("group-focus-visible:ring-foreground @md:ring-primary/40");
    }

    [Test]
    public void Common_layout_and_interaction_builders_support_generated_static_variant_entrypoints()
    {
        Animation.OnMotionSafe.Spin.OnMotionReduce.None.ToClass()
            .Should().Be("motion-safe:animate-spin motion-reduce:animate-none");

        Cursor.OnDisabled.NotAllowed.OnGroupHover.Pointer.ToClass()
            .Should().Be("disabled:cursor-not-allowed group-hover:cursor-pointer");

        ObjectFit.OnContainerMd.Cover.OnPortrait.Contain.ToClass()
            .Should().Be("@md:object-cover portrait:object-contain");

        Position.OnMaxMd.Absolute.OnPrint.Static.ToClass()
            .Should().Be("max-md:absolute print:static");
    }

    [Test]
    public void Common_display_environment_builders_support_generated_static_variant_entrypoints()
    {
        AspectRatio.OnContainerSm.R16X9.OnMaxLg.R1X1.ToClass()
            .Should().Be("@sm:aspect-video max-lg:aspect-square");

        BackgroundBlendMode.OnHover.Multiply.OnDark.Screen.ToClass()
            .Should().Be("hover:bg-blend-multiply dark:bg-blend-screen");

        Contain.OnForcedColors.Paint.OnPrint.None.ToClass()
            .Should().Be("forced-colors:contain-paint print:contain-none");

        Float.OnRtl.Right.OnLtr.Left.ToClass()
            .Should().Be("rtl:float-right ltr:float-left");
    }

    [Test]
    public void Common_typography_builders_support_generated_static_variant_entrypoints()
    {
        FontStyle.OnFirstLetter.Italic.OnHover.Normal.ToClass()
            .Should().Be("first-letter:italic hover:not-italic");

        FontWeight.OnGroupHover.Bold.OnPeerDisabled.Token("[450]").ToClass()
            .Should().Be("group-hover:font-bold peer-disabled:font-[450]");

        Leading.OnContainerMd.Is6.OnMaxSm.Tight.ToClass()
            .Should().Be("@md:leading-6 max-sm:leading-tight");

        Tracking.OnFocusVisible.Wide.OnDisabled.Tighter.ToClass()
            .Should().Be("focus-visible:tracking-wide disabled:tracking-tighter");

        TextTransform.OnHover.Uppercase.OnAriaExpanded.Capitalize.ToClass()
            .Should().Be("hover:uppercase aria-expanded:capitalize");
    }

    [Test]
    public void Common_text_behavior_builders_support_generated_static_variant_entrypoints()
    {
        TextBreak.OnMaxMd.Words.OnContainerLg.Keep.ToClass()
            .Should().Be("max-md:break-words @lg:break-keep");

        TextOverflow.OnHover.Ellipsis.OnFocus.Clip.ToClass()
            .Should().Be("hover:text-ellipsis focus:text-clip");

        TextWrap.OnContainerSm.Balance.OnMaxLg.Pretty.ToClass()
            .Should().Be("@sm:text-balance max-lg:text-pretty");

        UserSelect.OnDisabled.None.OnEnabled.All.ToClass()
            .Should().Be("disabled:select-none enabled:select-all");

        Visibility.OnGroupHover.Visible.OnPeerDisabled.Invisible.ToClass()
            .Should().Be("group-hover:visible peer-disabled:invisible");

        Whitespace.OnPlaceholderShown.Nowrap.OnPrint.PreWrap.ToClass()
            .Should().Be("placeholder-shown:whitespace-nowrap print:whitespace-pre-wrap");
    }

    [Test]
    public void Width_and_height_builders_support_generated_static_variant_entrypoints()
    {
        Width.OnHover.IsFull.OnContainerMd.Token("[18rem]").ToClass()
            .Should().Be("hover:w-full @md:w-[18rem]");

        Height.OnMaxSm.IsScreen.OnMotionReduce.Auto.ToClass()
            .Should().Be("max-sm:h-screen motion-reduce:h-auto");
    }

    [Test]
    public void Common_interaction_layout_builders_support_generated_static_variant_entrypoints()
    {
        Isolation.OnContainerMd.Isolate.OnMaxSm.Auto.ToClass()
            .Should().Be("@md:isolation-isolate max-sm:isolation-auto");

        PointerEvents.OnDisabled.None.OnEnabled.Auto.ToClass()
            .Should().Be("disabled:pointer-events-none enabled:pointer-events-auto");

        PointerEvents.None.OnDisabled.ToClass()
            .Should().Be("disabled:pointer-events-none");

        Opacity.Is50.OnDisabled.OnMd.ToClass()
            .Should().Be("md:disabled:opacity-50");

        Cursor.NotAllowed.OnDisabled.ToClass()
            .Should().Be("disabled:cursor-not-allowed");

        Resize.OnHover.Both.OnMd.OnFocus.Vertical.ToClass()
            .Should().Be("hover:resize md:focus:resize-y");

        Scale.OnGroupHover.Scale105.OnPeerDisabled.Scale95.ToClass()
            .Should().Be("group-hover:scale-105 peer-disabled:scale-95");

        Shrink.OnMaxLg.Is0.OnContainerSm.Is1.ToClass()
            .Should().Be("max-lg:shrink-0 @sm:shrink");

        ZIndex.OnOpen.Z50.OnBackdrop.N1.ToClass()
            .Should().Be("open:z-50 backdrop:z-n1");
    }

    [Test]
    public void Final_class_utility_builders_support_generated_static_variant_entrypoints()
    {
        AutoCols.OnHover.Min.OnMd.Fr.ToClass().Should().Be("hover:auto-cols-min md:auto-cols-fr");
        Fill.OnDisabled.Current.ToClass().Should().Be("disabled:fill-current");
        Stroke.OnHover.None.ToClass().Should().Be("hover:stroke-none");
    }

    [Test]
    public void Position_offset_builders_support_generated_static_variant_entrypoints()
    {
        Top.OnHover.Is4.ToClass().Should().Be("hover:top-4");
        Left.OnDisabled.Token("[2px]").ToClass().Should().Be("disabled:left-[2px]");
        Start.OnFocus.Is2.ToClass().Should().Be("focus:start-2");
        End.OnDark.Is5.ToClass().Should().Be("dark:end-5");
    }

    [Test]
    public void StrokeLineCapBuilder_builds_tailwind_stroke_cap_classes()
    {
        string result = StrokeLineCap.Auto.OnSm.Butt.ToClass();

        result.Should().Be("stroke-cap-auto sm:stroke-cap-butt");
    }

    [Test]
    public void Offset_side_builders_build_tailwind_position_offset_classes()
    {
        Top.Is0.OnMd.Is4.ToClass().Should().Be("top-0 md:top-4");
        Right.Px.OnLg.Auto.ToClass().Should().Be("right-px lg:right-auto");
        Bottom.Is2.OnSm.Is5.ToClass().Should().Be("bottom-2 sm:bottom-5");
        Left.Auto.OnXl.Is1.ToClass().Should().Be("left-auto xl:left-1");

        Top.Token("[calc(100%-1rem)]").ToClass().Should().Be("top-[calc(100%-1rem)]");
        Right.Is0.OnMd.Token("full").ToClass().Should().Be("right-0 md:right-full");
    }
}
