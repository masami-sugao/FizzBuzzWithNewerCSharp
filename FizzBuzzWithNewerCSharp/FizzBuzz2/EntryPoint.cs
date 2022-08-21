using System;
using System.Linq;

namespace FizzBuzz2 {
	public class EntryPoint {

		private static readonly (int index, string outputStr)[] FizzBuzzRules = { (3, "Fizz"), (5, "Buzz") };

		public static void Main(string[] args) {
			Enumerable.Range(1, 100).ToList().ForEach(i =>
				Console.WriteLine(ToFizzBuzz(i))
			);
		}

		private static string ToFizzBuzz(int value) {
			var fizzBuzz = from x in FizzBuzzRules
							let y = value % x.index == 0 ? x.outputStr : string.Empty
							where !string.IsNullOrEmpty(y)
							select y;

			// 上記と同じ処理のラムダ式バージョン
			//var fizzBuzz = FizzBuzzRules.Select(x => value % x.Item1 == 0 ? x.Item2 : string.Empty)
			//				.Where(x => !string.IsNullOrEmpty(x));

			var ret = string.Join(null, fizzBuzz);
			if (ret.Length == 0) {
				ret = value.ToString();
			}

			return ret;
		}

	}
}

