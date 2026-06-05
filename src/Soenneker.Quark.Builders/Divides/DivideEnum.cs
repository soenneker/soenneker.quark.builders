using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the divide enum.
/// </summary>
[EnumValue<string>]
public sealed partial class DivideEnum
{
    /// <summary>
    /// The x.
    /// </summary>
    public static readonly DivideEnum X = new("divide-x");
    /// <summary>
    /// The y.
    /// </summary>
    public static readonly DivideEnum Y = new("divide-y");
    /// <summary>
    /// The x reverse.
    /// </summary>
    public static readonly DivideEnum XReverse = new("divide-x-reverse");
    /// <summary>
    /// The y reverse.
    /// </summary>
    public static readonly DivideEnum YReverse = new("divide-y-reverse");
    /// <summary>
    /// The solid.
    /// </summary>
    public static readonly DivideEnum Solid = new("divide-solid");
    /// <summary>
    /// The dashed.
    /// </summary>
    public static readonly DivideEnum Dashed = new("divide-dashed");
    /// <summary>
    /// The dotted.
    /// </summary>
    public static readonly DivideEnum Dotted = new("divide-dotted");
    /// <summary>
    /// The double.
    /// </summary>
    public static readonly DivideEnum Double = new("divide-double");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly DivideEnum None = new("divide-none");
    /// <summary>
    /// The primary.
    /// </summary>
    public static readonly DivideEnum Primary = new("divide-primary");
    /// <summary>
    /// The secondary.
    /// </summary>
    public static readonly DivideEnum Secondary = new("divide-secondary");
    /// <summary>
    /// The destructive.
    /// </summary>
    public static readonly DivideEnum Destructive = new("divide-destructive");
    /// <summary>
    /// The muted.
    /// </summary>
    public static readonly DivideEnum Muted = new("divide-muted");
    /// <summary>
    /// The accent.
    /// </summary>
    public static readonly DivideEnum Accent = new("divide-accent");
    /// <summary>
    /// The popover.
    /// </summary>
    public static readonly DivideEnum Popover = new("divide-popover");
    /// <summary>
    /// The card.
    /// </summary>
    public static readonly DivideEnum Card = new("divide-card");
    /// <summary>
    /// The background.
    /// </summary>
    public static readonly DivideEnum Background = new("divide-background");
    /// <summary>
    /// The border.
    /// </summary>
    public static readonly DivideEnum Border = new("divide-border");
    /// <summary>
    /// The input.
    /// </summary>
    public static readonly DivideEnum Input = new("divide-input");
    /// <summary>
    /// The ring.
    /// </summary>
    public static readonly DivideEnum Ring = new("divide-ring");
    /// <summary>
    /// The white.
    /// </summary>
    public static readonly DivideEnum White = new("divide-white");
    /// <summary>
    /// The black.
    /// </summary>
    public static readonly DivideEnum Black = new("divide-black");
    /// <summary>
    /// The transparent.
    /// </summary>
    public static readonly DivideEnum Transparent = new("divide-transparent");
}
