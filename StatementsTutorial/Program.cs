using System;

namespace StatementsTutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number: ");
			var aNbr = Console.ReadLine();              // reads the input as a string
			var Nbr = Convert.ToInt32(aNbr);            // converts aNbr from a string to a int
			if (Nbr % 2 == 0) { Console.WriteLine($"the number is even"); }
			else { Console.WriteLine($"the number is odd"); }

			//asks you to enter a number then evaluates if even or odd.

			var ints = new[] { 77, 32, 94, 46, 28 };
			for (var idx = 0; idx < 5; idx++)
			{
				Console.WriteLine($"idx is {idx} and ints[idx] is {ints[idx]}");
			}
			Console.WriteLine(ints[0]);

			var ints1 = new[] { 20, 49, 94, 91, 64, 92, 26, 37, 45, 49 };
			for (var idx = 0; idx < 10; idx++)
			{
				Console.WriteLine($"idx is {idx} and ints[idx] is {ints1[idx]}");
			}
			Console.WriteLine(ints1[0]);

			var ints2 = new[] { 611, 589, 466, 792, 876, 752, 270, 166, 357 };
			for (var idx = 0; idx < 9; idx++)
			{
				Console.WriteLine($"idx is {idx} and ints[idx] is {ints2[idx]}");
			}

			var ints3 = new[] { 2155, 5622, 2974, 2563, 8201, 6627, 3380, 2551 };
			for (var idx = 0; idx < 8; idx++)
			{
				Console.WriteLine($"idx is {idx} and ints[idx] is {ints3[idx]}");
			}
		}
	}
}
