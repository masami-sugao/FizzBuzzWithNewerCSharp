namespace FizzBuzz3.FizzBuzzRule {

	public class FizzRule : IFizzBuzzRule {

		private const int Value = 3;

		private const string OutputString = "Fizz";

		// readonly
		public static readonly FizzRule Instance = new FizzRule();

		private FizzRule() {}

		// ref
		public void Judge(int target, ref string outputString) {
			outputString += target % Value == 0 ? OutputString : string.Empty;
		}

	}
}

