using System;

namespace Soenneker.Quark;

// Tailwind class groups use all Unicode whitespace as separators, matching the
// existing modifier APIs. Return ranges so no substring or token array is needed.
internal ref struct ClassTokens(ReadOnlySpan<char> value)
{
    private readonly ReadOnlySpan<char> _value = value;
    private int _position;
    public Range Current { get; private set; }

    public readonly ClassTokens GetEnumerator() => this;

    public bool MoveNext()
    {
        int start = _position;
        while (start < _value.Length && char.IsWhiteSpace(_value[start]))
            start++;
        if (start == _value.Length)
            return false;
        int end = start + 1;
        while (end < _value.Length && !char.IsWhiteSpace(_value[end]))
            end++;
        Current = start..end;
        _position = end;
        return true;
    }
}
