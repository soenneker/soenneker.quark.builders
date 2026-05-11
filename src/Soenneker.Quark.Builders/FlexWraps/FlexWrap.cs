namespace Soenneker.Quark;

public static class FlexWrap
{
    public static FlexWrapBuilder OnHover => new FlexWrapBuilder().OnHover;
    public static FlexWrapBuilder OnFocus => new FlexWrapBuilder().OnFocus;
    public static FlexWrapBuilder OnFocusVisible => new FlexWrapBuilder().OnFocusVisible;
    public static FlexWrapBuilder OnActive => new FlexWrapBuilder().OnActive;
    public static FlexWrapBuilder OnDisabled => new FlexWrapBuilder().OnDisabled;
    public static FlexWrapBuilder OnDark => new FlexWrapBuilder().OnDark;
    public static FlexWrapBuilder OnVisited => new FlexWrapBuilder().OnVisited;
    public static FlexWrapBuilder OnChecked => new FlexWrapBuilder().OnChecked;
    public static FlexWrapBuilder OnOpen => new FlexWrapBuilder().OnOpen;
    public static FlexWrapBuilder OnFirst => new FlexWrapBuilder().OnFirst;
    public static FlexWrapBuilder OnLast => new FlexWrapBuilder().OnLast;
    public static FlexWrapBuilder OnOdd => new FlexWrapBuilder().OnOdd;
    public static FlexWrapBuilder OnEven => new FlexWrapBuilder().OnEven;
    public static FlexWrapBuilder OnBefore => new FlexWrapBuilder().OnBefore;
    public static FlexWrapBuilder OnAfter => new FlexWrapBuilder().OnAfter;
    public static FlexWrapBuilder OnPlaceholder => new FlexWrapBuilder().OnPlaceholder;
    public static FlexWrapBuilder OnSelection => new FlexWrapBuilder().OnSelection;
    public static FlexWrapBuilder OnMarker => new FlexWrapBuilder().OnMarker;
    public static FlexWrapBuilder OnFirstLetter => new FlexWrapBuilder().OnFirstLetter;
    public static FlexWrapBuilder OnFirstLine => new FlexWrapBuilder().OnFirstLine;
    public static FlexWrapBuilder OnFile => new FlexWrapBuilder().OnFile;
    public static FlexWrapBuilder OnBackdrop => new FlexWrapBuilder().OnBackdrop;
    public static FlexWrapBuilder OnGroupHover => new FlexWrapBuilder().OnGroupHover;
    public static FlexWrapBuilder OnGroupFocus => new FlexWrapBuilder().OnGroupFocus;
    public static FlexWrapBuilder OnPeerHover => new FlexWrapBuilder().OnPeerHover;
    public static FlexWrapBuilder OnPeerFocus => new FlexWrapBuilder().OnPeerFocus;
    public static FlexWrapBuilder Wrap => new(FlexWrapEnum.Wrap);
    public static FlexWrapBuilder WrapReverse => new(FlexWrapEnum.WrapReverse);
    public static FlexWrapBuilder NoWrap => new(FlexWrapEnum.NoWrap);
    public static FlexWrapBuilder Token(string value) => new("flex-" + value);
}
