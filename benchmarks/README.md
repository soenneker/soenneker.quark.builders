# Builder performance

Run the dependency-free comparison harness in Release without a debugger:

```powershell
$env:DOTNET_TieredCompilation = '0'
dotnet run --project benchmarks/Soenneker.Quark.Builders.Benchmarks -c Release
```

Each scenario warms up for 20,000 operations, then reports the median of seven
100,000-operation samples. Allocation measurements use
`GC.GetAllocatedBytesForCurrentThread`; setup and warmup are excluded. Disabling
tiered compilation prevents compilation transitions from dominating these short
samples. This is a local microbenchmark, not an application throughput guarantee.
For application profiling, also measure the actual workload with its normal JIT
settings.

## Local comparison

Measured on Windows x64, .NET SDK 10.0.401, against commit
`70c0d79` on September 12, 2026. Both versions used the same harness and settings.
Times vary between runs; allocation reductions are the more stable result.

| Scenario | Before ns/op | After ns/op | Before bytes/op | After bytes/op |
| --- | ---: | ---: | ---: | ---: |
| Single width | 13.8 | 5.7 | 160 | 64 |
| Single gap | 14.6 | 7.3 | 216 | 72 |
| Responsive width | 132.5 | 102.7 | 480 | 312 |
| Responsive button | 188.5 | 155.0 | 808 | 576 |
| Eight-rule width chain | 224.1 | 220.4 | 848 | 672 |
| Repeated render | 76.0 | 46.2 | 168 | 80 |
| Modifier group | 49.9 | 38.7 | 112 | 112 |
| Variant group | 172.0 | 163.3 | 536 | 464 |

Private rule collections store their first rule inline and allocate an overflow
array only for longer chains. Internal rule records are value types, removing
per-rule objects. The common renderers return single classes directly and append
modified tokens into one buffer for longer chains. Standalone modifier expansion
allocates its final string at the exact required length.

The protected `ResponsiveUtilityBuilder.Rules` list retains its original type and
mutability for subclass compatibility. Render results are not cached: builders
remain mutable, including side retargeting and pending modifiers. No global token
cache or retained pooled storage is introduced.

## Second optimization pass

These are incremental results against the already-optimized first pass, using
the same settings and a saved copy of its compiled assembly:

| Scenario | First pass ns/op | Second pass ns/op | First pass bytes/op | Second pass bytes/op |
| --- | ---: | ---: | ---: | ---: |
| Single check size | 23.3 | 7.9 | 152 | 40 |
| Three-token check size chain | 42.4 | 25.4 | 192 | 168 |
| Single input size | 18.9 | 8.0 | 112 | 40 |
| Rounded default | 21.5 | 8.4 | 128 | 88 |
| Responsive rounded chain | 153.7 | 99.4 | 584 | 464 |

The seven size-token builders now also keep their first token inline. Single
tokens return directly; multiple tokens are written into one exactly-sized
string. Each builder retains its existing treatment of empty tokens. Rounded
classes use direct string construction and the shared class writer, eliminating
nested pooled buffers and intermediate modifier strings for chains. Default
`rounded` returns the literal without constructing a new string.

The unchanged benchmark scenarios retain their previous allocations; small
timing differences there are run-to-run noise, not additional improvements.

## Compatibility checks

The 95 MTP tests include whitespace normalization, empty modifiers, long chains,
mutation after rendering, protected rule-list mutation, size-token storage growth,
and rounded positions and custom values:

```powershell
dotnet test --project test/Soenneker.Quark.Builders.Tests -c Release -- --treenode-filter '/*/*/QuarkBuildersTests/*'
```

The harness can also snapshot public factory properties, fluent property steps,
and longer chains that render between mutations:

```powershell
dotnet run --project benchmarks/Soenneker.Quark.Builders.Benchmarks -c Release -- --snapshot snapshot.json
```

Run the same harness against each revision and compare the resulting JSON
dictionaries. The original and first-pass versions matched in all 1,460,150 cases;
the first and second passes also matched in all 1,460,150 cases.
Snapshots also capture exception types, so they check compatibility rather than
asserting that every factory combination is valid. These snapshots are large and
should not be committed. Parameterized methods are covered by the test suite;
the snapshot does not exhaust every possible user-supplied input.

## Full audit

See [PERFORMANCE-AUDIT.md](PERFORMANCE-AUDIT.md) for the full audit, additional
optimizations, all measurement settings, rejected experiments, and remaining
tradeoffs. The final expanded compatibility comparison matches 1,473,448 cases
with no removed public/protected API entries.
