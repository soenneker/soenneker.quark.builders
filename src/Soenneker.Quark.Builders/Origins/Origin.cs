namespace Soenneker.Quark;

public static class Origin
{
    public static OriginBuilder OnHover => new OriginBuilder().OnHover;
    public static OriginBuilder OnFocus => new OriginBuilder().OnFocus;
    public static OriginBuilder OnFocusVisible => new OriginBuilder().OnFocusVisible;
    public static OriginBuilder OnActive => new OriginBuilder().OnActive;
    public static OriginBuilder OnDisabled => new OriginBuilder().OnDisabled;
    public static OriginBuilder OnDark => new OriginBuilder().OnDark;
    public static OriginBuilder OnVisited => new OriginBuilder().OnVisited;
    public static OriginBuilder OnChecked => new OriginBuilder().OnChecked;
    public static OriginBuilder OnOpen => new OriginBuilder().OnOpen;
    public static OriginBuilder OnFirst => new OriginBuilder().OnFirst;
    public static OriginBuilder OnLast => new OriginBuilder().OnLast;
    public static OriginBuilder OnOdd => new OriginBuilder().OnOdd;
    public static OriginBuilder OnEven => new OriginBuilder().OnEven;
    public static OriginBuilder OnBefore => new OriginBuilder().OnBefore;
    public static OriginBuilder OnAfter => new OriginBuilder().OnAfter;
    public static OriginBuilder OnPlaceholder => new OriginBuilder().OnPlaceholder;
    public static OriginBuilder OnSelection => new OriginBuilder().OnSelection;
    public static OriginBuilder OnMarker => new OriginBuilder().OnMarker;
    public static OriginBuilder OnFirstLetter => new OriginBuilder().OnFirstLetter;
    public static OriginBuilder OnFirstLine => new OriginBuilder().OnFirstLine;
    public static OriginBuilder OnFile => new OriginBuilder().OnFile;
    public static OriginBuilder OnBackdrop => new OriginBuilder().OnBackdrop;
    public static OriginBuilder OnGroupHover => new OriginBuilder().OnGroupHover;
    public static OriginBuilder OnGroupFocus => new OriginBuilder().OnGroupFocus;
    public static OriginBuilder OnPeerHover => new OriginBuilder().OnPeerHover;
    public static OriginBuilder OnPeerFocus => new OriginBuilder().OnPeerFocus;
    public static OriginBuilder Center => new(OriginEnum.Center);
    public static OriginBuilder Top => new(OriginEnum.Top);
    public static OriginBuilder TopRight => new(OriginEnum.TopRight);
    public static OriginBuilder Right => new(OriginEnum.Right);
    public static OriginBuilder BottomRight => new(OriginEnum.BottomRight);
    public static OriginBuilder Bottom => new(OriginEnum.Bottom);
    public static OriginBuilder BottomLeft => new(OriginEnum.BottomLeft);
    public static OriginBuilder Left => new(OriginEnum.Left);
    public static OriginBuilder TopLeft => new(OriginEnum.TopLeft);
    public static OriginBuilder Token(string value) => new("origin-" + value);
}
