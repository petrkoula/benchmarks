using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class ParserBenchmark {

    const string date = "20023-02-12";
    private static readonly DateParser parser = new();

    [Benchmark]
    public void GetYearFromDate(DateOnly date)
    {
        parser.GetYearFromDate(date);
    }

    [Benchmark]
    public void GetYearFromDate2(DateOnly date)
    {
        
    }
}

public class DateParser
{
    public DateParser()
    {
    }

    public void GetYearFromDate(DateOnly date)
    {
    }
}