namespace Soenneker.Quark;

public static class RowEnd
{
    public static RowEndBuilder OnHover => new RowEndBuilder().OnHover;
    public static RowEndBuilder OnFocus => new RowEndBuilder().OnFocus;
    public static RowEndBuilder OnFocusVisible => new RowEndBuilder().OnFocusVisible;
    public static RowEndBuilder OnActive => new RowEndBuilder().OnActive;
    public static RowEndBuilder OnDisabled => new RowEndBuilder().OnDisabled;
    public static RowEndBuilder OnDark => new RowEndBuilder().OnDark;
    public static RowEndBuilder OnVisited => new RowEndBuilder().OnVisited;
    public static RowEndBuilder OnChecked => new RowEndBuilder().OnChecked;
    public static RowEndBuilder OnOpen => new RowEndBuilder().OnOpen;
    public static RowEndBuilder OnFirst => new RowEndBuilder().OnFirst;
    public static RowEndBuilder OnLast => new RowEndBuilder().OnLast;
    public static RowEndBuilder OnOdd => new RowEndBuilder().OnOdd;
    public static RowEndBuilder OnEven => new RowEndBuilder().OnEven;
    public static RowEndBuilder OnBefore => new RowEndBuilder().OnBefore;
    public static RowEndBuilder OnAfter => new RowEndBuilder().OnAfter;
    public static RowEndBuilder OnPlaceholder => new RowEndBuilder().OnPlaceholder;
    public static RowEndBuilder OnSelection => new RowEndBuilder().OnSelection;
    public static RowEndBuilder OnMarker => new RowEndBuilder().OnMarker;
    public static RowEndBuilder OnFirstLetter => new RowEndBuilder().OnFirstLetter;
    public static RowEndBuilder OnFirstLine => new RowEndBuilder().OnFirstLine;
    public static RowEndBuilder OnFile => new RowEndBuilder().OnFile;
    public static RowEndBuilder OnBackdrop => new RowEndBuilder().OnBackdrop;
    public static RowEndBuilder OnGroupHover => new RowEndBuilder().OnGroupHover;
    public static RowEndBuilder OnGroupFocus => new RowEndBuilder().OnGroupFocus;
    public static RowEndBuilder OnPeerHover => new RowEndBuilder().OnPeerHover;
    public static RowEndBuilder OnPeerFocus => new RowEndBuilder().OnPeerFocus;
    public static RowEndBuilder Auto => new("row-end-auto");
    public static RowEndBuilder At(int value) => new(value.ToString());
    public static RowEndBuilder Token(string value) => new("row-end-" + value);
}
