using System;

namespace NamedAndOptionalArguments
{
	public class ExampleClass {
		private string _name;

		// Because the parameter for the constuctor, name, has a default
		// value assigned to it, it is optional
		public ExampleClass(string name = "Default name") {
			_name = name;
		}

		// The first parameter, required, has no default value assigned to it.
		// Therefore, it is not optional. Both operatorstr and optionalint have default values
		// assigned to them. They are optional
		public void ExampleMethod(int required, string optionalstr = "default string", int optionalint = 10) {
			Console.WriteLine("{0}: {1}, {2}, and {3}.", _name, required, optionalstr, optionalint);
		}
	}
}
