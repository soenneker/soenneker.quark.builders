namespace Soenneker.Quark;

public static class Self
{
    public static SelfBuilder OnHover => new SelfBuilder().OnHover;
    public static SelfBuilder OnFocus => new SelfBuilder().OnFocus;
    public static SelfBuilder OnFocusVisible => new SelfBuilder().OnFocusVisible;
    public static SelfBuilder OnActive => new SelfBuilder().OnActive;
    public static SelfBuilder OnDisabled => new SelfBuilder().OnDisabled;
    public static SelfBuilder OnDark => new SelfBuilder().OnDark;
    public static SelfBuilder OnVisited => new SelfBuilder().OnVisited;
    public static SelfBuilder OnChecked => new SelfBuilder().OnChecked;
    public static SelfBuilder OnOpen => new SelfBuilder().OnOpen;
    public static SelfBuilder OnFirst => new SelfBuilder().OnFirst;
    public static SelfBuilder OnLast => new SelfBuilder().OnLast;
    public static SelfBuilder OnOdd => new SelfBuilder().OnOdd;
    public static SelfBuilder OnEven => new SelfBuilder().OnEven;
    public static SelfBuilder OnBefore => new SelfBuilder().OnBefore;
    public static SelfBuilder OnAfter => new SelfBuilder().OnAfter;
    public static SelfBuilder OnPlaceholder => new SelfBuilder().OnPlaceholder;
    public static SelfBuilder OnSelection => new SelfBuilder().OnSelection;
    public static SelfBuilder OnMarker => new SelfBuilder().OnMarker;
    public static SelfBuilder OnFirstLetter => new SelfBuilder().OnFirstLetter;
    public static SelfBuilder OnFirstLine => new SelfBuilder().OnFirstLine;
    public static SelfBuilder OnFile => new SelfBuilder().OnFile;
    public static SelfBuilder OnBackdrop => new SelfBuilder().OnBackdrop;
    public static SelfBuilder OnGroupHover => new SelfBuilder().OnGroupHover;
    public static SelfBuilder OnGroupFocus => new SelfBuilder().OnGroupFocus;
    public static SelfBuilder OnPeerHover => new SelfBuilder().OnPeerHover;
    public static SelfBuilder OnPeerFocus => new SelfBuilder().OnPeerFocus;
    public static SelfBuilder Auto => new(SelfEnum.Auto);
    public static SelfBuilder Start => new(SelfEnum.Start);
    public static SelfBuilder End => new(SelfEnum.End);
    public static SelfBuilder Center => new(SelfEnum.Center);
    public static SelfBuilder Stretch => new(SelfEnum.Stretch);
    public static SelfBuilder Baseline => new(SelfEnum.Baseline);
    public static SelfBuilder Token(string value) => new("self-" + value);
}
