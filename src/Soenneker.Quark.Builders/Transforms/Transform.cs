
namespace Soenneker.Quark;

/// <summary>
/// Tailwind transform utility. Tailwind: transform-none, transform-gpu, transform-cpu.
/// </summary>
public static class Transform
{
    public static TransformBuilder OnHover => new TransformBuilder().OnHover;
    public static TransformBuilder OnFocus => new TransformBuilder().OnFocus;
    public static TransformBuilder OnFocusVisible => new TransformBuilder().OnFocusVisible;
    public static TransformBuilder OnActive => new TransformBuilder().OnActive;
    public static TransformBuilder OnDisabled => new TransformBuilder().OnDisabled;
    public static TransformBuilder OnDark => new TransformBuilder().OnDark;
    public static TransformBuilder OnVisited => new TransformBuilder().OnVisited;
    public static TransformBuilder OnChecked => new TransformBuilder().OnChecked;
    public static TransformBuilder OnOpen => new TransformBuilder().OnOpen;
    public static TransformBuilder OnFirst => new TransformBuilder().OnFirst;
    public static TransformBuilder OnLast => new TransformBuilder().OnLast;
    public static TransformBuilder OnOdd => new TransformBuilder().OnOdd;
    public static TransformBuilder OnEven => new TransformBuilder().OnEven;
    public static TransformBuilder OnBefore => new TransformBuilder().OnBefore;
    public static TransformBuilder OnAfter => new TransformBuilder().OnAfter;
    public static TransformBuilder OnPlaceholder => new TransformBuilder().OnPlaceholder;
    public static TransformBuilder OnSelection => new TransformBuilder().OnSelection;
    public static TransformBuilder OnMarker => new TransformBuilder().OnMarker;
    public static TransformBuilder OnFirstLetter => new TransformBuilder().OnFirstLetter;
    public static TransformBuilder OnFirstLine => new TransformBuilder().OnFirstLine;
    public static TransformBuilder OnFile => new TransformBuilder().OnFile;
    public static TransformBuilder OnBackdrop => new TransformBuilder().OnBackdrop;
    public static TransformBuilder OnGroupHover => new TransformBuilder().OnGroupHover;
    public static TransformBuilder OnGroupFocus => new TransformBuilder().OnGroupFocus;
    public static TransformBuilder OnPeerHover => new TransformBuilder().OnPeerHover;
    public static TransformBuilder OnPeerFocus => new TransformBuilder().OnPeerFocus;
    /// <summary>
    /// No transform (none).
    /// </summary>
    public static TransformBuilder None => new(TransformEnum.None);

    /// <summary>
    /// Uses the GPU transform utility.
    /// </summary>
    public static TransformBuilder Gpu => new(TransformEnum.Gpu);

    /// <summary>
    /// Uses the CPU transform utility.
    /// </summary>
    public static TransformBuilder Cpu => new(TransformEnum.Cpu);
    public static TransformBuilder Token(string value) => new("transform-" + value);
}
