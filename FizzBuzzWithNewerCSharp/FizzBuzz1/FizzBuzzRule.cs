using System;
using System.Linq;

namespace FizzBuzz1 {

	public class FizzBuzzRule {

		[Flags]
		public enum FizzBuzzType {
			Fizz = 3,
			Buzz = 5
		}

		public static FizzBuzzType[] All { get; } = Enum.GetValues(typeof(FizzBuzzType)).OfType<FizzBuzzType>().ToArray();

		public static FizzBuzzType? Convert(int value) {
			// Null許容値型(C#8.0)
			FizzBuzzType? ret = All.Aggregate((FizzBuzzType?)null, (current, next) => 
				// switch式(C#8.0)
				(int)next switch {
					int x when value % x == 0 => 
						current switch {
							null => next,
							_ => current | next
						},
					_ => current
				} 
			);

			return ret;
		}

	}
}

