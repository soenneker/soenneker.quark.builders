namespace Soenneker.Quark;

public static class DecorationLine
{
    public static DecorationLineBuilder OnHover => new DecorationLineBuilder().OnHover;
    public static DecorationLineBuilder OnFocus => new DecorationLineBuilder().OnFocus;
    public static DecorationLineBuilder OnFocusVisible => new DecorationLineBuilder().OnFocusVisible;
    public static DecorationLineBuilder OnActive => new DecorationLineBuilder().OnActive;
    public static DecorationLineBuilder OnDisabled => new DecorationLineBuilder().OnDisabled;
    public static DecorationLineBuilder OnDark => new DecorationLineBuilder().OnDark;
    public static DecorationLineBuilder OnVisited => new DecorationLineBuilder().OnVisited;
    public static DecorationLineBuilder OnChecked => new DecorationLineBuilder().OnChecked;
    public static DecorationLineBuilder OnOpen => new DecorationLineBuilder().OnOpen;
    public static DecorationLineBuilder OnFirst => new DecorationLineBuilder().OnFirst;
    public static DecorationLineBuilder OnLast => new DecorationLineBuilder().OnLast;
    public static DecorationLineBuilder OnOdd => new DecorationLineBuilder().OnOdd;
    public static DecorationLineBuilder OnEven => new DecorationLineBuilder().OnEven;
    public static DecorationLineBuilder OnBefore => new DecorationLineBuilder().OnBefore;
    public static DecorationLineBuilder OnAfter => new DecorationLineBuilder().OnAfter;
    public static DecorationLineBuilder OnPlaceholder => new DecorationLineBuilder().OnPlaceholder;
    public static DecorationLineBuilder OnSelection => new DecorationLineBuilder().OnSelection;
    public static DecorationLineBuilder OnMarker => new DecorationLineBuilder().OnMarker;
    public static DecorationLineBuilder OnFirstLetter => new DecorationLineBuilder().OnFirstLetter;
    public static DecorationLineBuilder OnFirstLine => new DecorationLineBuilder().OnFirstLine;
    public static DecorationLineBuilder OnFile => new DecorationLineBuilder().OnFile;
    public static DecorationLineBuilder OnBackdrop => new DecorationLineBuilder().OnBackdrop;
    public static DecorationLineBuilder OnGroupHover => new DecorationLineBuilder().OnGroupHover;
    public static DecorationLineBuilder OnGroupFocus => new DecorationLineBuilder().OnGroupFocus;
    public static DecorationLineBuilder OnPeerHover => new DecorationLineBuilder().OnPeerHover;
    public static DecorationLineBuilder OnPeerFocus => new DecorationLineBuilder().OnPeerFocus;
    public static DecorationLineBuilder None => new(DecorationLineEnum.None);
    public static DecorationLineBuilder Underline => new(DecorationLineEnum.Underline);
    public static DecorationLineBuilder LineThrough => new(DecorationLineEnum.LineThrough);
    public static DecorationLineBuilder Overline => new(DecorationLineEnum.Overline);
    public static DecorationLineBuilder Token(string value) => new(value);
}
