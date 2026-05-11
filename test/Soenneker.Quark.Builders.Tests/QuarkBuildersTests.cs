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
        string result = ButtonSizes.Default.OnMd.IconSm.ToClass();

        result.Should().Be("h-8 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2 md:size-7 md:rounded-[min(var(--radius-md),12px)] md:in-data-[slot=button-group]:rounded-lg");
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
        Padding.OnX.Token("1.5").ToClass().Should().Be("px-1.5");
        Padding.Is2.OnX.ToClass().Should().Be("px-2");
        Padding.Is3.OnY.ToClass().Should().Be("py-3");
        Padding.Token("1.5").OnX.Is4.OnY.ToClass().Should().Be("px-1.5 py-4");
    }

    [Test]
    public void PaddingBuilder_builds_responsive_axis_specific_tailwind_classes()
    {
        string result = Padding.OnX.Is4.OnMd.Is6.OnX.OnLg.Token("8").OnY.ToClass();

        result.Should().Be("px-4 md:px-6 lg:py-8");
    }

    [Test]
    public void BorderBuilder_builds_default_unsuffixed_border_classes()
    {
        string border = Border.Default.ToClass();
        string is1Border = Border.Is1.ToClass();
        string bottomIs1Border = Border.Is1.FromBottom.ToClass();
        string topBorder = Border.Default.FromTop.ToClass();
        string responsiveBorder = Border.Default.OnMd.Is2.ToClass();
        string transparentBorder = BorderColor.Transparent.ToClass();

        border.Should().Be("border");
        is1Border.Should().Be("border");
        bottomIs1Border.Should().Be("border-b");
        topBorder.Should().Be("border-t");
        responsiveBorder.Should().Be("border md:border-2");
        transparentBorder.Should().Be("border-transparent");
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
