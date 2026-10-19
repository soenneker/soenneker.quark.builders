using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the responsive utility builder.
/// </summary>
/// <typeparam name="TBuilder">The TBuilder type.</typeparam>
public abstract class ResponsiveUtilityBuilder<TBuilder> : CssBuilderBase<TBuilder> where TBuilder : ResponsiveUtilityBuilder<TBuilder>
{
    protected readonly List<UtilityRule> Rules = new(4);
    private UtilityRule[]? _cachedRules;
    private string? _cachedClass;
    private BreakpointType? _pendingBreakpoint;

    protected ResponsiveUtilityBuilder()
    {
    }

    protected ResponsiveUtilityBuilder(string prefix, string value, BreakpointType? breakpoint = null)
    {
        _ = prefix;

        if (value.Length != 0)
            Rules.Add(new UtilityRule(value, breakpoint));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected TBuilder ChainValue(string value)
    {
        Rules.Add(new UtilityRule(value, ConsumePendingBreakpoint(), ConsumePendingModifierChain()));
        return (TBuilder)this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected TBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return (TBuilder)this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    public override string ToClass()
    {
        // Derived builders can mutate the protected list directly. Compare its exact
        // contents so replacements and removals invalidate the serialized value too.
        if (_cachedClass is not null && _cachedRules is not null && _cachedRules.Length == Rules.Count)
        {
            bool equal = true;
            for (int i = 0; i < Rules.Count; i++)
                if (_cachedRules[i] != Rules[i]) { equal = false; break; }
            if (equal) return _cachedClass;
        }
        _cachedRules = Rules.ToArray();
        return _cachedClass = BuildClass();
    }

    private string BuildClass()
    {
        if (Rules.Count == 0)
            return string.Empty;
        if (Rules.Count == 1)
        {
            UtilityRule rule = Rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < Rules.Count; i++)
            {
                UtilityRule rule = Rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }


    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
