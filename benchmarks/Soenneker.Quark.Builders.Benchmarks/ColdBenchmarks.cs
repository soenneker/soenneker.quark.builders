using System.Diagnostics;
using System.Runtime.CompilerServices;
using Soenneker.Quark;

internal static class ColdBenchmarks
{
    public static void Run(string scenario)
    {
        _ = Stopwatch.GetTimestamp();
        long allocated = GC.GetAllocatedBytesForCurrentThread();
        long start = Stopwatch.GetTimestamp();
        string result = Create(scenario);
        long elapsed = Stopwatch.GetTimestamp() - start;
        allocated = GC.GetAllocatedBytesForCurrentThread() - allocated;
        Console.WriteLine($"{scenario} | {elapsed * 1_000_000_000.0 / Stopwatch.Frequency:F0} | {allocated}");
        GC.KeepAlive(result);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string Create(string scenario) => scenario switch
    {
        "color" => TextColor.Primary.ToClass(),
        "opacity" => Opacity.Is50.ToClass(),
        "animation" => Animation.Spin.ToClass(),
        _ => throw new ArgumentException("Unknown cold-start scenario")
    };
}
