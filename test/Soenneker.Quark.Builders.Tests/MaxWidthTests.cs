using AwesomeAssertions;

namespace Soenneker.Quark.Builders.Tests;

public sealed class MaxWidthTests
{
    [Test]
    public void Arbitrary_widths_support_responsive_chaining()
    {
        MaxWidth.Token("[15ch]").OnMd.Token("[20ch]").ToClass().Should().Be("max-w-[15ch] md:max-w-[20ch]");
    }

    [Test]
    public void Modifiers_apply_only_to_the_next_value()
    {
        MaxWidth.OnMd.OnHover.IsLg.IsFull.OnXl.IsNone.ToClass().Should().Be("md:hover:max-w-lg max-w-full xl:max-w-none");
    }

    [Test]
    public void Adding_rules_invalidates_the_rendered_class()
    {
        MaxWidthBuilder builder = MaxWidth.IsSm;
        builder.ToClass().Should().Be("max-w-sm");
        builder.OnLg.IsXl.ToClass().Should().Be("max-w-sm lg:max-w-xl");
    }
}
