namespace benchmarks.katas;

public class Fibonacci
{
    public static int[] GenerateFibonacciList()
    {
        var length = 10;
        var sequence = new List<int>() { 1, 1 };

        for (var i = 2; i < length; i++)
        {
            sequence.Add(sequence[i - 1] + sequence[i - 2]);
        }

        return sequence.ToArray();
    }

    public static int[] GenerateFibonacci()
    {
        var length = 10;
        var sequence = new int[length];
        sequence[0] = 1;
        sequence[1] = 1;

        for (var i = 2; i < length; i++)
        {
            sequence[i] = sequence[i - 1] + sequence[i - 2];
        }

        return sequence.ToArray();
    }

    public static IEnumerable<int> GenerateFibonacciRecursive()
    {
        static int fib(int n)
        {
            if (n <= 1)
                return n;

            return fib(n - 1) + fib(n - 2);
        }

        var length = 10;

        for (var i = 1; i < length; i++)
        {
            yield return fib(i);
        }
    }
}

