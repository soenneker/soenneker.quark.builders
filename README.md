[![](https://img.shields.io/nuget/v/soenneker.quark.builders.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.builders/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.builders/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.builders/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.builders/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.builders/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.builders.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.builders/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.builders/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.builders/actions/workflows/codeql.yml)

# Soenneker.Quark.Builders

Fluent, strongly named builders for producing Tailwind and shadcn-style utility class strings in .NET UI code.

## Installation

```bash
dotnet add package Soenneker.Quark.Builders
```

No dependency-injection registration is required. Static entry points create a new builder for each expression.

## Build utility classes

```csharp
using Soenneker.Quark;

string display = Display.Flex.ToClass();
// flex

string padding = Padding.OnX.Is4.ToClass();
// px-4

string color = TextColor.Slate.Is900.ToClass();
// text-slate-900
```

Builders expose predefined Tailwind values as properties. `ToClass()` returns the completed class string, and `ToString()` returns the same value for interpolation.

## Chain responsive and state variants

Modifiers apply to the next utility added to the builder:

```csharp
string layout = Display.Flex.OnMd.Grid.ToClass();
// flex md:grid

string interactive = TextColor.OnDark.OnHover.Slate.Is50.ToClass();
// dark:hover:text-slate-50

string state = BackgroundColor.OnDisabled.Muted.ToClass();
// disabled:bg-muted
```

Arbitrary Tailwind variants are available when a named property does not cover the selector:

```csharp
string classes = Variant.Of(Tracking.Wide)
    .Hover
    .DataState("open")
    .ToClass();
// hover:data-[state=open]:tracking-wide
```

`Data`, `Aria`, `Group`, `Peer`, `Has`, `Not`, `Supports`, `Modifier`, and `Custom` are also available from builder instances.

## Use typed component values

`CssValue<TBuilder>` lets a component property accept a builder, an existing class string, or multiple contributors while retaining the utility type:

```csharp
CssValue<DisplayBuilder> display = Display.Flex.OnMd.Grid;

CssValue<DisplayBuilder> combined = CssValue<DisplayBuilder>.For(
    Display.Flex,
    Display.OnMd.Grid,
    "gap-4");

string classValue = combined.ToString();
```

Numeric `CssValue<WidthBuilder>` and `CssValue<HeightBuilder>` values are represented as pixel styles. `WithSelector` associates a generated value with a relative or absolute selector for consumers that support selector-aware styles.

## Escape hatches

Most utility families expose `Token(...)` for an exact or family-prefixed Tailwind token:

```csharp
string width = Width.Token("[42rem]").ToClass();
// w-[42rem]

string display = Display.Token("inline-grid").ToClass();
// inline-grid
```

Token, selector, and custom-modifier methods intentionally do not validate arbitrary Tailwind syntax. Use them with developer-controlled values, not raw user input. Builders are mutable fluent values; create a builder per expression rather than sharing one across threads or requests.

## Flex display migration

`FlexWrap` now controls wrapping only: `FlexWrap.Wrap.ToClass()` returns `flex-wrap`.
It no longer adds `flex`, including at responsive breakpoints or under state variants.
Set `Display.Flex` or `Display.InlineFlex` explicitly on containers that previously relied on that behavior:

```razor
<Div Display="Display.Flex" FlexWrap="FlexWrap.Wrap">
    ...
</Div>
```

For responsive display changes, configure the matching modifier on `Display` explicitly.
`FlexDirection` also emits direction utilities only. For example, `FlexDirection.Col.OnMd.Row` emits `flex-col md:flex-row`; it does not enable flex display at either breakpoint.

To verify Suite against the updated local Builders project before publishing the package,
pass `-p:UseLocalQuarkBuildersProject=true` when building or testing Suite.
Package consumers must upgrade to a release containing this change and migrate implicit display usage together.
## Arbitrary utility tokens

Prefixed Token methods accept a suffix or a complete utility with that prefix:
`GridCols.Token("3")` and `GridCols.Token("grid-cols-3")` both emit `grid-cols-3`.
Use fluent modifiers for variants: `GridCols.OnMd.Token("grid-cols-3")` emits `md:grid-cols-3`.

Layout properties such as direction and wrapping are independent of display.
Composite presets are different: `ListVariant.Inline` deliberately applies
`flex flex-wrap items-center gap-2 list-none p-0`, while `ListVariant.None`
applies `list-none p-0`. Their XML documentation lists these effects.

## Additional Tailwind utility families

The following builders expose named values, `Token(...)`, and responsive/state modifiers:

| Area | Builders |
| --- | --- |
| Transforms | `Translate`, `Skew`, `Perspective`, `PerspectiveOrigin`, `BackfaceVisibility`, `TransformStyle` |
| Outlines | `OutlineWidth`, `OutlineColor` |
| Backgrounds | `BackgroundAttachment`, `BackgroundClip`, `BackgroundOrigin` |
| Typography and lists | `DecorationColor`, `TextIndent`, `FontStretch`, `Content`, `ListStylePosition`, `ListStyleImage` |
| Layout | `Columns`, `BreakBefore`, `BreakAfter`, `BreakInside`, `BoxDecorationBreak` |
| Tables | `BorderCollapse`, `BorderSpacing`, `TableLayout`, `CaptionSide` |
| Effects | `ShadowColor`, `TextShadow`, `TextShadowColor`, `InsetShadow`, `InsetShadowColor`, `InsetRing`, `InsetRingColor` |
| Filters | `Blur`, `Brightness`, `Contrast`, `Saturate`, `BackdropBlur`, `BackdropBrightness`, `BackdropContrast`, `BackdropSaturate` |
| Interaction and transitions | `FieldSizing`, `ColorScheme`, `TransitionBehavior` |

```csharp
Translate.OnX.NegativeHalf.OnMd.OnY.Is4.ToClass();
// -translate-x-1/2 md:translate-y-4

OutlineWidth.OnFocusVisible.Is2.ToClass();
// focus-visible:outline-2

OutlineColor.OnFocusVisible.Blue.Is500.OnDark.Token("white/50").ToClass();
// focus-visible:outline-blue-500 dark:outline-white/50

BackgroundClip.Text.ToClass();
// bg-clip-text

BackdropBlur.Sm.OnMd.Lg.ToClass();
// backdrop-blur-sm md:backdrop-blur-lg

Content.OnBefore.Token("[attr(data-label)]").ToClass();
// before:content-[attr(data-label)]
```

`Translate`, `Skew`, and `BorderSpacing` support `OnX` and `OnY`. Each axis selection
applies to the next utility only. Complete tokens preserve their explicit axis;
suffixes use the selected axis. For example, `Translate.OnX.Token("-[13px]")`
emits `-translate-x-[13px]`. `Translate.None` clears translation on every axis.

Color builders follow the existing color API: `Token(...)` accepts a color suffix,
while `Utility(...)` accepts a complete prefixed class. Semantic colors such as
`Primary` require matching theme colors. Filter strengths use dedicated builders;
`Filter` and `BackdropFilter` provide resets and complete filter expressions.

## Tailwind 4.3 coverage

Additional families cover scrollbars (`ScrollbarWidth`, `ScrollbarGutter`,
`ScrollbarThumbColor`, `ScrollbarTrackColor`), query container declarations
(`ContainerType`), logical sizing (`InlineSize`, `BlockSize` and their min/max
builders), logical positioning (`InsetStart`, `InsetEnd`, `InsetBlockStart`,
`InsetBlockEnd`), `TabSize`, `Zoom`, and `FontFeatureSettings`.

Masks are available through `MaskImage`, `MaskClip`, `MaskComposite`, `MaskMode`,
`MaskOrigin`, `MaskPosition`, `MaskRepeat`, `MaskSize`, and `MaskType`.
The remaining filter families are `DropShadow`, `DropShadowColor`, `Grayscale`,
`HueRotate`, `Invert`, `Sepia`, their applicable backdrop counterparts, and
`BackdropOpacity`.

All palette-enabled color builders support `Mauve`, `Olive`, `Mist`, and `Taupe`.
Padding, margin, scroll padding, scroll margin, border width, and inset builders
support `FromBlockStart` and `FromBlockEnd`.

```csharp
ContainerType.SizeNamed("panel").ToClass(); // @container-size/panel
InlineSize.IsFull.OnMd.Is1of2.ToClass(); // inline-full md:inline-1/2
Padding.FromBlockStart.Is4.ToClass(); // pbs-4
ScrollbarThumbColor.OnDark.Mauve.Is600.ToClass(); // dark:scrollbar-thumb-mauve-600
MaskImage.Linear45.LinearFrom("20%").LinearTo("80%").ToClass();
// mask-linear-45 mask-linear-from-20% mask-linear-to-80%
```

This update intentionally removes obsolete APIs. See [the migration and release
notes](MIGRATION.md) before upgrading or publishing the coordinated packages.
