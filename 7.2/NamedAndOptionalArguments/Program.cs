using System;

namespace NamedAndOptionalArguments
{
    class Program
    {
        static void Main(string[] args)
        {
		// The method can be called in the normal way, by using  positional arguments.
		PrintOrderDetails("Gift Shop", 31, "Red Mug");

		// Named arguments can be supplied for the parameters in any order.
		PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
		PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);

		// Named arguments mixed with positional arguments are valid
		// as long as they are used in their correct position.
		PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
		PrintOrderDetails(sellerName: "Gift Shop", 31, productName: "Red Mug");	// Ch 7.2 onwards
		PrintOrderDetails("Gift Shop", orderNum: 31, "Red Mug"); 	// C# 7.2 onwards

		// However, mixed arguments are invalid if used out-of-order.
		// The following statements will cause a compiler error.
		// PrintOrderDetails(productName: "Red Mug", 31, "Gift Shop");
		// PrintOrderDetails(31, sellerName: "Gift Shop", "Red Mug");
		// PrintOrderDetails(31, "Red Mug", sellerName: "Gift Shop");

		// Instance anExample does not send an argument for the constructor's optional parameter.
		var anExample = new ExampleClass();
		// The following call to ExampleMethod causes a compiler error, 
		// because an argument is provided for the third parameter but not for the second.
		// anExample.ExampleMethod(3, ,4);

		// However, if you know the name of the third parameter, you can use a named argument to accomplish the task.
		anExample.ExampleMethod(3, optionalint: 4);
		
		anExample.ExampleMethod(1, "One", 1);
		anExample.ExampleMethod(2, "Two");
		anExample.ExampleMethod(3);

		// Instance anotherExample sends an argument for the constructor's optional parameter.
		ExampleClass anotherExample = new ExampleClass("Provided name");
		anotherExample.ExampleMethod(1, "One", 1);
		anotherExample.ExampleMethod(2, "Two");
		anotherExample.ExampleMethod(3);

		// The following statements produce compiler errors.

		// An argument must be supplied for the first parameter, and it must be an integer
		// anExample.ExampleMethod("One", 1);
		// anExample.ExampleMethod();

		// You cannot leave a gap in the provided arguments
		// anExample.ExampleMethod(3, , 4);
		// anExample.ExampleMethod(3, 4);

		// You can use a named parameter to make the last statements work
		anExample.ExampleMethod(3, optionalint: 4);
        }

	private static void PrintOrderDetails(string sellerName, int orderNum, string productName) {
		if (string.IsNullOrWhiteSpace(sellerName)) {
			throw new ArgumentException(message: "Seller name cannot be null or empty.", paramName: nameof(sellerName));
		}

		Console.WriteLine($"Seller: {sellerName}, Order #: {orderNum}, Product: {productName}");
	}
    }
}
