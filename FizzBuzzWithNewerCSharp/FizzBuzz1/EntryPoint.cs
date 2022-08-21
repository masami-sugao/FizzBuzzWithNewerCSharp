using System;
using System.Linq;

namespace FizzBuzz1 {

	public class EntryPoint {

		public static void Main(string[] args) {
			Enumerable.Range(1, 100).ToList().ForEach(i =>
				Console.WriteLine(CreateFizzBuzzString(i))
			);
		}

		private static string CreateFizzBuzzString(int value) {
			var fizzBuzz = FizzBuzzRule.Convert(value);

			string outputStr;
			if (fizzBuzz.HasValue) {
				outputStr = FizzBuzzRule.All.Aggregate(string.Empty, (x, next) =>
					x += fizzBuzz.Value.HasFlag(next) ? next.ToString() : string.Empty);
			} else {
				outputStr = value.ToString();
			}

			return outputStr;
		}

	}
}

