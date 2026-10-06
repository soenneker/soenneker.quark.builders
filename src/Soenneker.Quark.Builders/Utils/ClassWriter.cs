using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

// Delay acquiring a buffer until there is more than one nonempty rule.
internal ref struct ClassWriter
{
    private PooledStringBuilder _buffer;
    private string? _first;
    private string? _modifiers;
    private bool _hasBuffer;

    public void Add(string value, string breakpoint = "", string? modifiers = null)
    {
        if (value.Length == 0)
            return;

        if (_first is null)
        {
            _first = value;
            _modifiers = CombineModifiers(breakpoint, modifiers);
            return;
        }

        if (!_hasBuffer)
        {
            _buffer = new PooledStringBuilder();
            _hasBuffer = true;
            Append(_first, _modifiers);
        }

        _buffer.Append(' ');
        Append(value, CombineModifiers(breakpoint, modifiers));
    }

    private static string? CombineModifiers(string breakpoint, string? modifiers) =>
        breakpoint.Length == 0 ? modifiers : string.IsNullOrEmpty(modifiers) ? breakpoint : string.Concat(breakpoint, ":", modifiers);

    private void Append(string value, string? modifiers)
    {
        if (string.IsNullOrEmpty(modifiers))
            _buffer.Append(value);
        else
            BreakpointUtil.AppendClassGroupWithModifierChain(ref _buffer, value, modifiers);
    }

    public override string ToString()
    {
        if (_hasBuffer)
            return _buffer.ToString();
        if (_first is null)
            return string.Empty;

        return Render(_first, modifiers: _modifiers);
    }

    public static string Render(string value, string breakpoint = "", string? modifiers = null)
    {
        var chain = CombineModifiers(breakpoint, modifiers);
        return string.IsNullOrEmpty(chain) ? value : BreakpointUtil.ApplyTailwindModifiers(value, chain);
    }

    public void Dispose()
    {
        if (_hasBuffer)
            _buffer.Dispose();
    }
}
