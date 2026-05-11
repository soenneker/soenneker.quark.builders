namespace Soenneker.Quark;

public static class JustifyItemsAlign
{
    public static JustifyItemsAlignBuilder OnHover => new JustifyItemsAlignBuilder().OnHover;
    public static JustifyItemsAlignBuilder OnFocus => new JustifyItemsAlignBuilder().OnFocus;
    public static JustifyItemsAlignBuilder OnFocusVisible => new JustifyItemsAlignBuilder().OnFocusVisible;
    public static JustifyItemsAlignBuilder OnActive => new JustifyItemsAlignBuilder().OnActive;
    public static JustifyItemsAlignBuilder OnDisabled => new JustifyItemsAlignBuilder().OnDisabled;
    public static JustifyItemsAlignBuilder OnDark => new JustifyItemsAlignBuilder().OnDark;
    public static JustifyItemsAlignBuilder OnVisited => new JustifyItemsAlignBuilder().OnVisited;
    public static JustifyItemsAlignBuilder OnChecked => new JustifyItemsAlignBuilder().OnChecked;
    public static JustifyItemsAlignBuilder OnOpen => new JustifyItemsAlignBuilder().OnOpen;
    public static JustifyItemsAlignBuilder OnFirst => new JustifyItemsAlignBuilder().OnFirst;
    public static JustifyItemsAlignBuilder OnLast => new JustifyItemsAlignBuilder().OnLast;
    public static JustifyItemsAlignBuilder OnOdd => new JustifyItemsAlignBuilder().OnOdd;
    public static JustifyItemsAlignBuilder OnEven => new JustifyItemsAlignBuilder().OnEven;
    public static JustifyItemsAlignBuilder OnBefore => new JustifyItemsAlignBuilder().OnBefore;
    public static JustifyItemsAlignBuilder OnAfter => new JustifyItemsAlignBuilder().OnAfter;
    public static JustifyItemsAlignBuilder OnPlaceholder => new JustifyItemsAlignBuilder().OnPlaceholder;
    public static JustifyItemsAlignBuilder OnSelection => new JustifyItemsAlignBuilder().OnSelection;
    public static JustifyItemsAlignBuilder OnMarker => new JustifyItemsAlignBuilder().OnMarker;
    public static JustifyItemsAlignBuilder OnFirstLetter => new JustifyItemsAlignBuilder().OnFirstLetter;
    public static JustifyItemsAlignBuilder OnFirstLine => new JustifyItemsAlignBuilder().OnFirstLine;
    public static JustifyItemsAlignBuilder OnFile => new JustifyItemsAlignBuilder().OnFile;
    public static JustifyItemsAlignBuilder OnBackdrop => new JustifyItemsAlignBuilder().OnBackdrop;
    public static JustifyItemsAlignBuilder OnGroupHover => new JustifyItemsAlignBuilder().OnGroupHover;
    public static JustifyItemsAlignBuilder OnGroupFocus => new JustifyItemsAlignBuilder().OnGroupFocus;
    public static JustifyItemsAlignBuilder OnPeerHover => new JustifyItemsAlignBuilder().OnPeerHover;
    public static JustifyItemsAlignBuilder OnPeerFocus => new JustifyItemsAlignBuilder().OnPeerFocus;
    public static JustifyItemsAlignBuilder Normal => new(JustifyItemsAlignEnum.Normal);
    public static JustifyItemsAlignBuilder Start => new(JustifyItemsAlignEnum.Start);
    public static JustifyItemsAlignBuilder End => new(JustifyItemsAlignEnum.End);
    public static JustifyItemsAlignBuilder Center => new(JustifyItemsAlignEnum.Center);
    public static JustifyItemsAlignBuilder Stretch => new(JustifyItemsAlignEnum.Stretch);
    public static JustifyItemsAlignBuilder Token(string value) => new("justify-items-" + value);
}
