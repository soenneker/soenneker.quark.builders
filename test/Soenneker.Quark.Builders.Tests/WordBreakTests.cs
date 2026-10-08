using AwesomeAssertions;

namespace Soenneker.Quark.Builders.Tests;

public sealed class WordBreakTests
{
    [Test]
    public void Word_break_and_overflow_wrap_remain_distinct_with_variants()
    {
        WordBreak.Normal.OnMd.All.OnHover.Keep.ToClass().Should().Be("break-normal md:break-all hover:break-keep");
        OverflowWrap.Normal.OnMd.Anywhere.OnHover.BreakWord.ToClass().Should().Be("wrap-normal md:wrap-anywhere hover:wrap-break-word");
    }
}
