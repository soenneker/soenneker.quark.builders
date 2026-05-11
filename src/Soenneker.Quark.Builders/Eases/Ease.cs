namespace Soenneker.Quark;

public static class Ease
{
    public static EaseBuilder OnHover => new EaseBuilder().OnHover;
    public static EaseBuilder OnFocus => new EaseBuilder().OnFocus;
    public static EaseBuilder OnFocusVisible => new EaseBuilder().OnFocusVisible;
    public static EaseBuilder OnActive => new EaseBuilder().OnActive;
    public static EaseBuilder OnDisabled => new EaseBuilder().OnDisabled;
    public static EaseBuilder OnDark => new EaseBuilder().OnDark;
    public static EaseBuilder OnVisited => new EaseBuilder().OnVisited;
    public static EaseBuilder OnChecked => new EaseBuilder().OnChecked;
    public static EaseBuilder OnOpen => new EaseBuilder().OnOpen;
    public static EaseBuilder OnFirst => new EaseBuilder().OnFirst;
    public static EaseBuilder OnLast => new EaseBuilder().OnLast;
    public static EaseBuilder OnOdd => new EaseBuilder().OnOdd;
    public static EaseBuilder OnEven => new EaseBuilder().OnEven;
    public static EaseBuilder OnBefore => new EaseBuilder().OnBefore;
    public static EaseBuilder OnAfter => new EaseBuilder().OnAfter;
    public static EaseBuilder OnPlaceholder => new EaseBuilder().OnPlaceholder;
    public static EaseBuilder OnSelection => new EaseBuilder().OnSelection;
    public static EaseBuilder OnMarker => new EaseBuilder().OnMarker;
    public static EaseBuilder OnFirstLetter => new EaseBuilder().OnFirstLetter;
    public static EaseBuilder OnFirstLine => new EaseBuilder().OnFirstLine;
    public static EaseBuilder OnFile => new EaseBuilder().OnFile;
    public static EaseBuilder OnBackdrop => new EaseBuilder().OnBackdrop;
    public static EaseBuilder OnGroupHover => new EaseBuilder().OnGroupHover;
    public static EaseBuilder OnGroupFocus => new EaseBuilder().OnGroupFocus;
    public static EaseBuilder OnPeerHover => new EaseBuilder().OnPeerHover;
    public static EaseBuilder OnPeerFocus => new EaseBuilder().OnPeerFocus;
    public static EaseBuilder Linear => new(EaseEnum.Linear);
    public static EaseBuilder In => new(EaseEnum.In);
    public static EaseBuilder Out => new(EaseEnum.Out);
    public static EaseBuilder InOut => new(EaseEnum.InOut);
    public static EaseBuilder Token(string value) => new("ease-" + value);
}
