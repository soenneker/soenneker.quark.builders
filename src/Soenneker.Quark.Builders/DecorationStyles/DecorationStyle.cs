namespace Soenneker.Quark;

public static class DecorationStyle
{
    public static DecorationStyleBuilder OnHover => new DecorationStyleBuilder().OnHover;
    public static DecorationStyleBuilder OnFocus => new DecorationStyleBuilder().OnFocus;
    public static DecorationStyleBuilder OnFocusVisible => new DecorationStyleBuilder().OnFocusVisible;
    public static DecorationStyleBuilder OnActive => new DecorationStyleBuilder().OnActive;
    public static DecorationStyleBuilder OnDisabled => new DecorationStyleBuilder().OnDisabled;
    public static DecorationStyleBuilder OnDark => new DecorationStyleBuilder().OnDark;
    public static DecorationStyleBuilder OnVisited => new DecorationStyleBuilder().OnVisited;
    public static DecorationStyleBuilder OnChecked => new DecorationStyleBuilder().OnChecked;
    public static DecorationStyleBuilder OnOpen => new DecorationStyleBuilder().OnOpen;
    public static DecorationStyleBuilder OnFirst => new DecorationStyleBuilder().OnFirst;
    public static DecorationStyleBuilder OnLast => new DecorationStyleBuilder().OnLast;
    public static DecorationStyleBuilder OnOdd => new DecorationStyleBuilder().OnOdd;
    public static DecorationStyleBuilder OnEven => new DecorationStyleBuilder().OnEven;
    public static DecorationStyleBuilder OnBefore => new DecorationStyleBuilder().OnBefore;
    public static DecorationStyleBuilder OnAfter => new DecorationStyleBuilder().OnAfter;
    public static DecorationStyleBuilder OnPlaceholder => new DecorationStyleBuilder().OnPlaceholder;
    public static DecorationStyleBuilder OnSelection => new DecorationStyleBuilder().OnSelection;
    public static DecorationStyleBuilder OnMarker => new DecorationStyleBuilder().OnMarker;
    public static DecorationStyleBuilder OnFirstLetter => new DecorationStyleBuilder().OnFirstLetter;
    public static DecorationStyleBuilder OnFirstLine => new DecorationStyleBuilder().OnFirstLine;
    public static DecorationStyleBuilder OnFile => new DecorationStyleBuilder().OnFile;
    public static DecorationStyleBuilder OnBackdrop => new DecorationStyleBuilder().OnBackdrop;
    public static DecorationStyleBuilder OnGroupHover => new DecorationStyleBuilder().OnGroupHover;
    public static DecorationStyleBuilder OnGroupFocus => new DecorationStyleBuilder().OnGroupFocus;
    public static DecorationStyleBuilder OnPeerHover => new DecorationStyleBuilder().OnPeerHover;
    public static DecorationStyleBuilder OnPeerFocus => new DecorationStyleBuilder().OnPeerFocus;
    public static DecorationStyleBuilder Solid => new(DecorationStyleEnum.Solid);
    public static DecorationStyleBuilder Double => new(DecorationStyleEnum.Double);
    public static DecorationStyleBuilder Dotted => new(DecorationStyleEnum.Dotted);
    public static DecorationStyleBuilder Dashed => new(DecorationStyleEnum.Dashed);
    public static DecorationStyleBuilder Wavy => new(DecorationStyleEnum.Wavy);
    public static DecorationStyleBuilder Token(string value) => new("decoration-" + value);
}
