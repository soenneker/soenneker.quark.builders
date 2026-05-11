namespace Soenneker.Quark;

/// <summary>
/// Background color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
public static class BackgroundColor
{
    public static BackgroundColorBuilder OnHover => new BackgroundColorBuilder().OnHover;
    public static BackgroundColorBuilder OnFocus => new BackgroundColorBuilder().OnFocus;
    public static BackgroundColorBuilder OnFocusVisible => new BackgroundColorBuilder().OnFocusVisible;
    public static BackgroundColorBuilder OnActive => new BackgroundColorBuilder().OnActive;
    public static BackgroundColorBuilder OnDisabled => new BackgroundColorBuilder().OnDisabled;
    public static BackgroundColorBuilder OnDark => new BackgroundColorBuilder().OnDark;
    public static BackgroundColorBuilder OnVisited => new BackgroundColorBuilder().OnVisited;
    public static BackgroundColorBuilder OnChecked => new BackgroundColorBuilder().OnChecked;
    public static BackgroundColorBuilder OnOpen => new BackgroundColorBuilder().OnOpen;
    public static BackgroundColorBuilder OnFirst => new BackgroundColorBuilder().OnFirst;
    public static BackgroundColorBuilder OnLast => new BackgroundColorBuilder().OnLast;
    public static BackgroundColorBuilder OnOdd => new BackgroundColorBuilder().OnOdd;
    public static BackgroundColorBuilder OnEven => new BackgroundColorBuilder().OnEven;
    public static BackgroundColorBuilder OnBefore => new BackgroundColorBuilder().OnBefore;
    public static BackgroundColorBuilder OnAfter => new BackgroundColorBuilder().OnAfter;
    public static BackgroundColorBuilder OnPlaceholder => new BackgroundColorBuilder().OnPlaceholder;
    public static BackgroundColorBuilder OnSelection => new BackgroundColorBuilder().OnSelection;
    public static BackgroundColorBuilder OnMarker => new BackgroundColorBuilder().OnMarker;
    public static BackgroundColorBuilder OnFirstLetter => new BackgroundColorBuilder().OnFirstLetter;
    public static BackgroundColorBuilder OnFirstLine => new BackgroundColorBuilder().OnFirstLine;
    public static BackgroundColorBuilder OnFile => new BackgroundColorBuilder().OnFile;
    public static BackgroundColorBuilder OnBackdrop => new BackgroundColorBuilder().OnBackdrop;
    public static BackgroundColorBuilder OnGroupHover => new BackgroundColorBuilder().OnGroupHover;
    public static BackgroundColorBuilder OnGroupFocus => new BackgroundColorBuilder().OnGroupFocus;
    public static BackgroundColorBuilder OnPeerHover => new BackgroundColorBuilder().OnPeerHover;
    public static BackgroundColorBuilder OnPeerFocus => new BackgroundColorBuilder().OnPeerFocus;

    public static BackgroundColorBuilder Primary => new(BackgroundColorEnum.Primary);
    public static BackgroundColorBuilder Secondary => new(BackgroundColorEnum.Secondary);
    public static BackgroundColorBuilder Destructive => new(BackgroundColorEnum.Destructive);
    public static BackgroundColorBuilder Muted => new(BackgroundColorEnum.Muted);
    public static BackgroundColorBuilder Accent => new(BackgroundColorEnum.Accent);
    public static BackgroundColorBuilder Popover => new(BackgroundColorEnum.Popover);
    public static BackgroundColorBuilder Card => new(BackgroundColorEnum.Card);
    public static BackgroundColorBuilder Background => new(BackgroundColorEnum.Background);
    public static BackgroundColorBuilder Foreground => new(BackgroundColorEnum.Foreground);
    public static BackgroundColorBuilder White => new(BackgroundColorEnum.White);
    public static BackgroundColorBuilder Black => new(BackgroundColorEnum.Black);
    public static BackgroundColorBuilder Transparent => new(BackgroundColorEnum.Transparent);

    /// <summary>
    /// Creates a background color builder from a Tailwind color token suffix such as <c>primary/20</c>, <c>zinc-900</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    public static BackgroundColorBuilder Token(string token) => new(token);

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>bg-primary/20</c>.
    /// </summary>
    public static BackgroundColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("bg-", utility));
}
