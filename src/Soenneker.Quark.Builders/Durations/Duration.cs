namespace Soenneker.Quark;

public static class Duration
{
    public static DurationBuilder OnHover => new DurationBuilder().OnHover;
    public static DurationBuilder OnFocus => new DurationBuilder().OnFocus;
    public static DurationBuilder OnFocusVisible => new DurationBuilder().OnFocusVisible;
    public static DurationBuilder OnActive => new DurationBuilder().OnActive;
    public static DurationBuilder OnDisabled => new DurationBuilder().OnDisabled;
    public static DurationBuilder OnDark => new DurationBuilder().OnDark;
    public static DurationBuilder OnVisited => new DurationBuilder().OnVisited;
    public static DurationBuilder OnChecked => new DurationBuilder().OnChecked;
    public static DurationBuilder OnOpen => new DurationBuilder().OnOpen;
    public static DurationBuilder OnFirst => new DurationBuilder().OnFirst;
    public static DurationBuilder OnLast => new DurationBuilder().OnLast;
    public static DurationBuilder OnOdd => new DurationBuilder().OnOdd;
    public static DurationBuilder OnEven => new DurationBuilder().OnEven;
    public static DurationBuilder OnBefore => new DurationBuilder().OnBefore;
    public static DurationBuilder OnAfter => new DurationBuilder().OnAfter;
    public static DurationBuilder OnPlaceholder => new DurationBuilder().OnPlaceholder;
    public static DurationBuilder OnSelection => new DurationBuilder().OnSelection;
    public static DurationBuilder OnMarker => new DurationBuilder().OnMarker;
    public static DurationBuilder OnFirstLetter => new DurationBuilder().OnFirstLetter;
    public static DurationBuilder OnFirstLine => new DurationBuilder().OnFirstLine;
    public static DurationBuilder OnFile => new DurationBuilder().OnFile;
    public static DurationBuilder OnBackdrop => new DurationBuilder().OnBackdrop;
    public static DurationBuilder OnGroupHover => new DurationBuilder().OnGroupHover;
    public static DurationBuilder OnGroupFocus => new DurationBuilder().OnGroupFocus;
    public static DurationBuilder OnPeerHover => new DurationBuilder().OnPeerHover;
    public static DurationBuilder OnPeerFocus => new DurationBuilder().OnPeerFocus;
    public static DurationBuilder Is75 => new(DurationEnum.Is75);
    public static DurationBuilder Is100 => new(DurationEnum.Is100);
    public static DurationBuilder Is150 => new(DurationEnum.Is150);
    public static DurationBuilder Is200 => new(DurationEnum.Is200);
    public static DurationBuilder Is300 => new(DurationEnum.Is300);
    public static DurationBuilder Is500 => new(DurationEnum.Is500);
    public static DurationBuilder Is700 => new(DurationEnum.Is700);
    public static DurationBuilder Is1000 => new(DurationEnum.Is1000);
    public static DurationBuilder Token(string value) => new("duration-" + value);
}
