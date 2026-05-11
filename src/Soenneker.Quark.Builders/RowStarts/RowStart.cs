namespace Soenneker.Quark;

public static class RowStart
{
    public static RowStartBuilder OnHover => new RowStartBuilder().OnHover;
    public static RowStartBuilder OnFocus => new RowStartBuilder().OnFocus;
    public static RowStartBuilder OnFocusVisible => new RowStartBuilder().OnFocusVisible;
    public static RowStartBuilder OnActive => new RowStartBuilder().OnActive;
    public static RowStartBuilder OnDisabled => new RowStartBuilder().OnDisabled;
    public static RowStartBuilder OnDark => new RowStartBuilder().OnDark;
    public static RowStartBuilder OnVisited => new RowStartBuilder().OnVisited;
    public static RowStartBuilder OnChecked => new RowStartBuilder().OnChecked;
    public static RowStartBuilder OnOpen => new RowStartBuilder().OnOpen;
    public static RowStartBuilder OnFirst => new RowStartBuilder().OnFirst;
    public static RowStartBuilder OnLast => new RowStartBuilder().OnLast;
    public static RowStartBuilder OnOdd => new RowStartBuilder().OnOdd;
    public static RowStartBuilder OnEven => new RowStartBuilder().OnEven;
    public static RowStartBuilder OnBefore => new RowStartBuilder().OnBefore;
    public static RowStartBuilder OnAfter => new RowStartBuilder().OnAfter;
    public static RowStartBuilder OnPlaceholder => new RowStartBuilder().OnPlaceholder;
    public static RowStartBuilder OnSelection => new RowStartBuilder().OnSelection;
    public static RowStartBuilder OnMarker => new RowStartBuilder().OnMarker;
    public static RowStartBuilder OnFirstLetter => new RowStartBuilder().OnFirstLetter;
    public static RowStartBuilder OnFirstLine => new RowStartBuilder().OnFirstLine;
    public static RowStartBuilder OnFile => new RowStartBuilder().OnFile;
    public static RowStartBuilder OnBackdrop => new RowStartBuilder().OnBackdrop;
    public static RowStartBuilder OnGroupHover => new RowStartBuilder().OnGroupHover;
    public static RowStartBuilder OnGroupFocus => new RowStartBuilder().OnGroupFocus;
    public static RowStartBuilder OnPeerHover => new RowStartBuilder().OnPeerHover;
    public static RowStartBuilder OnPeerFocus => new RowStartBuilder().OnPeerFocus;
    public static RowStartBuilder Auto => new("row-start-auto");
    public static RowStartBuilder At(int value) => new(value.ToString());
    public static RowStartBuilder Token(string value) => new("row-start-" + value);
}
