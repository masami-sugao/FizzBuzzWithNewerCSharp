using System;
using System.Linq;

namespace FizzBuzzRule4 {
	public class EntryPoint {

		public static void Main(string[] args) {
			new string[100].Select((_, i) => {
				var number = i + 1;
				var ret = (number % 3 == 0 ? "Fizz" : string.Empty) + (number % 5 == 0 ? "Buzz" : string.Empty);
				if (string.IsNullOrEmpty(ret)) ret = number.ToString();
				return ret;
			}).ToList().ForEach(x => Console.WriteLine(x));
		}

	}
}

