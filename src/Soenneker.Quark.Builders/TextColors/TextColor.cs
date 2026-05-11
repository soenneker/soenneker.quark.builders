namespace Soenneker.Quark;

/// <summary>
/// Text color utility with fluent API aligned with shadcn/Tailwind semantic tokens.
/// </summary>
public static class TextColor
{
    public static TextColorBuilder OnHover => new TextColorBuilder().OnHover;
    public static TextColorBuilder OnFocus => new TextColorBuilder().OnFocus;
    public static TextColorBuilder OnFocusVisible => new TextColorBuilder().OnFocusVisible;
    public static TextColorBuilder OnActive => new TextColorBuilder().OnActive;
    public static TextColorBuilder OnDisabled => new TextColorBuilder().OnDisabled;
    public static TextColorBuilder OnDark => new TextColorBuilder().OnDark;
    public static TextColorBuilder OnVisited => new TextColorBuilder().OnVisited;
    public static TextColorBuilder OnChecked => new TextColorBuilder().OnChecked;
    public static TextColorBuilder OnOpen => new TextColorBuilder().OnOpen;
    public static TextColorBuilder OnFirst => new TextColorBuilder().OnFirst;
    public static TextColorBuilder OnLast => new TextColorBuilder().OnLast;
    public static TextColorBuilder OnOdd => new TextColorBuilder().OnOdd;
    public static TextColorBuilder OnEven => new TextColorBuilder().OnEven;
    public static TextColorBuilder OnBefore => new TextColorBuilder().OnBefore;
    public static TextColorBuilder OnAfter => new TextColorBuilder().OnAfter;
    public static TextColorBuilder OnPlaceholder => new TextColorBuilder().OnPlaceholder;
    public static TextColorBuilder OnSelection => new TextColorBuilder().OnSelection;
    public static TextColorBuilder OnMarker => new TextColorBuilder().OnMarker;
    public static TextColorBuilder OnFirstLetter => new TextColorBuilder().OnFirstLetter;
    public static TextColorBuilder OnFirstLine => new TextColorBuilder().OnFirstLine;
    public static TextColorBuilder OnFile => new TextColorBuilder().OnFile;
    public static TextColorBuilder OnBackdrop => new TextColorBuilder().OnBackdrop;
    public static TextColorBuilder OnGroupHover => new TextColorBuilder().OnGroupHover;
    public static TextColorBuilder OnGroupFocus => new TextColorBuilder().OnGroupFocus;
    public static TextColorBuilder OnPeerHover => new TextColorBuilder().OnPeerHover;
    public static TextColorBuilder OnPeerFocus => new TextColorBuilder().OnPeerFocus;

    public static TextColorBuilder Primary => new(TextColorEnum.Primary);
    public static TextColorBuilder PrimaryForeground => new(TextColorEnum.PrimaryForeground);
    public static TextColorBuilder Secondary => new(TextColorEnum.Secondary);
    public static TextColorBuilder SecondaryForeground => new(TextColorEnum.SecondaryForeground);
    public static TextColorBuilder Destructive => new(TextColorEnum.Destructive);
    public static TextColorBuilder DestructiveForeground => new(TextColorEnum.DestructiveForeground);
    public static TextColorBuilder MutedForeground => new(TextColorEnum.MutedForeground);
    public static TextColorBuilder Accent => new(TextColorEnum.Accent);
    public static TextColorBuilder AccentForeground => new(TextColorEnum.AccentForeground);
    public static TextColorBuilder PopoverForeground => new(TextColorEnum.PopoverForeground);
    public static TextColorBuilder CardForeground => new(TextColorEnum.CardForeground);
    public static TextColorBuilder Foreground => new(TextColorEnum.Foreground);
    public static TextColorBuilder White => new(TextColorEnum.White);
    public static TextColorBuilder Black => new(TextColorEnum.Black);

    /// <summary>
    /// Creates a text color builder from a Tailwind color token suffix such as <c>primary/80</c>, <c>zinc-700</c>, or <c>[var(--brand)]</c>.
    /// </summary>
    public static TextColorBuilder Token(string token) => new(token);

    /// <summary>
    /// Passes through a fully-prefixed Tailwind utility such as <c>text-primary/80</c>.
    /// </summary>
    public static TextColorBuilder Utility(string utility) => new(ColorUtility.CreateUtilityClass("text-", utility));
}
