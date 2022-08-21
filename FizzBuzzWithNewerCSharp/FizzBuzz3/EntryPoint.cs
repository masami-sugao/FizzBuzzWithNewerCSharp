using FizzBuzz3.FizzBuzzRule;
using System;
using System.Linq;

namespace FizzBuzz3 {
	public class EntryPoint {

		private static readonly IFizzBuzzRule[] rules = { FizzRule.Instance, BuzzRule.Instance, NonFizzBuzzRule.Instance };

		public static void Main(string[] args) {
			Enumerable.Range(1, 100).ToList().ForEach(i => {
				var outputStr = string.Empty;
				Array.ForEach(rules, x => x.Judge(i, ref outputStr));

				Console.WriteLine(outputStr);
			});
		}

	}
}

