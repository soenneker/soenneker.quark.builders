namespace Soenneker.Quark;

public static class Rotate
{
    public static RotateBuilder OnHover => new RotateBuilder().OnHover;
    public static RotateBuilder OnFocus => new RotateBuilder().OnFocus;
    public static RotateBuilder OnFocusVisible => new RotateBuilder().OnFocusVisible;
    public static RotateBuilder OnActive => new RotateBuilder().OnActive;
    public static RotateBuilder OnDisabled => new RotateBuilder().OnDisabled;
    public static RotateBuilder OnDark => new RotateBuilder().OnDark;
    public static RotateBuilder OnVisited => new RotateBuilder().OnVisited;
    public static RotateBuilder OnChecked => new RotateBuilder().OnChecked;
    public static RotateBuilder OnOpen => new RotateBuilder().OnOpen;
    public static RotateBuilder OnFirst => new RotateBuilder().OnFirst;
    public static RotateBuilder OnLast => new RotateBuilder().OnLast;
    public static RotateBuilder OnOdd => new RotateBuilder().OnOdd;
    public static RotateBuilder OnEven => new RotateBuilder().OnEven;
    public static RotateBuilder OnBefore => new RotateBuilder().OnBefore;
    public static RotateBuilder OnAfter => new RotateBuilder().OnAfter;
    public static RotateBuilder OnPlaceholder => new RotateBuilder().OnPlaceholder;
    public static RotateBuilder OnSelection => new RotateBuilder().OnSelection;
    public static RotateBuilder OnMarker => new RotateBuilder().OnMarker;
    public static RotateBuilder OnFirstLetter => new RotateBuilder().OnFirstLetter;
    public static RotateBuilder OnFirstLine => new RotateBuilder().OnFirstLine;
    public static RotateBuilder OnFile => new RotateBuilder().OnFile;
    public static RotateBuilder OnBackdrop => new RotateBuilder().OnBackdrop;
    public static RotateBuilder OnGroupHover => new RotateBuilder().OnGroupHover;
    public static RotateBuilder OnGroupFocus => new RotateBuilder().OnGroupFocus;
    public static RotateBuilder OnPeerHover => new RotateBuilder().OnPeerHover;
    public static RotateBuilder OnPeerFocus => new RotateBuilder().OnPeerFocus;
    public static RotateBuilder Is0 => new(RotateEnum.Is0);
    public static RotateBuilder Is1 => new(RotateEnum.Is1);
    public static RotateBuilder Is2 => new(RotateEnum.Is2);
    public static RotateBuilder Is3 => new(RotateEnum.Is3);
    public static RotateBuilder Is6 => new(RotateEnum.Is6);
    public static RotateBuilder Is12 => new(RotateEnum.Is12);
    public static RotateBuilder Is45 => new(RotateEnum.Is45);
    public static RotateBuilder Is90 => new(RotateEnum.Is90);
    public static RotateBuilder Is180 => new(RotateEnum.Is180);
    public static RotateBuilder Token(string value) => new("rotate-" + value);
}
