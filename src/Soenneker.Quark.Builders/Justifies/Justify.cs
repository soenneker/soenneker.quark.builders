namespace Soenneker.Quark;

public static class Justify
{
    public static JustifyBuilder OnHover => new JustifyBuilder().OnHover;
    public static JustifyBuilder OnFocus => new JustifyBuilder().OnFocus;
    public static JustifyBuilder OnFocusVisible => new JustifyBuilder().OnFocusVisible;
    public static JustifyBuilder OnActive => new JustifyBuilder().OnActive;
    public static JustifyBuilder OnDisabled => new JustifyBuilder().OnDisabled;
    public static JustifyBuilder OnDark => new JustifyBuilder().OnDark;
    public static JustifyBuilder OnVisited => new JustifyBuilder().OnVisited;
    public static JustifyBuilder OnChecked => new JustifyBuilder().OnChecked;
    public static JustifyBuilder OnOpen => new JustifyBuilder().OnOpen;
    public static JustifyBuilder OnFirst => new JustifyBuilder().OnFirst;
    public static JustifyBuilder OnLast => new JustifyBuilder().OnLast;
    public static JustifyBuilder OnOdd => new JustifyBuilder().OnOdd;
    public static JustifyBuilder OnEven => new JustifyBuilder().OnEven;
    public static JustifyBuilder OnBefore => new JustifyBuilder().OnBefore;
    public static JustifyBuilder OnAfter => new JustifyBuilder().OnAfter;
    public static JustifyBuilder OnPlaceholder => new JustifyBuilder().OnPlaceholder;
    public static JustifyBuilder OnSelection => new JustifyBuilder().OnSelection;
    public static JustifyBuilder OnMarker => new JustifyBuilder().OnMarker;
    public static JustifyBuilder OnFirstLetter => new JustifyBuilder().OnFirstLetter;
    public static JustifyBuilder OnFirstLine => new JustifyBuilder().OnFirstLine;
    public static JustifyBuilder OnFile => new JustifyBuilder().OnFile;
    public static JustifyBuilder OnBackdrop => new JustifyBuilder().OnBackdrop;
    public static JustifyBuilder OnGroupHover => new JustifyBuilder().OnGroupHover;
    public static JustifyBuilder OnGroupFocus => new JustifyBuilder().OnGroupFocus;
    public static JustifyBuilder OnPeerHover => new JustifyBuilder().OnPeerHover;
    public static JustifyBuilder OnPeerFocus => new JustifyBuilder().OnPeerFocus;
    public static JustifyBuilder Normal => new(JustifyEnum.Normal);
    public static JustifyBuilder Start => new(JustifyEnum.Start);
    public static JustifyBuilder End => new(JustifyEnum.End);
    public static JustifyBuilder Center => new(JustifyEnum.Center);
    public static JustifyBuilder Between => new(JustifyEnum.Between);
    public static JustifyBuilder Around => new(JustifyEnum.Around);
    public static JustifyBuilder Evenly => new(JustifyEnum.Evenly);
    public static JustifyBuilder Stretch => new(JustifyEnum.Stretch);
    public static JustifyBuilder Token(string value) => new("justify-" + value);
}
