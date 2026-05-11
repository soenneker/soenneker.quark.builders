namespace Soenneker.Quark;

public static class UnderlineOffset
{
    public static UnderlineOffsetBuilder OnHover => new UnderlineOffsetBuilder().OnHover;
    public static UnderlineOffsetBuilder OnFocus => new UnderlineOffsetBuilder().OnFocus;
    public static UnderlineOffsetBuilder OnFocusVisible => new UnderlineOffsetBuilder().OnFocusVisible;
    public static UnderlineOffsetBuilder OnActive => new UnderlineOffsetBuilder().OnActive;
    public static UnderlineOffsetBuilder OnDisabled => new UnderlineOffsetBuilder().OnDisabled;
    public static UnderlineOffsetBuilder OnDark => new UnderlineOffsetBuilder().OnDark;
    public static UnderlineOffsetBuilder OnVisited => new UnderlineOffsetBuilder().OnVisited;
    public static UnderlineOffsetBuilder OnChecked => new UnderlineOffsetBuilder().OnChecked;
    public static UnderlineOffsetBuilder OnOpen => new UnderlineOffsetBuilder().OnOpen;
    public static UnderlineOffsetBuilder OnFirst => new UnderlineOffsetBuilder().OnFirst;
    public static UnderlineOffsetBuilder OnLast => new UnderlineOffsetBuilder().OnLast;
    public static UnderlineOffsetBuilder OnOdd => new UnderlineOffsetBuilder().OnOdd;
    public static UnderlineOffsetBuilder OnEven => new UnderlineOffsetBuilder().OnEven;
    public static UnderlineOffsetBuilder OnBefore => new UnderlineOffsetBuilder().OnBefore;
    public static UnderlineOffsetBuilder OnAfter => new UnderlineOffsetBuilder().OnAfter;
    public static UnderlineOffsetBuilder OnPlaceholder => new UnderlineOffsetBuilder().OnPlaceholder;
    public static UnderlineOffsetBuilder OnSelection => new UnderlineOffsetBuilder().OnSelection;
    public static UnderlineOffsetBuilder OnMarker => new UnderlineOffsetBuilder().OnMarker;
    public static UnderlineOffsetBuilder OnFirstLetter => new UnderlineOffsetBuilder().OnFirstLetter;
    public static UnderlineOffsetBuilder OnFirstLine => new UnderlineOffsetBuilder().OnFirstLine;
    public static UnderlineOffsetBuilder OnFile => new UnderlineOffsetBuilder().OnFile;
    public static UnderlineOffsetBuilder OnBackdrop => new UnderlineOffsetBuilder().OnBackdrop;
    public static UnderlineOffsetBuilder OnGroupHover => new UnderlineOffsetBuilder().OnGroupHover;
    public static UnderlineOffsetBuilder OnGroupFocus => new UnderlineOffsetBuilder().OnGroupFocus;
    public static UnderlineOffsetBuilder OnPeerHover => new UnderlineOffsetBuilder().OnPeerHover;
    public static UnderlineOffsetBuilder OnPeerFocus => new UnderlineOffsetBuilder().OnPeerFocus;
    public static UnderlineOffsetBuilder Auto => new(UnderlineOffsetEnum.Auto);
    public static UnderlineOffsetBuilder Is0 => new(UnderlineOffsetEnum.Is0);
    public static UnderlineOffsetBuilder Is1 => new(UnderlineOffsetEnum.Is1);
    public static UnderlineOffsetBuilder Is2 => new(UnderlineOffsetEnum.Is2);
    public static UnderlineOffsetBuilder Is4 => new(UnderlineOffsetEnum.Is4);
    public static UnderlineOffsetBuilder Is8 => new(UnderlineOffsetEnum.Is8);
    public static UnderlineOffsetBuilder Token(string value) => new("underline-offset-" + value);
}
