namespace Soenneker.Quark;

public static class ColStart
{
    public static ColStartBuilder OnHover => new ColStartBuilder().OnHover;
    public static ColStartBuilder OnFocus => new ColStartBuilder().OnFocus;
    public static ColStartBuilder OnFocusVisible => new ColStartBuilder().OnFocusVisible;
    public static ColStartBuilder OnActive => new ColStartBuilder().OnActive;
    public static ColStartBuilder OnDisabled => new ColStartBuilder().OnDisabled;
    public static ColStartBuilder OnDark => new ColStartBuilder().OnDark;
    public static ColStartBuilder OnVisited => new ColStartBuilder().OnVisited;
    public static ColStartBuilder OnChecked => new ColStartBuilder().OnChecked;
    public static ColStartBuilder OnOpen => new ColStartBuilder().OnOpen;
    public static ColStartBuilder OnFirst => new ColStartBuilder().OnFirst;
    public static ColStartBuilder OnLast => new ColStartBuilder().OnLast;
    public static ColStartBuilder OnOdd => new ColStartBuilder().OnOdd;
    public static ColStartBuilder OnEven => new ColStartBuilder().OnEven;
    public static ColStartBuilder OnBefore => new ColStartBuilder().OnBefore;
    public static ColStartBuilder OnAfter => new ColStartBuilder().OnAfter;
    public static ColStartBuilder OnPlaceholder => new ColStartBuilder().OnPlaceholder;
    public static ColStartBuilder OnSelection => new ColStartBuilder().OnSelection;
    public static ColStartBuilder OnMarker => new ColStartBuilder().OnMarker;
    public static ColStartBuilder OnFirstLetter => new ColStartBuilder().OnFirstLetter;
    public static ColStartBuilder OnFirstLine => new ColStartBuilder().OnFirstLine;
    public static ColStartBuilder OnFile => new ColStartBuilder().OnFile;
    public static ColStartBuilder OnBackdrop => new ColStartBuilder().OnBackdrop;
    public static ColStartBuilder OnGroupHover => new ColStartBuilder().OnGroupHover;
    public static ColStartBuilder OnGroupFocus => new ColStartBuilder().OnGroupFocus;
    public static ColStartBuilder OnPeerHover => new ColStartBuilder().OnPeerHover;
    public static ColStartBuilder OnPeerFocus => new ColStartBuilder().OnPeerFocus;
    public static ColStartBuilder Auto => new("col-start-auto");
    public static ColStartBuilder At(int value) => new(value.ToString());
    public static ColStartBuilder Token(string value) => new("col-start-" + value);
}
