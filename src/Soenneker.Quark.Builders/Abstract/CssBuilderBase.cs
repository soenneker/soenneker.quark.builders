namespace Soenneker.Quark;

public abstract class CssBuilderBase : ICssBuilder
{
    public VariantBuilder Hover => Variant.Of(this).Hover;
    public VariantBuilder Focus => Variant.Of(this).Focus;
    public VariantBuilder FocusVisible => Variant.Of(this).FocusVisible;
    public VariantBuilder Active => Variant.Of(this).Active;
    public VariantBuilder Disabled => Variant.Of(this).Disabled;
    public VariantBuilder Dark => Variant.Of(this).Dark;
    public VariantBuilder Visited => Variant.Of(this).Visited;
    public VariantBuilder Checked => Variant.Of(this).Checked;
    public VariantBuilder Open => Variant.Of(this).Open;
    public VariantBuilder First => Variant.Of(this).First;
    public VariantBuilder Last => Variant.Of(this).Last;
    public VariantBuilder Odd => Variant.Of(this).Odd;
    public VariantBuilder Even => Variant.Of(this).Even;
    public VariantBuilder Before => Variant.Of(this).Before;
    public VariantBuilder After => Variant.Of(this).After;
    public VariantBuilder Placeholder => Variant.Of(this).Placeholder;
    public VariantBuilder Selection => Variant.Of(this).Selection;
    public VariantBuilder Marker => Variant.Of(this).Marker;
    public VariantBuilder FirstLetter => Variant.Of(this).FirstLetter;
    public VariantBuilder FirstLine => Variant.Of(this).FirstLine;
    public VariantBuilder File => Variant.Of(this).File;
    public VariantBuilder Backdrop => Variant.Of(this).Backdrop;
    public VariantBuilder GroupHover => Variant.Of(this).GroupHover;
    public VariantBuilder GroupFocus => Variant.Of(this).GroupFocus;
    public VariantBuilder PeerHover => Variant.Of(this).PeerHover;
    public VariantBuilder PeerFocus => Variant.Of(this).PeerFocus;

    public VariantBuilder Data(string attribute, string value) => Variant.Of(this).Data(attribute, value);
    public VariantBuilder DataState(string value) => Variant.Of(this).DataState(value);
    public VariantBuilder Aria(string attribute) => Variant.Of(this).Aria(attribute);
    public VariantBuilder Aria(string attribute, string value) => Variant.Of(this).Aria(attribute, value);
    public VariantBuilder Group(string modifier) => Variant.Of(this).Group(modifier);
    public VariantBuilder Group(string modifier, string name) => Variant.Of(this).Group(modifier, name);
    public VariantBuilder Peer(string modifier) => Variant.Of(this).Peer(modifier);
    public VariantBuilder Peer(string modifier, string name) => Variant.Of(this).Peer(modifier, name);
    public VariantBuilder Has(string selector) => Variant.Of(this).Has(selector);
    public VariantBuilder Not(string selector) => Variant.Of(this).Not(selector);
    public VariantBuilder Supports(string condition) => Variant.Of(this).Supports(condition);
    public VariantBuilder Modifier(string modifier) => Variant.Of(this).Modifier(modifier);
    public VariantBuilder Modifiers(params string[] modifiers) => Variant.Of(this).Modifiers(modifiers);
    public VariantBuilder Custom(string modifier) => Variant.Of(this).Custom(modifier);

    public abstract string ToClass();

    public virtual string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
