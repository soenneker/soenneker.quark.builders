namespace Soenneker.Quark;

public static class JustifySelfAlign
{
    public static JustifySelfAlignBuilder OnHover => new JustifySelfAlignBuilder().OnHover;
    public static JustifySelfAlignBuilder OnFocus => new JustifySelfAlignBuilder().OnFocus;
    public static JustifySelfAlignBuilder OnFocusVisible => new JustifySelfAlignBuilder().OnFocusVisible;
    public static JustifySelfAlignBuilder OnActive => new JustifySelfAlignBuilder().OnActive;
    public static JustifySelfAlignBuilder OnDisabled => new JustifySelfAlignBuilder().OnDisabled;
    public static JustifySelfAlignBuilder OnDark => new JustifySelfAlignBuilder().OnDark;
    public static JustifySelfAlignBuilder OnVisited => new JustifySelfAlignBuilder().OnVisited;
    public static JustifySelfAlignBuilder OnChecked => new JustifySelfAlignBuilder().OnChecked;
    public static JustifySelfAlignBuilder OnOpen => new JustifySelfAlignBuilder().OnOpen;
    public static JustifySelfAlignBuilder OnFirst => new JustifySelfAlignBuilder().OnFirst;
    public static JustifySelfAlignBuilder OnLast => new JustifySelfAlignBuilder().OnLast;
    public static JustifySelfAlignBuilder OnOdd => new JustifySelfAlignBuilder().OnOdd;
    public static JustifySelfAlignBuilder OnEven => new JustifySelfAlignBuilder().OnEven;
    public static JustifySelfAlignBuilder OnBefore => new JustifySelfAlignBuilder().OnBefore;
    public static JustifySelfAlignBuilder OnAfter => new JustifySelfAlignBuilder().OnAfter;
    public static JustifySelfAlignBuilder OnPlaceholder => new JustifySelfAlignBuilder().OnPlaceholder;
    public static JustifySelfAlignBuilder OnSelection => new JustifySelfAlignBuilder().OnSelection;
    public static JustifySelfAlignBuilder OnMarker => new JustifySelfAlignBuilder().OnMarker;
    public static JustifySelfAlignBuilder OnFirstLetter => new JustifySelfAlignBuilder().OnFirstLetter;
    public static JustifySelfAlignBuilder OnFirstLine => new JustifySelfAlignBuilder().OnFirstLine;
    public static JustifySelfAlignBuilder OnFile => new JustifySelfAlignBuilder().OnFile;
    public static JustifySelfAlignBuilder OnBackdrop => new JustifySelfAlignBuilder().OnBackdrop;
    public static JustifySelfAlignBuilder OnGroupHover => new JustifySelfAlignBuilder().OnGroupHover;
    public static JustifySelfAlignBuilder OnGroupFocus => new JustifySelfAlignBuilder().OnGroupFocus;
    public static JustifySelfAlignBuilder OnPeerHover => new JustifySelfAlignBuilder().OnPeerHover;
    public static JustifySelfAlignBuilder OnPeerFocus => new JustifySelfAlignBuilder().OnPeerFocus;
    public static JustifySelfAlignBuilder Auto => new(JustifySelfAlignEnum.Auto);
    public static JustifySelfAlignBuilder Start => new(JustifySelfAlignEnum.Start);
    public static JustifySelfAlignBuilder End => new(JustifySelfAlignEnum.End);
    public static JustifySelfAlignBuilder Center => new(JustifySelfAlignEnum.Center);
    public static JustifySelfAlignBuilder Stretch => new(JustifySelfAlignEnum.Stretch);
    public static JustifySelfAlignBuilder Token(string value) => new("justify-self-" + value);
}
