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
