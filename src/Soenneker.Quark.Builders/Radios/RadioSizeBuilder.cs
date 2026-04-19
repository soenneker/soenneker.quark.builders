using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for shadcn-style radio sizing tokens.
/// </summary>
public sealed class RadioSizeBuilder : CssBuilderBase
{
    private readonly List<string> _tokens = new(4);

    internal RadioSizeBuilder(string value)
    {
        _tokens.Add(value);
    }

    public RadioSizeBuilder Default => Chain("default");
    public RadioSizeBuilder Xs => Chain("xs");
    public RadioSizeBuilder Sm => Chain("sm");
    public RadioSizeBuilder Md => Chain("md");
    public RadioSizeBuilder Lg => Chain("lg");
    public RadioSizeBuilder Xl => Chain("xl");
    public RadioSizeBuilder Xxl => Chain("xxl");

    public RadioSizeBuilder Token(string value) => Chain(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RadioSizeBuilder Chain(string value)
    {
        _tokens.Add(value);
        return this;
    }

    public override string ToClass()
    {
        if (_tokens.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();

        for (var i = 0; i < _tokens.Count; i++)
        {
            if (i > 0)
                sb.Append(' ');

            sb.Append(_tokens[i]);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;
}
