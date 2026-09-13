using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

// Most fluent builders contain one rule. Keep it inside the builder and allocate
// overflow storage only when a second rule is added. Never pool retained state.
internal struct RuleList<T>
{
    private T _first;
    private T[]? _remaining;
    public int Count { get; private set; }

    public T this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if ((uint)index >= (uint)Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            return index == 0 ? _first : _remaining![index - 1];
        }
        set
        {
            if ((uint)index >= (uint)Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            if (index == 0)
                _first = value;
            else
                _remaining![index - 1] = value;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add(T value)
    {
        if (Count == 0)
            _first = value;
        else
        {
            int index = Count - 1;
            if (_remaining is null)
                _remaining = new T[3];
            else if (index == _remaining.Length)
                Array.Resize(ref _remaining, checked(_remaining.Length * 2 + 1));
            _remaining[index] = value;
        }
        Count++;
    }

    public void AddRange(List<T> values)
    {
        if (values.Count == 0)
            return;
        int start = 0;
        if (Count == 0)
        {
            _first = values[0];
            Count = 1;
            start = 1;
        }
        int additional = values.Count - start;
        if (additional == 0)
            return;
        int required = checked(Count - 1 + additional);
        if (_remaining is null || _remaining.Length < required)
            Array.Resize(ref _remaining, Math.Max(3, required));
        values.CopyTo(start, _remaining!, Count - 1, additional);
        Count += additional;
    }

}
