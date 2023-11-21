using BenchmarkDotNet.Running;
using Benchmarks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Benchmarkl start");

        BenchmarkRunner.Run<ParserBenchmark>();
    }
}