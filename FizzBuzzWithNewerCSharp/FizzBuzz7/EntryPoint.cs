using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz7
{
    class EntryPoint {

		private const int OutputCount = 100;
		static void Main(string[] args) {
			var fizzListSource = CreateSourceList(3, "Fizz");
			var buzzListSource = CreateSourceList(5, "Buzz");

			var fizzBuzzList = fizzListSource.Join(
									buzzListSource, 
									fizz => fizz.index, 
									buzz => buzz.index, 
									(fizz, buzz) => (fizz.index, outputStr: fizz.outputStr + buzz.outputStr));

			var fizzList = fizzListSource.Where(x => fizzBuzzList.Count(y => x.index == y.index) == 0);
			var buzzList = buzzListSource.Where(x => fizzBuzzList.Count(y => x.index == y.index) == 0);
			var numberedList = Enumerable.Range(1, OutputCount)
				.Where(x => fizzList.Count(y => x == y.index) == 0 
					&& buzzList.Count(y => x == y.index) == 0
					&& fizzBuzzList.Count(y => x == y.index) == 0)
				.Select(i => (index: i, outputStr: i.ToString()));

			fizzList
				.Concat(buzzList)
				.Concat(fizzBuzzList)
				.Concat(numberedList)
				.OrderBy(x => x.index)
				.ToList()
				.ForEach(x => Console.WriteLine(x.outputStr));
		}

		private static List<(int index, string outputStr)> CreateSourceList(int multiplier, string outputStr) {
			var ret = new List<(int, string)>();

			// 静的ローカル関数(C#8.0)
			static int multiple(int value, int multiplier) => value * multiplier;

			for (int i = 1; multiple(i, multiplier) <= OutputCount; i++) {
				ret.Add((multiple(i, multiplier), outputStr));
			}

			return ret;
		}

	}
}

