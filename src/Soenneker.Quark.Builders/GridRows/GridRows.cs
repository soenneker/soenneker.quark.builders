namespace Soenneker.Quark;

public static class GridRows
{
    public static GridRowsBuilder OnHover => new GridRowsBuilder().OnHover;
    public static GridRowsBuilder OnFocus => new GridRowsBuilder().OnFocus;
    public static GridRowsBuilder OnFocusVisible => new GridRowsBuilder().OnFocusVisible;
    public static GridRowsBuilder OnActive => new GridRowsBuilder().OnActive;
    public static GridRowsBuilder OnDisabled => new GridRowsBuilder().OnDisabled;
    public static GridRowsBuilder OnDark => new GridRowsBuilder().OnDark;
    public static GridRowsBuilder OnVisited => new GridRowsBuilder().OnVisited;
    public static GridRowsBuilder OnChecked => new GridRowsBuilder().OnChecked;
    public static GridRowsBuilder OnOpen => new GridRowsBuilder().OnOpen;
    public static GridRowsBuilder OnFirst => new GridRowsBuilder().OnFirst;
    public static GridRowsBuilder OnLast => new GridRowsBuilder().OnLast;
    public static GridRowsBuilder OnOdd => new GridRowsBuilder().OnOdd;
    public static GridRowsBuilder OnEven => new GridRowsBuilder().OnEven;
    public static GridRowsBuilder OnBefore => new GridRowsBuilder().OnBefore;
    public static GridRowsBuilder OnAfter => new GridRowsBuilder().OnAfter;
    public static GridRowsBuilder OnPlaceholder => new GridRowsBuilder().OnPlaceholder;
    public static GridRowsBuilder OnSelection => new GridRowsBuilder().OnSelection;
    public static GridRowsBuilder OnMarker => new GridRowsBuilder().OnMarker;
    public static GridRowsBuilder OnFirstLetter => new GridRowsBuilder().OnFirstLetter;
    public static GridRowsBuilder OnFirstLine => new GridRowsBuilder().OnFirstLine;
    public static GridRowsBuilder OnFile => new GridRowsBuilder().OnFile;
    public static GridRowsBuilder OnBackdrop => new GridRowsBuilder().OnBackdrop;
    public static GridRowsBuilder OnGroupHover => new GridRowsBuilder().OnGroupHover;
    public static GridRowsBuilder OnGroupFocus => new GridRowsBuilder().OnGroupFocus;
    public static GridRowsBuilder OnPeerHover => new GridRowsBuilder().OnPeerHover;
    public static GridRowsBuilder OnPeerFocus => new GridRowsBuilder().OnPeerFocus;
    public static GridRowsBuilder Is1 => new("grid-rows-1");
    public static GridRowsBuilder Is2 => new("grid-rows-2");
    public static GridRowsBuilder Is3 => new("grid-rows-3");
    public static GridRowsBuilder Is4 => new("grid-rows-4");
    public static GridRowsBuilder Is5 => new("grid-rows-5");
    public static GridRowsBuilder Is6 => new("grid-rows-6");
    public static GridRowsBuilder None => new("grid-rows-none");
    public static GridRowsBuilder Subgrid => new("grid-rows-subgrid");
    public static GridRowsBuilder Count(int value) => new("grid-rows-" + value);
    public static GridRowsBuilder Token(string value) => new("grid-rows-" + value);
}
