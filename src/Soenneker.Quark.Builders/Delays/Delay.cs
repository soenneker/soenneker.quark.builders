namespace Soenneker.Quark;

public static class Delay
{
    public static DelayBuilder OnHover => new DelayBuilder().OnHover;
    public static DelayBuilder OnFocus => new DelayBuilder().OnFocus;
    public static DelayBuilder OnFocusVisible => new DelayBuilder().OnFocusVisible;
    public static DelayBuilder OnActive => new DelayBuilder().OnActive;
    public static DelayBuilder OnDisabled => new DelayBuilder().OnDisabled;
    public static DelayBuilder OnDark => new DelayBuilder().OnDark;
    public static DelayBuilder OnVisited => new DelayBuilder().OnVisited;
    public static DelayBuilder OnChecked => new DelayBuilder().OnChecked;
    public static DelayBuilder OnOpen => new DelayBuilder().OnOpen;
    public static DelayBuilder OnFirst => new DelayBuilder().OnFirst;
    public static DelayBuilder OnLast => new DelayBuilder().OnLast;
    public static DelayBuilder OnOdd => new DelayBuilder().OnOdd;
    public static DelayBuilder OnEven => new DelayBuilder().OnEven;
    public static DelayBuilder OnBefore => new DelayBuilder().OnBefore;
    public static DelayBuilder OnAfter => new DelayBuilder().OnAfter;
    public static DelayBuilder OnPlaceholder => new DelayBuilder().OnPlaceholder;
    public static DelayBuilder OnSelection => new DelayBuilder().OnSelection;
    public static DelayBuilder OnMarker => new DelayBuilder().OnMarker;
    public static DelayBuilder OnFirstLetter => new DelayBuilder().OnFirstLetter;
    public static DelayBuilder OnFirstLine => new DelayBuilder().OnFirstLine;
    public static DelayBuilder OnFile => new DelayBuilder().OnFile;
    public static DelayBuilder OnBackdrop => new DelayBuilder().OnBackdrop;
    public static DelayBuilder OnGroupHover => new DelayBuilder().OnGroupHover;
    public static DelayBuilder OnGroupFocus => new DelayBuilder().OnGroupFocus;
    public static DelayBuilder OnPeerHover => new DelayBuilder().OnPeerHover;
    public static DelayBuilder OnPeerFocus => new DelayBuilder().OnPeerFocus;
    public static DelayBuilder Is75 => new(DelayEnum.Is75);
    public static DelayBuilder Is100 => new(DelayEnum.Is100);
    public static DelayBuilder Is150 => new(DelayEnum.Is150);
    public static DelayBuilder Is200 => new(DelayEnum.Is200);
    public static DelayBuilder Is300 => new(DelayEnum.Is300);
    public static DelayBuilder Is500 => new(DelayEnum.Is500);
    public static DelayBuilder Is700 => new(DelayEnum.Is700);
    public static DelayBuilder Is1000 => new(DelayEnum.Is1000);
    public static DelayBuilder Token(string value) => new("delay-" + value);
}
