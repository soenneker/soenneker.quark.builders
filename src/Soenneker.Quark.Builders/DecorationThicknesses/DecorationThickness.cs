namespace Soenneker.Quark;

public static class DecorationThickness
{
    public static DecorationThicknessBuilder OnHover => new DecorationThicknessBuilder().OnHover;
    public static DecorationThicknessBuilder OnFocus => new DecorationThicknessBuilder().OnFocus;
    public static DecorationThicknessBuilder OnFocusVisible => new DecorationThicknessBuilder().OnFocusVisible;
    public static DecorationThicknessBuilder OnActive => new DecorationThicknessBuilder().OnActive;
    public static DecorationThicknessBuilder OnDisabled => new DecorationThicknessBuilder().OnDisabled;
    public static DecorationThicknessBuilder OnDark => new DecorationThicknessBuilder().OnDark;
    public static DecorationThicknessBuilder OnVisited => new DecorationThicknessBuilder().OnVisited;
    public static DecorationThicknessBuilder OnChecked => new DecorationThicknessBuilder().OnChecked;
    public static DecorationThicknessBuilder OnOpen => new DecorationThicknessBuilder().OnOpen;
    public static DecorationThicknessBuilder OnFirst => new DecorationThicknessBuilder().OnFirst;
    public static DecorationThicknessBuilder OnLast => new DecorationThicknessBuilder().OnLast;
    public static DecorationThicknessBuilder OnOdd => new DecorationThicknessBuilder().OnOdd;
    public static DecorationThicknessBuilder OnEven => new DecorationThicknessBuilder().OnEven;
    public static DecorationThicknessBuilder OnBefore => new DecorationThicknessBuilder().OnBefore;
    public static DecorationThicknessBuilder OnAfter => new DecorationThicknessBuilder().OnAfter;
    public static DecorationThicknessBuilder OnPlaceholder => new DecorationThicknessBuilder().OnPlaceholder;
    public static DecorationThicknessBuilder OnSelection => new DecorationThicknessBuilder().OnSelection;
    public static DecorationThicknessBuilder OnMarker => new DecorationThicknessBuilder().OnMarker;
    public static DecorationThicknessBuilder OnFirstLetter => new DecorationThicknessBuilder().OnFirstLetter;
    public static DecorationThicknessBuilder OnFirstLine => new DecorationThicknessBuilder().OnFirstLine;
    public static DecorationThicknessBuilder OnFile => new DecorationThicknessBuilder().OnFile;
    public static DecorationThicknessBuilder OnBackdrop => new DecorationThicknessBuilder().OnBackdrop;
    public static DecorationThicknessBuilder OnGroupHover => new DecorationThicknessBuilder().OnGroupHover;
    public static DecorationThicknessBuilder OnGroupFocus => new DecorationThicknessBuilder().OnGroupFocus;
    public static DecorationThicknessBuilder OnPeerHover => new DecorationThicknessBuilder().OnPeerHover;
    public static DecorationThicknessBuilder OnPeerFocus => new DecorationThicknessBuilder().OnPeerFocus;
    public static DecorationThicknessBuilder Auto => new(DecorationThicknessEnum.Auto);
    public static DecorationThicknessBuilder FromFont => new(DecorationThicknessEnum.FromFont);
    public static DecorationThicknessBuilder Is0 => new(DecorationThicknessEnum.Is0);
    public static DecorationThicknessBuilder Is1 => new(DecorationThicknessEnum.Is1);
    public static DecorationThicknessBuilder Is2 => new(DecorationThicknessEnum.Is2);
    public static DecorationThicknessBuilder Is4 => new(DecorationThicknessEnum.Is4);
    public static DecorationThicknessBuilder Is8 => new(DecorationThicknessEnum.Is8);
    public static DecorationThicknessBuilder Token(string value) => new("decoration-" + value);
}
