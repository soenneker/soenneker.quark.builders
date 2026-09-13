# Quark builders performance audit

This audit covers the library in this workspace, including the two earlier
optimization passes. Its objective is to remove avoidable work while preserving
existing behavior and public/protected signatures. It is a scoped engineering
audit, not a proof that every possible workload or future runtime is optimal.

## Scope and evidence

- Inventoried all 535 C# source files; reviewed executable behavior by builder
  family, shared helper, factory, rule representation, and composition path.
- Emitted and inspected the enum and Tailwind modifier generator output.
- Exercised construction, chaining, rendering, repeated rendering, side changes,
  palette selection, numeric/custom inputs, variants, and `CssValue` composition.
- Compared 1,473,448 generated cases with the pre-audit assembly: no differences.
  These include public property chains, storage growth, custom/empty/null tokens,
  three cultures, numeric boundaries, palette shades, random variant sequences,
  and class/style/selector combinations.
- Passed all 95 MTP tests, including focused regression tests for the changed
  behaviors.
- Compared 38,821 existing public/protected API entries: none removed. Four
  overloads were added: `CssValue<T>.For()`, `For(object)`, `For(object, object)`,
  and `Add(object)`.
- Measured 54 steady-state scenarios, including chains of 1–64 rules and a
  1/4/16-token by 1/4/16-modifier matrix. Also checked normal tiered JIT execution
  with longer warmups and fresh-process initialization.

The [source inventory](audit-results/source-inventory.json) records every scanned
file and its hash. [Metadata](audit-results/metadata.json) records assembly hashes
and validation totals. Generated-case comparisons preserve baseline behavior;
they do not establish that the baseline was correct for every possible input.

## Changes retained

### Construction and storage

The earlier passes replaced private eager rule lists with inline first-rule
storage and overflow arrays, and converted internal rule objects to readonly
record structs. This removes list/backing-array allocations for single rules and
per-rule object allocations. List-import constructors still copy their inputs.
Growth and side retargeting remain supported.

The public/protected `ResponsiveUtilityBuilder.Rules` field remains a
`List<UtilityRule>`. External subclasses can mutate it directly, so changing its
type, making it lazy, or caching output behind it would affect compatibility.

### Preset initialization

361 factories and 258 equivalent chaining properties now use existing generated
string constants instead of initializing enum instances just to read `.Value`.
The substitutions were restricted to nonempty local constants and equivalent
string construction/chaining paths. Enum-based mappings, identity comparisons,
empty values, and specialized presets were retained where equivalence did not
meet that check. Public enum fields and APIs remain intact.

### Rendering and side formatting

Single plain rules reuse their strings. Multi-rule renderers append modified
tokens into a shared buffer instead of constructing a prefixed string per rule.
The seven size-token builders also reuse single strings and write multi-token
output at its exact length, preserving their different empty-token policies.
Rounded classes avoid nested buffers.

This audit removed substring allocations in margin, padding, border, inset,
scroll-spacing, and gap-axis formatting. Side builders now pass modifiers to the
shared renderer instead of applying them in intermediate `BuildClass` results.
Existing culture-sensitive prefix checks were preserved, including when moving
from strings to spans.

### Modifier expansion

Standalone modifier expansion allocates the final string at its exact length.
For lists of modifiers, it writes the prefix once and copies that prefix for
subsequent tokens. A single normalized token has a direct write path; a single
nonempty modifier uses the existing string-chain renderer. Unicode whitespace,
modifier ordering, and empty-list behavior remain unchanged.

### Palettes and composition

Instance palette selectors retain their original builder through an internal
token-factory interface, eliminating bound delegate allocations. Static palette
selectors retain their existing factory semantics. Deferred selectors still
observe the original builder's pending modifiers.

The new `CssValue` overloads avoid parameter arrays for common calls and avoid
boxing the receiver of `Add(object)`. They preserve trimming, style semicolons,
selector merging, and conflict exceptions. Existing array overloads and the
general pooled composition path remain available. Callers must recompile to
select the new overloads; existing binaries retain their original entry points.

## Incremental measurements

The baseline below is the local version after the second optimization pass,
before this full audit—not the original repository commit. Earlier-pass results
are in [README.md](README.md).

| Scenario | Before ns/op | After ns/op | Before B/op | After B/op |
| --- | ---: | ---: | ---: | ---: |
| Margin side | 48.4 | 33.9 | 216 | 120 |
| Margin responsive | 116.8 | 102.1 | 448 | 344 |
| Padding responsive | 119.0 | 104.2 | 448 | 344 |
| Gap axis | 18.5 | 16.6 | 136 | 112 |
| Color palette chain | 155.5 | 129.6 | 648 | 456 |
| CssValue single | 30.9 | 8.8 | 72 | 0 |
| CssValue add | 41.8 | 20.0 | 128 | 48 |

| Scenario | Before ns/op | After ns/op | Before B/op | After B/op |
| --- | ---: | ---: | ---: | ---: |
| Modifier matrix 1x1 | 31.3 | 24.9 | 48 | 48 |
| Modifier matrix 1x4 | 54.2 | 50.4 | 88 | 88 |
| Modifier matrix 1x16 | 164.3 | 176.5 | 232 | 232 |
| Modifier matrix 4x1 | 84.4 | 55.6 | 128 | 128 |
| Modifier matrix 4x4 | 155.1 | 96.1 | 272 | 272 |
| Modifier matrix 4x16 | 477.7 | 240.8 | 848 | 848 |
| Modifier matrix 16x1 | 281.6 | 210.3 | 440 | 440 |
| Modifier matrix 16x4 | 525.7 | 291.2 | 1016 | 1016 |
| Modifier matrix 16x16 | 1688.3 | 461.7 | 3320 | 3320 |

These are medians across three process runs. Each process reports the median of
seven 100,000-operation samples after warmup. Tiered compilation was disabled for
this comparison. Raw runs and all scenarios, including those without gains, are
in [audit-results](audit-results/) and [summary.json](audit-results/summary.json).
Small timing changes should be treated as noise rather than independent wins.

### Normal JIT configuration

| Scenario | Before ns/op | After ns/op | Before B/op | After B/op |
| --- | ---: | ---: | ---: | ---: |
| Margin side | 35.8 | 30.1 | 216 | 120 |
| Margin responsive | 91.0 | 71.6 | 448 | 344 |
| Color palette | 29.3 | 27.8 | 184 | 184 |
| Color palette chain | 136.1 | 97.3 | 648 | 456 |
| CssValue single | 17.2 | 9.9 | 40 | 0 |
| CssValue add | 25.9 | 12.5 | 80 | 48 |
| CssValue mixed | 85.3 | 74.6 | 216 | 216 |
| Modifier group | 32.4 | 28.1 | 112 | 112 |
| Variant modifiers | 40.1 | 36.3 | 216 | 216 |

Each diagnostic case runs in a separate process with normal tiering and at least
one second of warmup. This avoids carrying one scenario's JIT profile into the
next. The diagnostic is additional evidence, not an application-level throughput
guarantee. Inlining and escape analysis can change allocations relative to the
tiering-disabled table.

### Fresh-process initialization

| First-use preset | Before managed bytes | After managed bytes |
| --- | ---: | ---: |
| TextColor.Primary | 760 | 64 |
| Opacity.Is50 | 1096 | 64 |
| Animation.Spin | 328 | 64 |

The allocation counts agreed across five fresh processes per scenario. Cold
timings also include JIT work and varied; no cold-start time reduction is claimed.
These counters measure managed allocations on the calling thread, not native
JIT memory or total process memory.

## Experiments rejected or limited

- **Inline/lazy modifier storage in `VariantBuilder`:** some initial measurements
  improved, but other JIT configurations lost allocation elision or regressed
  common modified-wrapper cases. The original list representation was retained.
  Modifier rendering itself still benefits from prefix-copy optimization.
- **A general lazy segment writer for `CssValue`:** saved a style-string copy in
  some cases but slowed mixed composition. The general pooled path was restored;
  targeted scalar overloads provide the useful gains without that rewrite.
- **A special single-string modifier concatenation path:** added work to ordinary
  multi-token string rendering. It was removed. Single-token specialization is
  confined to the modifier-list path where it avoids unnecessary rescanning.
- **Aggressive blanket changes:** no builder pooling, global arbitrary-token
  cache, synchronization, package upgrades, or public type changes were introduced.

## Remaining cost model and tradeoffs

| Area | Remaining cost | Why it remains |
| --- | --- | --- |
| Mutable builders | A fresh builder object | Shared mutable preset instances would contaminate independent chains. Struct builders would change API and mutation/boxing behavior. |
| Multi-rule output | A final string and copying its characters | Producing an immutable result requires storage. Rendering cost scales with output length. |
| Repeated modified rendering | A new result string each call | Caching adds retained output and per-builder state, and requires invalidation for every mutation, pending modifier, and protected-list change. |
| Responsive base storage | The protected eager list | Its field type and direct mutation are part of the subclass surface. Smaller capacity trades single-rule savings for more growth allocations. |
| Long chains | Overflow-array growth | Growth is amortized; preallocating for long chains increases short-lived small-builder memory. |
| Pending modifier chains | Intermediate immutable chain strings | Buffering would enlarge every builder and complicate the protected string-chain contract. This needs workload evidence before changing the representation. |
| Fixed palette shades | Selector/token creation where still needed | Global or finite caches trade retained memory and initialization for reuse. Static and instance selectors have different factory semantics. |
| Heterogeneous composition | Boxing/arrays at remaining object-based call sites | Existing signatures are retained. Further typed overloads or span APIs would expand the API; implicit conversions already serve simple typed values. |
| Legacy breakpoint-plus-modifier combination | A temporary string in the uncommon composite fallback | It preserves the historical distinction between prefixing the whole group and prefixing every token, including whitespace behavior. |

These are explicit remaining opportunities and constraints, not a claim that
further improvement is impossible. An application dominated by repeated renders,
very long chains, startup, or one palette family could justify different choices.
That would require workload measurements and an explicit compatibility/memory
budget, rather than asserting a universal fastest representation.

## Reproduction

Measured on Windows x64, .NET SDK 10.0.401, AMD Ryzen Threadripper PRO 9995WX.
The harness is dependency-free; it is not BenchmarkDotNet. Browser layout/paint,
Blazor application throughput, WebAssembly, ARM64, NativeAOT, and other runtimes
were not measured.

```powershell
$env:DOTNET_TieredCompilation = '0'
dotnet run --project benchmarks/Soenneker.Quark.Builders.Benchmarks -c Release
dotnet run --project benchmarks/Soenneker.Quark.Builders.Benchmarks -c Release -- --matrix

Remove-Item Env:DOTNET_TieredCompilation -ErrorAction SilentlyContinue
$env:QUARK_BENCHMARK_WARMUP_MS = '1000'
dotnet run --project benchmarks/Soenneker.Quark.Builders.Benchmarks -c Release -- --filter-exact 'Variant modifiers'

dotnet run --project benchmarks/Soenneker.Quark.Builders.Benchmarks -c Release -- --cold color
dotnet run --project benchmarks/Soenneker.Quark.Builders.Benchmarks -c Release -- --snapshot snapshot.json
dotnet run --project benchmarks/Soenneker.Quark.Builders.Benchmarks -c Release -- --api api.txt
dotnet test --project test/Soenneker.Quark.Builders.Tests -c Release -- --treenode-filter '/*/*/QuarkBuildersTests/*'
```

To compile the same harness against a compatible saved baseline assembly, set
the `BuildersAssembly` MSBuild property to its absolute DLL path and use a separate
`OutputPath`. Recompiling against each assembly lets overload resolution reflect
the API actually available in that version. Run comparison processes sequentially.
Large compatibility snapshots and temporary baseline binaries are not committed.
