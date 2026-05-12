namespace Soenneker.Quark;

/// <summary>
/// Represents a single Tailwind/shadcn rounded rule.
/// </summary>
/// <param name="SizeToken">
/// Rounded size token (null = default 'rounded').
/// Examples: sm, md, lg, xl, 2xl, 3xl, full, none.
/// </param>
/// <param name="Position">
/// Position token (all = no suffix).
/// Examples: t, b, l, r, tl, tr, bl, br.
/// </param>
/// <param name="Breakpoint">
/// Optional responsive breakpoint.
/// </param>
/// <param name="ModifierChain">
/// Optional Tailwind modifier chain.
/// </param>
internal readonly record struct RoundedRule(string? SizeToken, RoundedPositionEnum Position, BreakpointType? Breakpoint = null, string? ModifierChain = null);
