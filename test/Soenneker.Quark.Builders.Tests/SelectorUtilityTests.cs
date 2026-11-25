using AwesomeAssertions;

namespace Soenneker.Quark.Builders.Tests;

public sealed class SelectorUtilityTests
{
    [Test]
    public void Descendants_support_elements_slots_and_compound_selectors()
    {
        PointerEvents.None.Descendant("svg").ToClass().Should().Be("[&_svg]:pointer-events-none");
        Size.Is4.Descendant("svg:not([class*='size-'])").ToClass().Should().Be("[&_svg:not([class*='size-'])]:size-4");
        Size.Is3.DescendantSlot("switch-thumb").ToClass().Should().Be("[&_[data-slot=switch-thumb]]:size-3");
    }

    [Test]
    public void Group_data_preserves_group_names_and_variant_order()
    {
        Size.Is3.GroupData("size", "sm", "switch").ToClass().Should().Be("group-data-[size=sm]/switch:size-3");
        Shrink.Is0.GroupData("state", "open").Descendant("svg").ToClass()
            .Should().Be("group-data-[state=open]:[&_svg]:shrink-0");
    }

    [Test]
    public void Important_marks_only_one_utility_and_is_idempotent()
    {
        Padding.Is2.OnMaxXl.Is0.Important.Important.ToClass().Should().Be("p-2 max-xl:p-0!");
        Size.Is3.Important.GroupData("size", "sm", "switch").ToClass().Should().Be("group-data-[size=sm]/switch:size-3!");
        Size.Is4.DescendantSlot("icon").Important.ToClass().Should().Be("[&_[data-slot=icon]]:size-4!");
    }
}
