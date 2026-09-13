using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

// Delay acquiring a buffer until there is more than one nonempty rule.
internal ref struct ClassWriter
{
    private PooledStringBuilder _buffer;
    private string? _first;
    private string? _breakpoint;
    private string? _modifiers;
    private bool _breakpointPerToken;
    private bool _hasBuffer;

    public void Add(string value, string breakpoint = "", string? modifiers = null, bool breakpointPerToken = false)
    {
        if (value.Length == 0)
            return;

        if (_first is null)
        {
            _first = value;
            _breakpoint = breakpoint;
            _modifiers = modifiers;
            _breakpointPerToken = breakpointPerToken;
            return;
        }

        if (!_hasBuffer)
        {
            _buffer = new PooledStringBuilder();
            _hasBuffer = true;
            Append(_first, _breakpoint!, _modifiers, _breakpointPerToken);
        }

        _buffer.Append(' ');
        Append(value, breakpoint, modifiers, breakpointPerToken);
    }

    private void Append(string value, string breakpoint, string? modifiers, bool breakpointPerToken)
    {
        if (breakpoint.Length == 0)
        {
            if (string.IsNullOrEmpty(modifiers))
                _buffer.Append(value);
            else
                BreakpointUtil.AppendClassGroupWithModifierChain(ref _buffer, value, modifiers);
            return;
        }

        if (breakpointPerToken)
        {
            BreakpointUtil.AppendClassGroupWithModifierChain(ref _buffer, value, modifiers, breakpoint);
        }
        else if (string.IsNullOrEmpty(modifiers))
        {
            _buffer.Append(breakpoint);
            _buffer.Append(':');
            _buffer.Append(value);
        }
        else
        {
            // Legacy breakpoint APIs prefix the entire group, while modifiers
            // prefix each token. Preserve that distinction for custom groups.
            BreakpointUtil.AppendClassGroupWithModifierChain(ref _buffer,
                BreakpointUtil.ApplyTailwindBreakpoint(value, breakpoint), modifiers);
        }
    }

    public override string ToString()
    {
        if (_hasBuffer)
            return _buffer.ToString();
        if (_first is null)
            return string.Empty;

        return Render(_first, _breakpoint!, _modifiers, _breakpointPerToken);
    }

    public static string Render(string value, string breakpoint = "", string? modifiers = null, bool breakpointPerToken = false)
    {
        if (value.Length == 0)
            return string.Empty;
        if (breakpoint.Length != 0)
            value = breakpointPerToken
                ? BreakpointUtil.ApplyTailwindModifiers(value, breakpoint)
                : BreakpointUtil.ApplyTailwindBreakpoint(value, breakpoint);
        return string.IsNullOrEmpty(modifiers) ? value : BreakpointUtil.ApplyTailwindModifiers(value, modifiers);
    }

    public void Dispose()
    {
        if (_hasBuffer)
            _buffer.Dispose();
    }
}
