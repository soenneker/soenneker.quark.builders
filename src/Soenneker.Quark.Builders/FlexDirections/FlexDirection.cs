namespace Soenneker.Quark;

public static class FlexDirection
{
    public static FlexDirectionBuilder OnHover => new FlexDirectionBuilder().OnHover;
    public static FlexDirectionBuilder OnFocus => new FlexDirectionBuilder().OnFocus;
    public static FlexDirectionBuilder OnFocusVisible => new FlexDirectionBuilder().OnFocusVisible;
    public static FlexDirectionBuilder OnActive => new FlexDirectionBuilder().OnActive;
    public static FlexDirectionBuilder OnDisabled => new FlexDirectionBuilder().OnDisabled;
    public static FlexDirectionBuilder OnDark => new FlexDirectionBuilder().OnDark;
    public static FlexDirectionBuilder OnVisited => new FlexDirectionBuilder().OnVisited;
    public static FlexDirectionBuilder OnChecked => new FlexDirectionBuilder().OnChecked;
    public static FlexDirectionBuilder OnOpen => new FlexDirectionBuilder().OnOpen;
    public static FlexDirectionBuilder OnFirst => new FlexDirectionBuilder().OnFirst;
    public static FlexDirectionBuilder OnLast => new FlexDirectionBuilder().OnLast;
    public static FlexDirectionBuilder OnOdd => new FlexDirectionBuilder().OnOdd;
    public static FlexDirectionBuilder OnEven => new FlexDirectionBuilder().OnEven;
    public static FlexDirectionBuilder OnBefore => new FlexDirectionBuilder().OnBefore;
    public static FlexDirectionBuilder OnAfter => new FlexDirectionBuilder().OnAfter;
    public static FlexDirectionBuilder OnPlaceholder => new FlexDirectionBuilder().OnPlaceholder;
    public static FlexDirectionBuilder OnSelection => new FlexDirectionBuilder().OnSelection;
    public static FlexDirectionBuilder OnMarker => new FlexDirectionBuilder().OnMarker;
    public static FlexDirectionBuilder OnFirstLetter => new FlexDirectionBuilder().OnFirstLetter;
    public static FlexDirectionBuilder OnFirstLine => new FlexDirectionBuilder().OnFirstLine;
    public static FlexDirectionBuilder OnFile => new FlexDirectionBuilder().OnFile;
    public static FlexDirectionBuilder OnBackdrop => new FlexDirectionBuilder().OnBackdrop;
    public static FlexDirectionBuilder OnGroupHover => new FlexDirectionBuilder().OnGroupHover;
    public static FlexDirectionBuilder OnGroupFocus => new FlexDirectionBuilder().OnGroupFocus;
    public static FlexDirectionBuilder OnPeerHover => new FlexDirectionBuilder().OnPeerHover;
    public static FlexDirectionBuilder OnPeerFocus => new FlexDirectionBuilder().OnPeerFocus;
    public static FlexDirectionBuilder Row => new(FlexDirectionEnum.Row);
    public static FlexDirectionBuilder RowReverse => new(FlexDirectionEnum.RowReverse);
    public static FlexDirectionBuilder Col => new(FlexDirectionEnum.Col);
    public static FlexDirectionBuilder ColReverse => new(FlexDirectionEnum.ColReverse);
    public static FlexDirectionBuilder Token(string value) => new("flex-" + value);
}
