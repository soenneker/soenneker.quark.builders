namespace Soenneker.Quark;

public static class ContentAlign
{
    public static ContentAlignBuilder OnHover => new ContentAlignBuilder().OnHover;
    public static ContentAlignBuilder OnFocus => new ContentAlignBuilder().OnFocus;
    public static ContentAlignBuilder OnFocusVisible => new ContentAlignBuilder().OnFocusVisible;
    public static ContentAlignBuilder OnActive => new ContentAlignBuilder().OnActive;
    public static ContentAlignBuilder OnDisabled => new ContentAlignBuilder().OnDisabled;
    public static ContentAlignBuilder OnDark => new ContentAlignBuilder().OnDark;
    public static ContentAlignBuilder OnVisited => new ContentAlignBuilder().OnVisited;
    public static ContentAlignBuilder OnChecked => new ContentAlignBuilder().OnChecked;
    public static ContentAlignBuilder OnOpen => new ContentAlignBuilder().OnOpen;
    public static ContentAlignBuilder OnFirst => new ContentAlignBuilder().OnFirst;
    public static ContentAlignBuilder OnLast => new ContentAlignBuilder().OnLast;
    public static ContentAlignBuilder OnOdd => new ContentAlignBuilder().OnOdd;
    public static ContentAlignBuilder OnEven => new ContentAlignBuilder().OnEven;
    public static ContentAlignBuilder OnBefore => new ContentAlignBuilder().OnBefore;
    public static ContentAlignBuilder OnAfter => new ContentAlignBuilder().OnAfter;
    public static ContentAlignBuilder OnPlaceholder => new ContentAlignBuilder().OnPlaceholder;
    public static ContentAlignBuilder OnSelection => new ContentAlignBuilder().OnSelection;
    public static ContentAlignBuilder OnMarker => new ContentAlignBuilder().OnMarker;
    public static ContentAlignBuilder OnFirstLetter => new ContentAlignBuilder().OnFirstLetter;
    public static ContentAlignBuilder OnFirstLine => new ContentAlignBuilder().OnFirstLine;
    public static ContentAlignBuilder OnFile => new ContentAlignBuilder().OnFile;
    public static ContentAlignBuilder OnBackdrop => new ContentAlignBuilder().OnBackdrop;
    public static ContentAlignBuilder OnGroupHover => new ContentAlignBuilder().OnGroupHover;
    public static ContentAlignBuilder OnGroupFocus => new ContentAlignBuilder().OnGroupFocus;
    public static ContentAlignBuilder OnPeerHover => new ContentAlignBuilder().OnPeerHover;
    public static ContentAlignBuilder OnPeerFocus => new ContentAlignBuilder().OnPeerFocus;
    public static ContentAlignBuilder Normal => new(ContentEnum.Normal);
    public static ContentAlignBuilder Center => new(ContentEnum.Center);
    public static ContentAlignBuilder Start => new(ContentEnum.Start);
    public static ContentAlignBuilder End => new(ContentEnum.End);
    public static ContentAlignBuilder Between => new(ContentEnum.Between);
    public static ContentAlignBuilder Around => new(ContentEnum.Around);
    public static ContentAlignBuilder Evenly => new(ContentEnum.Evenly);
    public static ContentAlignBuilder Stretch => new(ContentEnum.Stretch);
    public static ContentAlignBuilder Baseline => new(ContentEnum.Baseline);
    public static ContentAlignBuilder Token(string value) => new("content-" + value);
}
