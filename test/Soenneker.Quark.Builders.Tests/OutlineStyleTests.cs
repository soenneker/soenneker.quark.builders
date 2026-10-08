using AwesomeAssertions;

namespace Soenneker.Quark.Builders.Tests;

public sealed class OutlineStyleTests
{
    [Test]
    public void Solid_sets_the_outline_style_without_changing_its_width()
    {
        OutlineStyle.Solid.OnFocus.Dashed.ToClass().Should().Be("outline-solid focus:outline-dashed");
    }
}
