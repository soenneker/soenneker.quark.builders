
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified animation builder with fluent API for chaining animation rules.
/// </summary>
[TailwindPrefix("animate-", Responsive = true)]
public sealed class AnimationBuilder : CssBuilderBase<AnimationBuilder>
{
    private RuleList<AnimationRule> _rules;

    internal AnimationBuilder()
    {
    }

    internal AnimationBuilder(AnimationEnum animation, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AnimationRule(animation.Value, breakpoint));
    }

    internal AnimationBuilder(string animation, BreakpointType? breakpoint = null)
    {
        _rules.Add(new AnimationRule(animation, breakpoint));
    }

    internal AnimationBuilder(List<AnimationRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the animation to none.
    /// </summary>
    public AnimationBuilder None => ChainWithAnimation(AnimationEnum.None);

    /// <summary>
    /// Sets the animation to spin.
    /// </summary>
    public AnimationBuilder Spin => ChainWithAnimation(AnimationEnum.Spin);

    /// <summary>
    /// Sets the animation to ping.
    /// </summary>
    public AnimationBuilder Ping => ChainWithAnimation(AnimationEnum.Ping);

    /// <summary>
    /// Sets the animation to pulse.
    /// </summary>
    public AnimationBuilder Pulse => ChainWithAnimation(AnimationEnum.Pulse);

    /// <summary>
    /// Sets the animation to bounce.
    /// </summary>
    public AnimationBuilder Bounce => ChainWithAnimation(AnimationEnum.Bounce);

    /// <summary>
    /// Applies an exact Tailwind animation utility token, e.g. "animate-in".
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public AnimationBuilder Token(string token) => ChainWithAnimation(token);







    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AnimationBuilder ChainWithAnimation(AnimationEnum animation)
    {
        return ChainWithAnimation(animation.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private AnimationBuilder ChainWithAnimation(string animation)
    {
        BreakpointType? bp = null;
        _rules.Add(new AnimationRule(animation, bp, ConsumePendingModifierChain()));
        return this;
    }


    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            AnimationRule rule = _rules[0];
            return ClassWriter.Render(rule.Animation, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                AnimationRule rule = _rules[i];
                writer.Add(rule.Animation, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns the CSS class string representation of this animation builder.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToString()
    {
        return ToClass();
    }
}
