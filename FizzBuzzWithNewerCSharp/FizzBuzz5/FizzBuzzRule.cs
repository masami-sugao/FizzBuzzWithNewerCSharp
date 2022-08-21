using System;

namespace FizzBuzz5 {
	public class FizzBuzzRule {

		private readonly Func<int, bool> condition;
		private readonly string outputStr;

		public FizzBuzzRule(Func<int, bool> condition, string outputStr) {
			this.condition = condition;
			this.outputStr = outputStr;
		}

		public bool Judge(int value, ref string outputStr) {
			var ret = this.condition(value);
			if (ret) {
				outputStr += this.outputStr;
			}

			return ret;
		}

	}
}

