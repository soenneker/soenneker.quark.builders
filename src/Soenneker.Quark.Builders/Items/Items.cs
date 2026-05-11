namespace Soenneker.Quark;

public static class Items
{
    public static ItemsBuilder OnHover => new ItemsBuilder().OnHover;
    public static ItemsBuilder OnFocus => new ItemsBuilder().OnFocus;
    public static ItemsBuilder OnFocusVisible => new ItemsBuilder().OnFocusVisible;
    public static ItemsBuilder OnActive => new ItemsBuilder().OnActive;
    public static ItemsBuilder OnDisabled => new ItemsBuilder().OnDisabled;
    public static ItemsBuilder OnDark => new ItemsBuilder().OnDark;
    public static ItemsBuilder OnVisited => new ItemsBuilder().OnVisited;
    public static ItemsBuilder OnChecked => new ItemsBuilder().OnChecked;
    public static ItemsBuilder OnOpen => new ItemsBuilder().OnOpen;
    public static ItemsBuilder OnFirst => new ItemsBuilder().OnFirst;
    public static ItemsBuilder OnLast => new ItemsBuilder().OnLast;
    public static ItemsBuilder OnOdd => new ItemsBuilder().OnOdd;
    public static ItemsBuilder OnEven => new ItemsBuilder().OnEven;
    public static ItemsBuilder OnBefore => new ItemsBuilder().OnBefore;
    public static ItemsBuilder OnAfter => new ItemsBuilder().OnAfter;
    public static ItemsBuilder OnPlaceholder => new ItemsBuilder().OnPlaceholder;
    public static ItemsBuilder OnSelection => new ItemsBuilder().OnSelection;
    public static ItemsBuilder OnMarker => new ItemsBuilder().OnMarker;
    public static ItemsBuilder OnFirstLetter => new ItemsBuilder().OnFirstLetter;
    public static ItemsBuilder OnFirstLine => new ItemsBuilder().OnFirstLine;
    public static ItemsBuilder OnFile => new ItemsBuilder().OnFile;
    public static ItemsBuilder OnBackdrop => new ItemsBuilder().OnBackdrop;
    public static ItemsBuilder OnGroupHover => new ItemsBuilder().OnGroupHover;
    public static ItemsBuilder OnGroupFocus => new ItemsBuilder().OnGroupFocus;
    public static ItemsBuilder OnPeerHover => new ItemsBuilder().OnPeerHover;
    public static ItemsBuilder OnPeerFocus => new ItemsBuilder().OnPeerFocus;
    public static ItemsBuilder Start => new(ItemsEnum.Start);
    public static ItemsBuilder End => new(ItemsEnum.End);
    public static ItemsBuilder Center => new(ItemsEnum.Center);
    public static ItemsBuilder Baseline => new(ItemsEnum.Baseline);
    public static ItemsBuilder Stretch => new(ItemsEnum.Stretch);
    public static ItemsBuilder Token(string value) => new("items-" + value);
}
