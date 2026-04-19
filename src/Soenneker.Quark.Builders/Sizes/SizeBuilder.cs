
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Builder for Tailwind <c>size-*</c> utilities.
/// </summary>
[TailwindPrefix("size-", Responsive = true)]
public sealed class SizeBuilder : CssBuilderBase
{
    private readonly List<SizeRule> _rules = new(4);

    internal SizeBuilder(string value)
    {
        _rules.Add(new SizeRule(value));
    }

    internal SizeBuilder(List<SizeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is0 => ChainWithValue("size-0");
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is1 => ChainWithValue("size-1");
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is2 => ChainWithValue("size-2");
    /// <summary>
    /// Spacing/sizing scale step `3` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 3` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is3 => ChainWithValue("size-3");
    /// <summary>
    /// Spacing/sizing scale step `4` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 4` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is4 => ChainWithValue("size-4");
    /// <summary>
    /// Spacing/sizing scale step `5` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 5` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is5 => ChainWithValue("size-5");
    /// <summary>
    /// Spacing/sizing scale step `6` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 6` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is6 => ChainWithValue("size-6");
    /// <summary>
    /// Spacing/sizing scale step `7` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 7` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is7 => ChainWithValue("size-7");
    /// <summary>
    /// Spacing/sizing scale step `8` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 8` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is8 => ChainWithValue("size-8");
    /// <summary>
    /// Spacing/sizing scale step `9` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 9` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is9 => ChainWithValue("size-9");
    /// <summary>
    /// Spacing/sizing scale step `10` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 10` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is10 => ChainWithValue("size-10");
    /// <summary>
    /// Spacing/sizing scale step `11` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 11` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is11 => ChainWithValue("size-11");
    /// <summary>
    /// Spacing/sizing scale step `12` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 12` for integer spacing utilities unless overridden).
    /// </summary>
    public SizeBuilder Is12 => ChainWithValue("size-12");

    /// <summary>
    /// Applies an arbitrary Tailwind size token (e.g. "4", "5", "[18px]", "full").
    /// </summary>
    public SizeBuilder Token(string value) => ChainWithValue(NormalizeSizeClass(value));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private SizeBuilder ChainWithValue(string value)
    {
        _rules.Add(new SizeRule(value));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            string cls = _rules[i].Value;
            if (cls.Length == 0)
                continue;

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string NormalizeSizeClass(string value)
    {
        if (value.Length == 0)
            return string.Empty;

        return value.StartsWith("size-") ? value : "size-" + value;
    }

    public override string ToString() => ToClass();
}
