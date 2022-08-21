namespace FizzBuzz3.FizzBuzzRule {

	public class BuzzRule : IFizzBuzzRule {

		private const int Value = 5;

		private const string OutputString = "Buzz";

		// readonly
		public static readonly BuzzRule Instance = new BuzzRule();

		private BuzzRule() {}

		// ref
		public void Judge(int target, ref string outputString) {
			outputString += target % Value == 0 ? OutputString : string.Empty;
		}

	}
}

