namespace Soenneker.Quark;

public static class OutlineOffset
{
    public static OutlineOffsetBuilder OnHover => new OutlineOffsetBuilder().OnHover;
    public static OutlineOffsetBuilder OnFocus => new OutlineOffsetBuilder().OnFocus;
    public static OutlineOffsetBuilder OnFocusVisible => new OutlineOffsetBuilder().OnFocusVisible;
    public static OutlineOffsetBuilder OnActive => new OutlineOffsetBuilder().OnActive;
    public static OutlineOffsetBuilder OnDisabled => new OutlineOffsetBuilder().OnDisabled;
    public static OutlineOffsetBuilder OnDark => new OutlineOffsetBuilder().OnDark;
    public static OutlineOffsetBuilder OnVisited => new OutlineOffsetBuilder().OnVisited;
    public static OutlineOffsetBuilder OnChecked => new OutlineOffsetBuilder().OnChecked;
    public static OutlineOffsetBuilder OnOpen => new OutlineOffsetBuilder().OnOpen;
    public static OutlineOffsetBuilder OnFirst => new OutlineOffsetBuilder().OnFirst;
    public static OutlineOffsetBuilder OnLast => new OutlineOffsetBuilder().OnLast;
    public static OutlineOffsetBuilder OnOdd => new OutlineOffsetBuilder().OnOdd;
    public static OutlineOffsetBuilder OnEven => new OutlineOffsetBuilder().OnEven;
    public static OutlineOffsetBuilder OnBefore => new OutlineOffsetBuilder().OnBefore;
    public static OutlineOffsetBuilder OnAfter => new OutlineOffsetBuilder().OnAfter;
    public static OutlineOffsetBuilder OnPlaceholder => new OutlineOffsetBuilder().OnPlaceholder;
    public static OutlineOffsetBuilder OnSelection => new OutlineOffsetBuilder().OnSelection;
    public static OutlineOffsetBuilder OnMarker => new OutlineOffsetBuilder().OnMarker;
    public static OutlineOffsetBuilder OnFirstLetter => new OutlineOffsetBuilder().OnFirstLetter;
    public static OutlineOffsetBuilder OnFirstLine => new OutlineOffsetBuilder().OnFirstLine;
    public static OutlineOffsetBuilder OnFile => new OutlineOffsetBuilder().OnFile;
    public static OutlineOffsetBuilder OnBackdrop => new OutlineOffsetBuilder().OnBackdrop;
    public static OutlineOffsetBuilder OnGroupHover => new OutlineOffsetBuilder().OnGroupHover;
    public static OutlineOffsetBuilder OnGroupFocus => new OutlineOffsetBuilder().OnGroupFocus;
    public static OutlineOffsetBuilder OnPeerHover => new OutlineOffsetBuilder().OnPeerHover;
    public static OutlineOffsetBuilder OnPeerFocus => new OutlineOffsetBuilder().OnPeerFocus;
    public static OutlineOffsetBuilder Is0 => new(OutlineOffsetEnum.Is0);
    public static OutlineOffsetBuilder Is1 => new(OutlineOffsetEnum.Is1);
    public static OutlineOffsetBuilder Is2 => new(OutlineOffsetEnum.Is2);
    public static OutlineOffsetBuilder Is4 => new(OutlineOffsetEnum.Is4);
    public static OutlineOffsetBuilder Is8 => new(OutlineOffsetEnum.Is8);
    public static OutlineOffsetBuilder Token(string value) => new("outline-offset-" + value);
}
