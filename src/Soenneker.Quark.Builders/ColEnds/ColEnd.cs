namespace Soenneker.Quark;

public static class ColEnd
{
    public static ColEndBuilder OnHover => new ColEndBuilder().OnHover;
    public static ColEndBuilder OnFocus => new ColEndBuilder().OnFocus;
    public static ColEndBuilder OnFocusVisible => new ColEndBuilder().OnFocusVisible;
    public static ColEndBuilder OnActive => new ColEndBuilder().OnActive;
    public static ColEndBuilder OnDisabled => new ColEndBuilder().OnDisabled;
    public static ColEndBuilder OnDark => new ColEndBuilder().OnDark;
    public static ColEndBuilder OnVisited => new ColEndBuilder().OnVisited;
    public static ColEndBuilder OnChecked => new ColEndBuilder().OnChecked;
    public static ColEndBuilder OnOpen => new ColEndBuilder().OnOpen;
    public static ColEndBuilder OnFirst => new ColEndBuilder().OnFirst;
    public static ColEndBuilder OnLast => new ColEndBuilder().OnLast;
    public static ColEndBuilder OnOdd => new ColEndBuilder().OnOdd;
    public static ColEndBuilder OnEven => new ColEndBuilder().OnEven;
    public static ColEndBuilder OnBefore => new ColEndBuilder().OnBefore;
    public static ColEndBuilder OnAfter => new ColEndBuilder().OnAfter;
    public static ColEndBuilder OnPlaceholder => new ColEndBuilder().OnPlaceholder;
    public static ColEndBuilder OnSelection => new ColEndBuilder().OnSelection;
    public static ColEndBuilder OnMarker => new ColEndBuilder().OnMarker;
    public static ColEndBuilder OnFirstLetter => new ColEndBuilder().OnFirstLetter;
    public static ColEndBuilder OnFirstLine => new ColEndBuilder().OnFirstLine;
    public static ColEndBuilder OnFile => new ColEndBuilder().OnFile;
    public static ColEndBuilder OnBackdrop => new ColEndBuilder().OnBackdrop;
    public static ColEndBuilder OnGroupHover => new ColEndBuilder().OnGroupHover;
    public static ColEndBuilder OnGroupFocus => new ColEndBuilder().OnGroupFocus;
    public static ColEndBuilder OnPeerHover => new ColEndBuilder().OnPeerHover;
    public static ColEndBuilder OnPeerFocus => new ColEndBuilder().OnPeerFocus;
    public static ColEndBuilder Auto => new("col-end-auto");
    public static ColEndBuilder At(int value) => new(value.ToString());
    public static ColEndBuilder Token(string value) => new("col-end-" + value);
}
