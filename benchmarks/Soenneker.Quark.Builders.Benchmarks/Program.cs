using System.Diagnostics;
using Soenneker.Quark;

if (args is ["--snapshot", var path])
{
    CompatibilitySnapshot.Write(path);
    return;
}
if (args is ["--api", var apiPath])
{
    PublicApi.Write(apiPath);
    return;
}
if (args is ["--cold", var scenario])
{
    ColdBenchmarks.Run(scenario);
    return;
}

// Lightweight, dependency-free comparison harness. Run in Release without a debugger.
// Timings are medians of seven samples; allocations exclude setup and warmup.
CssValue<WidthBuilder> cssBase = "w-auto";
var repeated = Width.Auto.OnMd.Token("full").OnHover.Token("1/2");
(string Name, Func<string> Run)[] cases =
[
    ("Single width", () => Width.Auto.ToClass()),
    ("Single gap", () => Gap.Is2.ToClass()),
    ("Responsive width", () => Width.Auto.OnMd.Token("full").OnHover.Token("1/2").ToClass()),
    ("Responsive button", () => ButtonSize.Default.OnMd.IconSm.ToClass()),
    ("Long chain", () => Width.Auto.Token("1").Token("2").Token("3").Token("4").Token("5").Token("6").Token("7").ToClass()),
    ("Repeated render", repeated.ToClass),
    ("Modifier group", () => BreakpointUtil.ApplyTailwindModifiers("px-2 py-1 text-sm", "md:hover")),
    ("Variant group", () => Variant.Of(ButtonSize.Default).OnHover.ToClass()),
    ("Single check size", () => CheckSizes.Default.ToClass()),
    ("Check size chain", () => CheckSizes.Default.Sm.Lg.ToClass()),
    ("Single input size", () => InputSizes.Default.ToClass()),
    ("Rounded default", () => Rounded.Default.ToClass()),
    ("Rounded chain", () => Rounded.Lg.OnMd.Top.Sm.OnHover.Full.ToClass()),
    ("Margin side", () => Margin.Negative2.FromTop.ToClass()),
    ("Margin responsive", () => Margin.Is2.FromTop.OnMd.Is4.FromBottom.ToClass()),
    ("Padding responsive", () => Padding.Is2.FromTop.OnMd.Is4.FromBottom.ToClass()),
    ("Gap axis", () => Gap.Is2.X.ToClass()),
    ("Color palette", () => TextColor.Red.Is500.ToClass()),
    ("Color palette chain", () => TextColor.Primary.OnHover.Red.Is500.OnMd.Blue.Is600.ToClass()),
    ("Variant empty", () => Variant.Of(Width.Auto).ToClass()),
    ("Variant modifiers", () => Variant.Of(Width.Auto).OnHover.OnFocus.OnMd.ToClass()),
    ("CssValue empty", () => CssValue<WidthBuilder>.For().ToString()),
    ("CssValue single", () => CssValue<WidthBuilder>.For("w-auto").ToString()),
    ("CssValue mixed", () => CssValue<WidthBuilder>.For(Width.Auto, "w-full", 12).ToString()),
    ("CssValue add", () => cssBase.Add("w-full").ToString()),
    ("Numeric factory", () => ColStart.At(12345).ToClass()),
    ("Pending chain", () => Width.OnHover.OnFocus.OnMd.OnDark.Token("full").ToClass())
];
if (args is ["--matrix"])
    cases = MatrixBenchmarks.Create();
if (args is ["--filter", var filter])
    cases = cases.Where(item => item.Name.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToArray();
if (args is ["--filter-exact", var exactFilter])
    cases = cases.Where(item => item.Name.Equals(exactFilter, StringComparison.OrdinalIgnoreCase)).ToArray();
const int iterations = 100_000;
int warmupMilliseconds = int.TryParse(Environment.GetEnvironmentVariable("QUARK_BENCHMARK_WARMUP_MS"), out int requestedWarmup)
    ? Math.Max(0, requestedWarmup) : 0;
Console.WriteLine("Scenario | ns/op | bytes/op");
foreach (var (name, run) in cases)
{
    for (int i = 0; i < 20_000; i++) run();
    if (warmupMilliseconds > 0)
    {
        long warmupStart = Stopwatch.GetTimestamp();
        while (Stopwatch.GetElapsedTime(warmupStart).TotalMilliseconds < warmupMilliseconds)
            for (var i = 0; i < 1_000; i++) run();
    }
    var times = new double[7];
    long bytes = 0;
    string? result = null;
    for (int sample = 0; sample < times.Length; sample++)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        long before = GC.GetAllocatedBytesForCurrentThread();
        long start = Stopwatch.GetTimestamp();
        for (int i = 0; i < iterations; i++) result = run();
        times[sample] = Stopwatch.GetElapsedTime(start).TotalNanoseconds / iterations;
        bytes += GC.GetAllocatedBytesForCurrentThread() - before;
    }
    Array.Sort(times);
    Console.WriteLine($"{name} | {times[3]:F1} | {bytes / (7.0 * iterations):F0}");
    GC.KeepAlive(result);
}

