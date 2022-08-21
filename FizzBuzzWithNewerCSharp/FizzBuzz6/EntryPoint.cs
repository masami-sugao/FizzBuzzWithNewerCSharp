using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz6 {
	class EntryPoint {

		private const int OutputCount = 100;
		static void Main(string[] args) {
			var fizzList = CreateRepeatedList(3, "Fizz");
			var buzzList = CreateRepeatedList(5, "Buzz");

			var mergedList = fizzList
								.Zip(buzzList, (fizz, buzz) => fizz + buzz)
								.Select((x, i) => string.IsNullOrEmpty(x) ? (i + 1).ToString() : x);

			mergedList.Take(OutputCount).ToList().ForEach(x => Console.WriteLine(x));
		}

		// Null許容参照型
		private static IEnumerable<string?> CreateRepeatedList(int partsLength, string lastStr) {
			var parts = Enumerable.Repeat<string?>(null, partsLength - 1).Append(lastStr);
			var repeatedList = Enumerable.Repeat(parts, (int)Math.Ceiling((float)OutputCount / parts.Count())).SelectMany(x => x);

			return repeatedList;
		}

	}
}

