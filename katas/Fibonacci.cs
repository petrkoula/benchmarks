using System;
using System.Collections.Generic;

namespace benchmarks.katas;

public class Fibonacci
{
	public static int[] GenerateFibonacci()
	{
		var length = 10;
		var sequence = new List<int>() {1, 1};

		for(var i = 2; i< length;i++)
		{
			sequence.Add(sequence[i - 1] + sequence[i - 2]);
		}

		return sequence.ToArray();
    }
}

