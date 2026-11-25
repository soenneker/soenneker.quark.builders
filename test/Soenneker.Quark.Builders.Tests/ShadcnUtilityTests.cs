using System;
using AwesomeAssertions;

namespace Soenneker.Quark.Builders.Tests;

public sealed class ShadcnUtilityTests
{
    [Test]
    public void Opacity_applies_once_to_the_next_color()
    {
        RingColor.OnFocusVisible.WithOpacity(50).Ring.ToClass().Should().Be("focus-visible:ring-ring/50");
        BackgroundColor.WithOpacity(5).Primary.OnDark.WithOpacity(0).Slate.Is950.Sidebar.ToClass()
            .Should().Be("bg-primary/5 dark:bg-slate-950/0 bg-sidebar");
        Action invalid = () => TextColor.WithOpacity(101);
        invalid.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Test]
    public void Sidebar_colors_compose_with_variants()
    {
        TextColor.SidebarForeground.OnHover.SidebarAccentForeground.ToClass()
            .Should().Be("text-sidebar-foreground hover:text-sidebar-accent-foreground");
        BorderColor.SidebarBorder.ToClass().Should().Be("border-sidebar-border");
        RingColor.WithOpacity(100).SidebarRing.ToClass().Should().Be("ring-sidebar-ring/100");
    }

    [Test]
    public void Animation_effects_compose_with_state_and_side()
    {
        Animation.In.FadeIn(0).ZoomIn(95).DataState("open").ToClass()
            .Should().Be("data-[state=open]:animate-in data-[state=open]:fade-in-0 data-[state=open]:zoom-in-95");
        Animation.Out.FadeOut(0).ZoomOut(95).ToClass().Should().Be("animate-out fade-out-0 zoom-out-95");
        Animation.SlideInFromTop(2).Data("side", "bottom").ToClass().Should().Be("data-[side=bottom]:slide-in-from-top-2");
        Animation.SlideOutToLeft(4).ToClass().Should().Be("slide-out-to-left-4");
    }
}
