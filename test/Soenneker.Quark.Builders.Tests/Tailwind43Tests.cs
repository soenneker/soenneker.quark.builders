using System;
using System.Reflection;
using AwesomeAssertions;

namespace Soenneker.Quark.Builders.Tests;

public sealed class Tailwind43Tests
{
    [Test]
    public void Container_declarations_and_query_variants_have_distinct_syntax()
    {
        ContainerType.InlineSize.OnMd.Size.OnLg.Normal.ToClass()
            .Should().Be("@container md:@container-size lg:@container-normal");
        ContainerType.InlineSizeNamed("card").OnMd.SizeNamed("panel").ToClass()
            .Should().Be("@container/card md:@container-size/panel");
        Width.OnContainerMd.IsFull.ToClass().Should().Be("@md:w-full");
        foreach (Type type in new[] { typeof(Width), typeof(WidthBuilder), typeof(VariantBuilder) })
        {
            type.GetProperty("OnContainer").Should().BeNull();
            type.GetProperty("OnContainerNormal").Should().BeNull();
        }
    }

    [Test]
    public void New_palettes_work_at_static_and_instance_entrypoints_without_losing_modifiers()
    {
        BackgroundColor.Mauve.Is500.ToClass().Should().Be("bg-mauve-500");
        TextColor.Olive.Is950.ToClass().Should().Be("text-olive-950");
        BorderColor.Mist.Is200.ToClass().Should().Be("border-mist-200");
        ShadowColor.Taupe.Is900.ToClass().Should().Be("shadow-taupe-900");
        OutlineColor.OnFocus.Mauve.Is600.OnDark.Mist.Is100.ToClass()
            .Should().Be("focus:outline-mauve-600 dark:outline-mist-100");
        TextColor.Token("olive-500/50").ToClass().Should().Be("text-olive-500/50");
        var palette = BackgroundColor.Primary.OnHover.Taupe;
        palette.Is300.ToClass().Should().Be("bg-primary hover:bg-taupe-300");
    }

    [Test]
    public void Logical_spacing_preserves_signs_sides_and_modifiers()
    {
        Padding.FromBlockStart.Is4.OnMd.FromBlockEnd.Is8.ToClass().Should().Be("pbs-4 md:pbe-8");
        Margin.FromBlockStart.Negative2.FromBlockEnd.Is4.ToClass().Should().Be("-mbs-2 mbe-4");
        ScrollPadding.OnMd.FromBlockStart.Is4.ToClass().Should().Be("md:scroll-pbs-4");
        ScrollMargin.FromBlockEnd.Is2.ToClass().Should().Be("scroll-mbe-2");
        Border.FromBlockStart.Default.FromBlockEnd.Is2.ToClass().Should().Be("border-bs border-be-2");
        Inset.FromStart.Is2.FromEnd.Is4.OnMd.FromBlockStart.Is1.FromBlockEnd.Is5.ToClass()
            .Should().Be("inset-s-2 inset-e-4 md:inset-bs-1 inset-be-5");
        InsetStart.NegativeHalf.OnMd.Token("-inset-s-4").ToClass().Should().Be("-inset-s-1/2 md:-inset-s-4");
        InsetBlockEnd.Token("-[13px]").ToClass().Should().Be("-inset-be-[13px]");
    }

    [Test]
    public void Logical_sizes_and_new_typography_support_arbitrary_values()
    {
        InlineSize.IsFull.OnMd.Is1of2.ToClass().Should().Be("inline-full md:inline-1/2");
        BlockSize.DynamicViewport.ToClass().Should().Be("block-dvh");
        MinInlineSize.Is0.ToClass().Should().Be("min-inline-0");
        MaxInlineSize.Token("[40ch]").ToClass().Should().Be("max-inline-[40ch]");
        MinBlockSize.IsScreen.ToClass().Should().Be("min-block-screen");
        MaxBlockSize.None.ToClass().Should().Be("max-block-none");
        TabSize.Is2.OnMd.Is4.ToClass().Should().Be("tab-2 md:tab-4");
        Zoom.OnHover.Is125.ToClass().Should().Be("hover:zoom-125");
        FontFeatureSettings.Token("[\"ss01\"]").ToClass().Should().Be("font-features-[\"ss01\"]");
    }

    [Test]
    public void Masks_scrollbars_and_filters_use_supported_utilities()
    {
        ScrollbarWidth.Thin.OnHover.Auto.ToClass().Should().Be("scrollbar-thin hover:scrollbar-auto");
        ScrollbarGutter.Stable.OnMd.Both.ToClass().Should().Be("scrollbar-gutter-stable md:scrollbar-gutter-both");
        ScrollbarThumbColor.OnDark.Mauve.Is600.ToClass().Should().Be("dark:scrollbar-thumb-mauve-600");
        ScrollbarTrackColor.Token("mist-100/50").ToClass().Should().Be("scrollbar-track-mist-100/50");
        MaskImage.Linear45.LinearFrom("20%").LinearTo("80%").OnMd.None.ToClass()
            .Should().Be("mask-linear-45 mask-linear-from-20% mask-linear-to-80% md:mask-none");
        MaskImage.Token("[url('/mask.svg')]").ToClass().Should().Be("mask-[url('/mask.svg')]");
        MaskClip.None.OnMd.Border.ToClass().Should().Be("mask-no-clip md:mask-clip-border");
        MaskComposite.Intersect.ToClass().Should().Be("mask-intersect");
        MaskMode.Match.ToClass().Should().Be("mask-match");
        MaskType.Luminance.ToClass().Should().Be("mask-type-luminance");
        HueRotate.Negative90.OnHover.Is180.ToClass().Should().Be("-hue-rotate-90 hover:hue-rotate-180");
        BackdropHueRotate.Token("-90").ToClass().Should().Be("-backdrop-hue-rotate-90");
        Grayscale.Is0.OnHover.Is100.ToClass().Should().Be("grayscale-0 hover:grayscale-100");
        DropShadow.OnHover.Xs.ToClass().Should().Be("hover:drop-shadow-xs");
        DropShadowColor.Taupe.Is500.ToClass().Should().Be("drop-shadow-taupe-500");
        BackdropOpacity.Is50.ToClass().Should().Be("backdrop-opacity-50");
    }

    [Test]
    public void Formerly_invalid_utilities_emit_real_css_and_removed_shortcuts_are_absent()
    {
        Isolation.Isolate.ToClass().Should().Be("isolate");
        ZIndex.OnMd.Negative1.ToClass().Should().Be("md:-z-1");
        ClipPath.Circle("50%").OnHover.Polygon("0_0,100%_0,50%_100%").ToClass()
            .Should().Be("[clip-path:circle(50%)] hover:[clip-path:polygon(0_0,100%_0,50%_100%)]");
        ClipPath.Ellipse("50%_25%").OnMd.Inset("1rem").ToClass()
            .Should().Be("[clip-path:ellipse(50%_25%)] md:[clip-path:inset(1rem)]");
        SvgFillRule.Evenodd.ToClass().Should().Be("[fill-rule:evenodd]");
        StrokeLineCap.OnHover.Round.ToClass().Should().Be("hover:[stroke-linecap:round]");
        StrokeLineJoin.Bevel.ToClass().Should().Be("[stroke-linejoin:bevel]");
        Gradient.To("r").From("red-500").End("blue-500").ToClass()
            .Should().Be("bg-linear-to-r from-red-500 to-blue-500");
        Filter.None.OnHover.Token("[url(#filter)]").ToClass().Should().Be("filter-none hover:filter-[url(#filter)]");
        typeof(Filter).GetProperty("Brightness").Should().BeNull();
        typeof(BackdropFilter).GetProperty("Blur").Should().BeNull();
        typeof(StrokeLineCap).GetProperty("Auto").Should().BeNull();
        typeof(StrokeLineJoin).GetProperty("Auto").Should().BeNull();
        typeof(ICssBuilder).Assembly.GetType("Soenneker.Quark.Start").Should().BeNull();
        typeof(ICssBuilder).Assembly.GetType("Soenneker.Quark.End").Should().BeNull();
    }

    [Test]
    public void New_roots_support_reflection_discovery_and_modifier_consumption()
    {
        Type[] roots =
        [
            typeof(ScrollbarWidth), typeof(ScrollbarGutter), typeof(ContainerType), typeof(Zoom), typeof(TabSize),
            typeof(FontFeatureSettings), typeof(InlineSize), typeof(MinInlineSize), typeof(MaxInlineSize),
            typeof(BlockSize), typeof(MinBlockSize), typeof(MaxBlockSize), typeof(InsetStart), typeof(InsetEnd),
            typeof(InsetBlockStart), typeof(InsetBlockEnd), typeof(Grayscale), typeof(BackdropGrayscale),
            typeof(HueRotate), typeof(BackdropHueRotate), typeof(Invert), typeof(BackdropInvert), typeof(Sepia),
            typeof(BackdropSepia), typeof(DropShadow), typeof(BackdropOpacity), typeof(MaskImage), typeof(MaskClip),
            typeof(MaskComposite), typeof(MaskMode), typeof(MaskOrigin), typeof(MaskPosition), typeof(MaskRepeat),
            typeof(MaskSize), typeof(MaskType), typeof(ScrollbarThumbColor), typeof(ScrollbarTrackColor), typeof(DropShadowColor)
        ];
        foreach (Type root in roots)
        {
            foreach (PropertyInfo property in root.GetProperties(BindingFlags.Public | BindingFlags.Static))
            {
                if (property.GetValue(null) is not ICssBuilder plain || plain.ToClass().Length == 0)
                    continue;
                object modified = root.GetProperty("OnMd")!.GetValue(null)!;
                var actual = (ICssBuilder)modified.GetType().GetProperty(property.Name)!.GetValue(modified)!;
                actual.ToClass().Should().Be("md:" + plain.ToClass(), root.Name + "." + property.Name);
                actual = (ICssBuilder)modified.GetType().GetProperty(property.Name)!.GetValue(modified)!;
                actual.ToClass().Should().Be("md:" + plain.ToClass() + " " + plain.ToClass());
                actual.ToStyle().Should().BeEmpty();
            }
        }
    }
}
