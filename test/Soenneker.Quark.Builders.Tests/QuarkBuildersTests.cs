using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Builders.Tests;

[Collection("Collection")]
public sealed class QuarkBuildersTests : FixturedUnitTest
{
    public QuarkBuildersTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void ButtonSizeBuilder_builds_responsive_size_classes()
    {
        string result = ButtonSizes.Default.OnMd.IconSm.ToClass();

        Assert.Equal("h-8 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2 md:size-7 md:rounded-[min(var(--radius-md),12px)] md:in-data-[slot=button-group]:rounded-lg", result);
    }

    [Fact]
    public void ToggleSizeBuilder_builds_responsive_size_classes()
    {
        string result = ToggleSizes.Default.OnLg.Sm.ToClass();

        Assert.Equal("h-8 min-w-8 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2 lg:h-7 lg:min-w-7 lg:rounded-[min(var(--radius-md),12px)] lg:px-2.5 lg:text-[0.8rem] lg:has-data-[icon=inline-end]:pr-1.5 lg:has-data-[icon=inline-start]:pl-1.5 lg:[&_svg:not([class*='size-'])]:size-3.5", result);
    }

    [Fact]
    public void VariantBuilder_applies_ordered_tailwind_modifiers()
    {
        string result = Variant.Of(Tracking.Wide).Hover.FocusVisible.DataState("open").ToClass();

        Assert.Equal("hover:focus-visible:data-[state=open]:tracking-wide", result);
    }

    [Fact]
    public void VariantBuilder_builds_pseudo_element_utilities()
    {
        string rounded = Rounded.Full.After.ToClass();
        string border = BorderColor.Border.After.ToClass();

        Assert.Equal("after:rounded-full", rounded);
        Assert.Equal("after:border-border", border);
    }

    [Fact]
    public void VariantBuilder_supports_arbitrary_modifier_chains()
    {
        string result = Variant.Of(Display.None)
            .Modifiers("md", "after")
            .ToClass();

        Assert.Equal("md:after:hidden", result);
    }

    [Fact]
    public void VariantBuilder_supports_responsive_variant_chaining()
    {
        string rounded = Rounded.Full.After.OnMd.ToClass();
        string hidden = Display.None.Dark.Hover.OnLg.ToClass();

        Assert.Equal("md:after:rounded-full", rounded);
        Assert.Equal("lg:dark:hover:hidden", hidden);
    }

    [Fact]
    public void CssBuilderBase_supports_named_group_and_peer_variants()
    {
        string group = Opacity.Is100.Group("data-[state=open]", "navigation-menu").ToClass();
        string peer = TextColor.Utility("text-sidebar-accent-foreground").Peer("data-[active=true]", "menu-button").ToClass();

        Assert.Equal("group-data-[state=open]/navigation-menu:opacity-100", group);
        Assert.Equal("peer-data-[active=true]/menu-button:text-sidebar-accent-foreground", peer);
    }

    [Fact]
    public void CssValue_can_combine_base_and_variant_builders_for_single_slot()
    {
        CssValue<RoundedBuilder> value = CssValue<RoundedBuilder>.For(
            Rounded.Full,
            Rounded.Full.After
        );

        Assert.Equal("rounded-full after:rounded-full", value.ToString());
    }

    [Fact]
    public void CssValue_can_append_additional_builders()
    {
        CssValue<RoundedBuilder> value = CssValue<RoundedBuilder>.For(Rounded.Full)
            .Add(Rounded.Full.After);

        Assert.Equal("rounded-full after:rounded-full", value.ToString());
    }

    [Fact]
    public void CssValue_allows_direct_assignment_from_variant_builder()
    {
        CssValue<RoundedBuilder> value = Rounded.Full.After;

        Assert.Equal("after:rounded-full", value.ToString());
    }

    [Fact]
    public void JustifyBuilder_builds_responsive_tailwind_classes()
    {
        string result = Justify.Start.OnMd.Between.ToClass();

        Assert.Equal("justify-start md:justify-between", result);
    }

    [Fact]
    public void Split_alignment_builders_cover_shadcn_alignment_utilities()
    {
        string content = ContentAlign.Center.OnMd.Between.ToClass();
        string justifyItems = JustifyItemsAlign.Start.OnLg.End.ToClass();
        string justifySelf = JustifySelfAlign.Auto.OnMd.Center.ToClass();
        string text = TextAlign.Start.OnSm.Center.ToClass();

        Assert.Equal("content-center md:content-between", content);
        Assert.Equal("justify-items-start lg:justify-items-end", justifyItems);
        Assert.Equal("justify-self-auto md:justify-self-center", justifySelf);
        Assert.Equal("text-start sm:text-center", text);
    }

    [Fact]
    public void DurationBuilder_builds_responsive_tailwind_classes()
    {
        string result = Duration.Is150.OnLg.Is300.ToClass();

        Assert.Equal("duration-150 lg:duration-300", result);
    }

    [Fact]
    public void TransformBuilder_builds_transform_utilities()
    {
        string result = Transform.Gpu.OnMd.None.ToClass();

        Assert.Equal("transform-gpu md:transform-none", result);
    }

    [Fact]
    public void DecorationLineBuilder_builds_decoration_line_utilities()
    {
        string result = DecorationLine.Underline.OnSm.LineThrough.ToClass();

        Assert.Equal("underline sm:line-through", result);
    }

    [Fact]
    public void CursorBuilder_builds_tailwind_cursor_classes()
    {
        string result = Cursor.Auto.OnMd.ZoomIn.ToClass();

        Assert.Equal("cursor-auto md:cursor-zoom-in", result);
    }

    [Fact]
    public void ObjectPositionBuilder_builds_tailwind_object_position_classes()
    {
        string result = ObjectPosition.Center.OnLg.BottomRight.ToClass();

        Assert.Equal("object-center lg:object-bottom-right", result);
    }

    [Fact]
    public void LeadingBuilder_builds_tailwind_leading_classes()
    {
        string result = Leading.Tight.OnMd.Loose.ToClass();

        Assert.Equal("leading-tight md:leading-loose", result);
    }

    [Fact]
    public void TrackingBuilder_builds_tailwind_tracking_classes()
    {
        string result = Tracking.Wide.OnSm.Widest.ToClass();

        Assert.Equal("tracking-wide sm:tracking-widest", result);
    }

    [Fact]
    public void IsolationBuilder_builds_tailwind_isolation_classes()
    {
        string result = Isolation.Auto.OnLg.Isolate.ToClass();

        Assert.Equal("isolation-auto lg:isolation-isolate", result);
    }

    [Fact]
    public void BackgroundBlendModeBuilder_builds_tailwind_background_blend_classes()
    {
        string result = BackgroundBlendMode.Multiply.OnXl.Screen.ToClass();

        Assert.Equal("bg-blend-multiply xl:bg-blend-screen", result);
    }

    [Fact]
    public void GapBuilder_builds_directional_tailwind_gap_classes()
    {
        string result = Gap.Is2.Y.OnMd.Token("6").ToClass();

        Assert.Equal("gap-y-2 md:gap-6", result);
    }

    [Fact]
    public void BorderBuilder_builds_default_unsuffixed_border_classes()
    {
        string border = Border.Default.ToClass();
        string is1Border = Border.Is1.ToClass();
        string bottomIs1Border = Border.Is1.FromBottom.ToClass();
        string topBorder = Border.Default.FromTop.ToClass();
        string responsiveBorder = Border.Default.OnMd.Is2.ToClass();
        string transparentBorder = BorderColor.Transparent.ToClass();

        Assert.Equal("border", border);
        Assert.Equal("border", is1Border);
        Assert.Equal("border-b", bottomIs1Border);
        Assert.Equal("border-t", topBorder);
        Assert.Equal("border md:border-2", responsiveBorder);
        Assert.Equal("border-transparent", transparentBorder);
    }

    [Fact]
    public void Common_shadcn_tailwind_utility_forms_are_expressible()
    {
        Assert.Equal("ring", Ring.Default.ToClass());
        Assert.Equal("rounded", Rounded.Default.ToClass());
        Assert.Equal("shadow", BoxShadow.Default.ToClass());
        Assert.Equal("truncate", Truncate.Default.ToClass());
        Assert.Equal("bg-transparent", BackgroundColor.Transparent.ToClass());
        Assert.Equal("divide-border", Divide.Border.ToClass());
        Assert.Equal("divide-x md:divide-dashed", Divide.X.OnMd.Dashed.ToClass());
        Assert.Equal("ring-offset-background", RingOffset.Background.ToClass());
        Assert.Equal("ring-offset-1 md:ring-offset-2", RingOffset.Width("1").OnMd.Width("2").ToClass());
    }

    [Fact]
    public void ScaleBuilder_builds_tailwind_transform_scale_classes()
    {
        string result = Scale.Scale95.Scale125.ToClass();

        Assert.Equal("scale-95 scale-125", result);
    }

    [Fact]
    public void OutlineStyleBuilder_builds_tailwind_outline_classes()
    {
        string result = OutlineStyle.None.OnMd.Double.ToClass();

        Assert.Equal("outline-none md:outline-double", result);
    }

    [Fact]
    public void StrokeLineCapBuilder_builds_tailwind_stroke_cap_classes()
    {
        string result = StrokeLineCap.Auto.OnSm.Butt.ToClass();

        Assert.Equal("stroke-cap-auto sm:stroke-cap-butt", result);
    }
}
