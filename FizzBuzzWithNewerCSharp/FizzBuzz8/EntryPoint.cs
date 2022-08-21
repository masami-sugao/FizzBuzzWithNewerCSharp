using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz8 {
	class EntryPoint {

		static void Main(string[] args) {
			var fizzBuzzCollection= new FizzBuzzElement[100];

			for (var i = 0; i < fizzBuzzCollection.Length; i++) {
				fizzBuzzCollection[i] = new FizzBuzzElement();
			}

			OverwriteMessages(fizzBuzzCollection, 2, "Fizz");
			OverwriteMessages(fizzBuzzCollection, 4, "Buzz");

			fizzBuzzCollection.Select((x, i) => {
				// Null合体代入演算子(C#8.0)
				x.OutputMessage ??= (i + 1).ToString();
				return x;
			}).ToList().ForEach(x => Console.WriteLine(x.OutputMessage));
		}

		private static void OverwriteMessages(IEnumerable<FizzBuzzElement> target, int skipCount, string message) {
			var skipped = target.Skip(skipCount);
			if (skipped.Any()) {
				skipped.First().OutputMessage += message;
				OverwriteMessages(skipped.Skip(1), skipCount, message);
			}
		}

		private class FizzBuzzElement {
			// Null許容参照型(C#8.0)
			public string? OutputMessage { get; set; }
		}

	}
}

