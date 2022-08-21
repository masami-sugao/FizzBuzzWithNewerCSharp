namespace FizzBuzz3.FizzBuzzRule {

	public class NonFizzBuzzRule : IFizzBuzzRule {

		// readonly
		public static readonly NonFizzBuzzRule Instance = new NonFizzBuzzRule();

		private NonFizzBuzzRule() {}

		// ref
		public void Judge(int target, ref string outputStr) {
			outputStr = string.IsNullOrEmpty(outputStr) ? target.ToString() : outputStr;
		}

	}
}

