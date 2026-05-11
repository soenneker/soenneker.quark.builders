namespace Soenneker.Quark;

public static class GridCols
{
    public static GridColsBuilder OnHover => new GridColsBuilder().OnHover;
    public static GridColsBuilder OnFocus => new GridColsBuilder().OnFocus;
    public static GridColsBuilder OnFocusVisible => new GridColsBuilder().OnFocusVisible;
    public static GridColsBuilder OnActive => new GridColsBuilder().OnActive;
    public static GridColsBuilder OnDisabled => new GridColsBuilder().OnDisabled;
    public static GridColsBuilder OnDark => new GridColsBuilder().OnDark;
    public static GridColsBuilder OnVisited => new GridColsBuilder().OnVisited;
    public static GridColsBuilder OnChecked => new GridColsBuilder().OnChecked;
    public static GridColsBuilder OnOpen => new GridColsBuilder().OnOpen;
    public static GridColsBuilder OnFirst => new GridColsBuilder().OnFirst;
    public static GridColsBuilder OnLast => new GridColsBuilder().OnLast;
    public static GridColsBuilder OnOdd => new GridColsBuilder().OnOdd;
    public static GridColsBuilder OnEven => new GridColsBuilder().OnEven;
    public static GridColsBuilder OnBefore => new GridColsBuilder().OnBefore;
    public static GridColsBuilder OnAfter => new GridColsBuilder().OnAfter;
    public static GridColsBuilder OnPlaceholder => new GridColsBuilder().OnPlaceholder;
    public static GridColsBuilder OnSelection => new GridColsBuilder().OnSelection;
    public static GridColsBuilder OnMarker => new GridColsBuilder().OnMarker;
    public static GridColsBuilder OnFirstLetter => new GridColsBuilder().OnFirstLetter;
    public static GridColsBuilder OnFirstLine => new GridColsBuilder().OnFirstLine;
    public static GridColsBuilder OnFile => new GridColsBuilder().OnFile;
    public static GridColsBuilder OnBackdrop => new GridColsBuilder().OnBackdrop;
    public static GridColsBuilder OnGroupHover => new GridColsBuilder().OnGroupHover;
    public static GridColsBuilder OnGroupFocus => new GridColsBuilder().OnGroupFocus;
    public static GridColsBuilder OnPeerHover => new GridColsBuilder().OnPeerHover;
    public static GridColsBuilder OnPeerFocus => new GridColsBuilder().OnPeerFocus;
    public static GridColsBuilder Is1 => new("grid-cols-1");
    public static GridColsBuilder Is2 => new("grid-cols-2");
    public static GridColsBuilder Is3 => new("grid-cols-3");
    public static GridColsBuilder Is4 => new("grid-cols-4");
    public static GridColsBuilder Is5 => new("grid-cols-5");
    public static GridColsBuilder Is6 => new("grid-cols-6");
    public static GridColsBuilder Is7 => new("grid-cols-7");
    public static GridColsBuilder Is8 => new("grid-cols-8");
    public static GridColsBuilder Is9 => new("grid-cols-9");
    public static GridColsBuilder Is10 => new("grid-cols-10");
    public static GridColsBuilder Is11 => new("grid-cols-11");
    public static GridColsBuilder Is12 => new("grid-cols-12");
    public static GridColsBuilder None => new("grid-cols-none");
    public static GridColsBuilder Subgrid => new("grid-cols-subgrid");
    public static GridColsBuilder Count(int value) => new("grid-cols-" + value);
    public static GridColsBuilder Token(string value) => new("grid-cols-" + value);
}
