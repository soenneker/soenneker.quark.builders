namespace Soenneker.Quark;

public static class TextAlign
{
    public static TextAlignBuilder OnHover => new TextAlignBuilder().OnHover;
    public static TextAlignBuilder OnFocus => new TextAlignBuilder().OnFocus;
    public static TextAlignBuilder OnFocusVisible => new TextAlignBuilder().OnFocusVisible;
    public static TextAlignBuilder OnActive => new TextAlignBuilder().OnActive;
    public static TextAlignBuilder OnDisabled => new TextAlignBuilder().OnDisabled;
    public static TextAlignBuilder OnDark => new TextAlignBuilder().OnDark;
    public static TextAlignBuilder OnVisited => new TextAlignBuilder().OnVisited;
    public static TextAlignBuilder OnChecked => new TextAlignBuilder().OnChecked;
    public static TextAlignBuilder OnOpen => new TextAlignBuilder().OnOpen;
    public static TextAlignBuilder OnFirst => new TextAlignBuilder().OnFirst;
    public static TextAlignBuilder OnLast => new TextAlignBuilder().OnLast;
    public static TextAlignBuilder OnOdd => new TextAlignBuilder().OnOdd;
    public static TextAlignBuilder OnEven => new TextAlignBuilder().OnEven;
    public static TextAlignBuilder OnBefore => new TextAlignBuilder().OnBefore;
    public static TextAlignBuilder OnAfter => new TextAlignBuilder().OnAfter;
    public static TextAlignBuilder OnPlaceholder => new TextAlignBuilder().OnPlaceholder;
    public static TextAlignBuilder OnSelection => new TextAlignBuilder().OnSelection;
    public static TextAlignBuilder OnMarker => new TextAlignBuilder().OnMarker;
    public static TextAlignBuilder OnFirstLetter => new TextAlignBuilder().OnFirstLetter;
    public static TextAlignBuilder OnFirstLine => new TextAlignBuilder().OnFirstLine;
    public static TextAlignBuilder OnFile => new TextAlignBuilder().OnFile;
    public static TextAlignBuilder OnBackdrop => new TextAlignBuilder().OnBackdrop;
    public static TextAlignBuilder OnGroupHover => new TextAlignBuilder().OnGroupHover;
    public static TextAlignBuilder OnGroupFocus => new TextAlignBuilder().OnGroupFocus;
    public static TextAlignBuilder OnPeerHover => new TextAlignBuilder().OnPeerHover;
    public static TextAlignBuilder OnPeerFocus => new TextAlignBuilder().OnPeerFocus;
    public static TextAlignBuilder Start => new(TextAlignmentEnum.Start);
    public static TextAlignBuilder Center => new(TextAlignmentEnum.Center);
    public static TextAlignBuilder End => new(TextAlignmentEnum.End);
    public static TextAlignBuilder Token(string value) => new("text-" + value);
}
