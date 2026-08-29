[![](https://img.shields.io/nuget/v/soenneker.quark.builders.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.builders/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.builders/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.builders/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.builders.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.builders/)

# Soenneker.Quark.Builders

Interface for CSS builders that can generate CSS classes and styles.

## Install

```bash
dotnet add package Soenneker.Quark.Builders
```

## Quick start

```csharp
using Soenneker.Quark;

ICssBuilder cssBuilder = /* resolve from DI */;
var result = cssBuilder.ToClass();
```

Gets the CSS class string for the current configuration.

## What you get

- `ICssBuilder` — Interface for CSS builders that can generate CSS classes and styles.
- `AccentColor` — Static utility for accent color. Tailwind: accent-*.
- `Animation` — Simplified animation utility with fluent API and Tailwind/shadcn-aligned fluent API.
- `Appearance` — Represents the appearance.
- `AspectRatio` — Simplified aspect ratio utility with fluent API and Tailwind/shadcn-aligned fluent API.
- `AutoCols` — Represents the auto cols.
- `AutoRows` — Represents the auto rows.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `AccentColor.Auto` | `auto` — browser-default sizing/behavior for the underlying utility. | `auto` — browser-default sizing/behavior for the underlying utility. |
| `AccentColor.Primary` | `accent-primary` — uses your theme primary (shadcn maps this to CSS variables). | `accent-primary` — uses your theme primary (shadcn maps this to CSS variables). |
| `AccentColor.Transparent` | Fully transparent color (`transparent`). | Fully transparent color (`transparent`). |
| `AccentColor.Current` | `currentColor` — uses the element’s computed `color` (common for icons and rings). | `currentColor` — uses the element’s computed `color` (common for icons and rings). |
| `AccentColor.Token(token)` | Creates an accent color builder from a Tailwind color token suffix such as `blue-500` or `[var(--brand)]`. | The same builder instance, so additional classes or variants can be chained. |
| `AccentColor.Utility(utility)` | Passes through a fully-prefixed Tailwind utility such as `accent-blue-500`. | The same builder instance, so additional classes or variants can be chained. |
| `Animation.None` | No animation (none). | No animation (none). |
| `Animation.Spin` | Spin animation (spin). | Spin animation (spin). |
| `Animation.Ping` | Ping animation (ping). | Ping animation (ping). |
| `Animation.Pulse` | Pulse animation (pulse). | Pulse animation (pulse). |
| `Animation.Bounce` | Bounce animation (bounce). | Bounce animation (bounce). |
| `Appearance.None` | Gets or sets none. | Gets or sets none. |
| `Appearance.Auto` | Gets or sets auto. | Gets or sets auto. |
| `Appearance.Token(value)` | Adds an arbitrary appearance utility token to the class list. | The same builder instance, so additional classes or variants can be chained. |
| `AspectRatio.R1X1` | 1:1 aspect ratio (square). | 1:1 aspect ratio (square). |
| `AspectRatio.R4X3` | 4:3 aspect ratio. | 4:3 aspect ratio. |
| `AspectRatio.R16X9` | 16:9 aspect ratio. | 16:9 aspect ratio. |
| `AspectRatio.R21X9` | 21:9 aspect ratio. | 21:9 aspect ratio. |
