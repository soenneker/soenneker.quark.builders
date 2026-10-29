using AwesomeAssertions;

namespace Soenneker.Quark.Builders.Tests;

public sealed class FluentUtilityTests
{

    [Test]
    public void Width_size_and_list_modifiers_bind_to_the_next_value()
    {
        MinWidth.Is0.OnMd.Token("[20ch]").IsFull.ToClass().Should().Be("min-w-0 md:min-w-[20ch] min-w-full");
        Size.OnMd.Is4.OnHover.Token("[3rem]").IsFull.ToClass().Should().Be("md:size-4 hover:size-[3rem] size-full");
        ListStyleType.OnMd.Disc.OnHover.Circle.None.ToClass().Should().Be("md:list-disc hover:list-[circle] list-none");
    }

    [Test]
    public void Overflow_axes_and_modifiers_apply_to_individual_rules()
    {
        Overflow.X.Hidden.OnMd.Y.Auto.Clip.ToClass().Should().Be("overflow-x-hidden md:overflow-y-auto overflow-clip");
        Overflow.OnLg.X.Scroll.OnHover.Visible.ToClass().Should().Be("lg:overflow-x-scroll hover:overflow-visible");
    }

    [Test]
    public void Pending_axis_does_not_rewrite_previous_or_cached_output()
    {
        var builder = Overflow.Hidden;
        builder.ToClass().Should().Be("overflow-hidden");
        _ = builder.X;
        builder.ToClass().Should().Be("overflow-hidden");
        builder.Auto.ToClass().Should().Be("overflow-hidden overflow-x-auto");
    }

    [Test]
    public void Rendering_then_appending_refreshes_each_utility_cache()
    {
        var size = Size.Is4;
        size.ToClass().Should().Be("size-4");
        size.OnMd.Is6.ToClass().Should().Be("size-4 md:size-6");
        var width = MinWidth.Is0;
        width.ToClass().Should().Be("min-w-0");
        width.OnMd.IsFull.ToClass().Should().Be("min-w-0 md:min-w-full");
        var list = ListStyleType.Disc;
        list.ToClass().Should().Be("list-disc");
        list.OnMd.Decimal.ToClass().Should().Be("list-disc md:list-decimal");
    }
}
