using System;
using System.Reflection;
using AwesomeAssertions;

namespace Soenneker.Quark.Builders.Tests;

public sealed class AdditionalUtilityBuildersTests
{
    [Test]
    public void Translation_axes_and_modifiers_apply_to_the_next_value_only()
    {
        Translate.OnMd.OnX.NegativeHalf.OnY.Full.Is4.OnHover.OnX.Token("-[13px]").ToClass()
            .Should().Be("md:-translate-x-1/2 translate-y-full translate-4 hover:-translate-x-[13px]");
        Translate.OnX.OnFocus.Is2.OnY.None.Is1.ToClass()
            .Should().Be("focus:translate-x-2 translate-none translate-1");
        Translate.OnX.ToClass().Should().BeEmpty();
    }

    [Test]
    public void Complete_axis_tokens_are_preserved_and_consume_pending_axis()
    {
        Translate.OnX.Token("-translate-y-1/2").Is2.ToClass()
            .Should().Be("-translate-y-1/2 translate-2");
        Translate.Token("-translate-x-4").ToClass().Should().Be("-translate-x-4");
        Skew.OnY.Token("-skew-x-6").Is3.ToClass().Should().Be("-skew-x-6 skew-3");
        Skew.OnHover.OnX.Negative6.OnMd.OnY.Token("[17deg]").ToClass()
            .Should().Be("hover:-skew-x-6 md:skew-y-[17deg]");
        TextIndent.Token("-4").OnMd.Token("-indent-[2em]").ToClass()
            .Should().Be("-indent-4 md:-indent-[2em]");
    }

    [Test]
    public void Table_spacing_supports_independent_axes_and_responsive_values()
    {
        BorderSpacing.OnX.Is2.OnY.Is4.OnMd.Is0.ToClass()
            .Should().Be("border-spacing-x-2 border-spacing-y-4 md:border-spacing-0");
        BorderSpacing.OnX.Token("border-spacing-y-8").Is1.ToClass()
            .Should().Be("border-spacing-y-8 border-spacing-1");
        TableLayout.Auto.OnMd.Fixed.ToClass().Should().Be("table-auto md:table-fixed");
        BorderCollapse.Separate.OnPrint.Collapse.ToClass().Should().Be("border-separate print:border-collapse");
    }

    [Test]
    public void Color_palettes_keep_modifiers_and_support_opacity_and_arbitrary_values()
    {
        OutlineColor.OnFocusVisible.Blue.Is500.OnDark.Token("white/50").ToClass()
            .Should().Be("focus-visible:outline-blue-500 dark:outline-white/50");
        DecorationColor.Red.Is500.OnHover.Current.ToClass()
            .Should().Be("decoration-red-500 hover:decoration-current");
        ShadowColor.OnDark.Token("black/25").ToClass().Should().Be("dark:shadow-black/25");
        TextShadowColor.Token("[var(--brand)]").ToClass().Should().Be("text-shadow-[var(--brand)]");
        InsetShadowColor.OnHover.Slate.Is900.ToClass().Should().Be("hover:inset-shadow-slate-900");
        InsetRingColor.Utility("inset-ring-red-500/50").OnFocus.Transparent.ToClass()
            .Should().Be("inset-ring-red-500/50 focus:inset-ring-transparent");
        var savedPalette = OutlineColor.Primary.OnHover.Red;
        savedPalette.Is500.ToClass().Should().Be("outline-primary hover:outline-red-500");
    }

    [Test]
    public void Generated_content_and_arbitrary_utilities_keep_variant_syntax()
    {
        Content.OnBefore.Empty.OnAfter.Token("[attr(data-label)]").ToClass()
            .Should().Be("before:content-[''] after:content-[attr(data-label)]");
        ListStyleImage.OnMd.Token("[url('/marker.svg')]").ToClass()
            .Should().Be("md:list-image-[url('/marker.svg')]");
        BackgroundClip.OnHover.Text.OnMd.Padding.ToClass()
            .Should().Be("hover:bg-clip-text md:bg-clip-padding");
        OutlineWidth.OnFocusVisible.Token("outline-3").ToClass().Should().Be("focus-visible:outline-3");
    }

    [Test]
    public void Filter_strengths_and_backdrop_strengths_are_independent()
    {
        Blur.None.OnHover.Md.OnMd.Token("[3px]").ToClass().Should().Be("blur-none hover:blur-md md:blur-[3px]");
        BackdropBlur.OnDark.Lg.ToClass().Should().Be("dark:backdrop-blur-lg");
        Brightness.Is100.OnHover.Is125.ToClass().Should().Be("brightness-100 hover:brightness-125");
        BackdropBrightness.OnMd.Token("backdrop-brightness-80").ToClass().Should().Be("md:backdrop-brightness-80");
        Contrast.OnDisabled.Is50.ToClass().Should().Be("disabled:contrast-50");
        BackdropContrast.Is125.ToClass().Should().Be("backdrop-contrast-125");
        Saturate.Is0.OnHover.Is100.ToClass().Should().Be("saturate-0 hover:saturate-100");
        BackdropSaturate.OnHover.Is150.ToClass().Should().Be("hover:backdrop-saturate-150");
    }

    [Test]
    public void New_families_support_discovery_generated_modifiers_and_css_value_composition()
    {
        // The manifest generators discover public roots and evaluate these properties by reflection.
        Type[] roots =
        [
            typeof(OutlineWidth), typeof(BackgroundAttachment), typeof(BackgroundClip), typeof(BackgroundOrigin),
            typeof(ListStylePosition), typeof(ListStyleImage), typeof(TextIndent), typeof(Content), typeof(Columns),
            typeof(BreakBefore), typeof(BreakAfter), typeof(BreakInside), typeof(BoxDecorationBreak),
            typeof(BorderCollapse), typeof(BorderSpacing), typeof(TableLayout), typeof(CaptionSide), typeof(FieldSizing),
            typeof(ColorScheme), typeof(TransitionBehavior), typeof(FontStretch), typeof(TextShadow), typeof(InsetShadow),
            typeof(InsetRing), typeof(Perspective), typeof(PerspectiveOrigin), typeof(BackfaceVisibility), typeof(TransformStyle),
            typeof(Translate), typeof(Skew), typeof(Blur), typeof(BackdropBlur), typeof(Brightness), typeof(BackdropBrightness),
            typeof(Contrast), typeof(BackdropContrast), typeof(Saturate), typeof(BackdropSaturate),
            typeof(OutlineColor), typeof(DecorationColor), typeof(ShadowColor), typeof(TextShadowColor),
            typeof(InsetShadowColor), typeof(InsetRingColor)
        ];

        foreach (Type root in roots)
        {
            root.IsVisible.Should().BeTrue();
            foreach (PropertyInfo property in root.GetProperties(BindingFlags.Public | BindingFlags.Static))
            {
                if (property.GetValue(null) is not ICssBuilder expected || expected.ToClass().Length == 0)
                    continue;

                var modified = (ICssBuilder)root.GetProperty("OnMd")!.GetValue(null)!;
                Type builderType = modified.GetType();
                builderType.GetCustomAttribute<TailwindPrefixAttribute>().Should().NotBeNull();
                var actual = (ICssBuilder)builderType.GetProperty(property.Name)!.GetValue(modified)!;
                actual.ToClass().Should().Be("md:" + expected.ToClass(), $"{root.Name}.{property.Name} must preserve its generated modifier");
                actual.ToStyle().Should().BeEmpty();
                ((ICssBuilder)property.GetValue(null)!).ToClass().Should().Be(expected.ToClass(), "static factories must create independent builders");
            }
        }

        CssValue<TranslateBuilder>.For(Translate.OnX.NegativeHalf, Translate.OnMd.OnY.Is4).ToString()
            .Should().Be("-translate-x-1/2 md:translate-y-4");
    }
}
