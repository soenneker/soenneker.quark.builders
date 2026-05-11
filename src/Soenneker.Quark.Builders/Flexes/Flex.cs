
namespace Soenneker.Quark;

/// <summary>
/// Tailwind flex utility. Tailwind: flex-1, flex-auto, flex-initial, flex-none, flex-wrap, flex-row, flex-col.
/// </summary>
public static class Flex
{
    public static FlexBuilder OnHover => new FlexBuilder().OnHover;
    public static FlexBuilder OnFocus => new FlexBuilder().OnFocus;
    public static FlexBuilder OnFocusVisible => new FlexBuilder().OnFocusVisible;
    public static FlexBuilder OnActive => new FlexBuilder().OnActive;
    public static FlexBuilder OnDisabled => new FlexBuilder().OnDisabled;
    public static FlexBuilder OnDark => new FlexBuilder().OnDark;
    public static FlexBuilder OnVisited => new FlexBuilder().OnVisited;
    public static FlexBuilder OnChecked => new FlexBuilder().OnChecked;
    public static FlexBuilder OnOpen => new FlexBuilder().OnOpen;
    public static FlexBuilder OnFirst => new FlexBuilder().OnFirst;
    public static FlexBuilder OnLast => new FlexBuilder().OnLast;
    public static FlexBuilder OnOdd => new FlexBuilder().OnOdd;
    public static FlexBuilder OnEven => new FlexBuilder().OnEven;
    public static FlexBuilder OnBefore => new FlexBuilder().OnBefore;
    public static FlexBuilder OnAfter => new FlexBuilder().OnAfter;
    public static FlexBuilder OnPlaceholder => new FlexBuilder().OnPlaceholder;
    public static FlexBuilder OnSelection => new FlexBuilder().OnSelection;
    public static FlexBuilder OnMarker => new FlexBuilder().OnMarker;
    public static FlexBuilder OnFirstLetter => new FlexBuilder().OnFirstLetter;
    public static FlexBuilder OnFirstLine => new FlexBuilder().OnFirstLine;
    public static FlexBuilder OnFile => new FlexBuilder().OnFile;
    public static FlexBuilder OnBackdrop => new FlexBuilder().OnBackdrop;
    public static FlexBuilder OnGroupHover => new FlexBuilder().OnGroupHover;
    public static FlexBuilder OnGroupFocus => new FlexBuilder().OnGroupFocus;
    public static FlexBuilder OnPeerHover => new FlexBuilder().OnPeerHover;
    public static FlexBuilder OnPeerFocus => new FlexBuilder().OnPeerFocus;
    public static FlexBuilder Is1 => new(FlexEnum.Is1);
    public static FlexBuilder Auto => new(FlexEnum.Auto);
    public static FlexBuilder Initial => new(FlexEnum.Initial);
    public static FlexBuilder None => new(FlexEnum.None);
    public static FlexBuilder Wrap => new(FlexEnum.Wrap);
    public static FlexBuilder WrapReverse => new(FlexEnum.WrapReverse);
    public static FlexBuilder NoWrap => new(FlexEnum.NoWrap);
    public static FlexBuilder Row => new(FlexEnum.Row);
    public static FlexBuilder RowReverse => new(FlexEnum.RowReverse);
    public static FlexBuilder Col => new(FlexEnum.Col);
    public static FlexBuilder ColReverse => new(FlexEnum.ColReverse);
    public static FlexBuilder Token(string value) => new($"flex-{value}");
}
