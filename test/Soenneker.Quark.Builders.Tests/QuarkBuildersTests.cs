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

        Assert.Equal("h-9 px-4 py-2 has-[>svg]:px-3 md:size-8", result);
    }

    [Fact]
    public void ButtonStyleUtil_returns_input_group_class()
    {
        string result = ButtonStyleUtil.GetInputGroupSizeClass("icon-xs");

        Assert.Equal("size-6 rounded-[calc(var(--radius)-5px)] p-0 has-[>svg]:p-0 [&>svg:not([class*='size-'])]:size-3", result);
    }

    [Fact]
    public void ToggleSizeBuilder_builds_responsive_size_classes()
    {
        string result = ToggleSizes.Default.OnLg.Small.ToClass();

        Assert.Equal("h-8 min-w-8 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2 lg:h-7 lg:min-w-7 lg:rounded-[min(var(--radius-md),12px)] lg:px-2.5 lg:text-[0.8rem] lg:has-data-[icon=inline-end]:pr-1.5 lg:has-data-[icon=inline-start]:pl-1.5 lg:[&_svg:not([class*='size-'])]:size-3.5", result);
    }

    [Fact]
    public void VariantBuilder_applies_ordered_tailwind_modifiers()
    {
        string result = Variant.Of(Tracking.Wide).Hover.FocusVisible.DataState("open").ToClass();

        Assert.Equal("hover:focus-visible:data-[state=open]:tracking-wide", result);
    }

    [Fact]
    public void JustifyBuilder_builds_responsive_tailwind_classes()
    {
        string result = Justify.Start.OnMd.Between.ToClass();

        Assert.Equal("justify-start md:justify-between", result);
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
    public void GapBuilder_builds_directional_tailwind_gap_classes()
    {
        string result = Gap.Is2.Row.OnMd.Token("6").ToClass();

        Assert.Equal("gap-y-2 md:gap-6", result);
    }
}
