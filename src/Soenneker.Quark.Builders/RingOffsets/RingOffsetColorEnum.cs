using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RingOffsetColorEnum
{
    public static readonly RingOffsetColorEnum Primary = new("ring-offset-primary");
    public static readonly RingOffsetColorEnum Secondary = new("ring-offset-secondary");
    public static readonly RingOffsetColorEnum Destructive = new("ring-offset-destructive");
    public static readonly RingOffsetColorEnum Muted = new("ring-offset-muted");
    public static readonly RingOffsetColorEnum Accent = new("ring-offset-accent");
    public static readonly RingOffsetColorEnum Popover = new("ring-offset-popover");
    public static readonly RingOffsetColorEnum Card = new("ring-offset-card");
    public static readonly RingOffsetColorEnum Background = new("ring-offset-background");
    public static readonly RingOffsetColorEnum Border = new("ring-offset-border");
    public static readonly RingOffsetColorEnum Input = new("ring-offset-input");
    public static readonly RingOffsetColorEnum Ring = new("ring-offset-ring");
    public static readonly RingOffsetColorEnum White = new("ring-offset-white");
    public static readonly RingOffsetColorEnum Black = new("ring-offset-black");
    public static readonly RingOffsetColorEnum Transparent = new("ring-offset-transparent");
}
