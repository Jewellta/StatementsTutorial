using System;

namespace StatementsTutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Enter a number: ");
			//var aNbr = Console.ReadLine();              // reads the input as a string
			//var Nbr = Convert.ToInt32(aNbr);            // converts aNbr from a string to a int
			//if (Nbr % 2 == 0) { Console.WriteLine($"the number is even"); }
			//else { Console.WriteLine($"the number is odd"); }

			////asks you to enter a number then evaluates if even or odd.
			/*
			var ints3 = new[] { 2155, 5622, 2974, 2563, 8201, 6627, 3380, 2551 };
			var ints2 = new[] { 611, 589, 466, 792, 876, 752, 270, 166, 357 };
			var ints1 = new[] { 20, 49, 94, 91, 64, 92, 26, 37, 45, 49 };
			*/

			//var ints = new[] { 77, 32, 94, 46, 28 };
			//for (var idx = 0; idx < 5; idx++)
			//{
			//	Console.WriteLine($"idx is {idx} and ints[idx] is {ints[idx]}");
			//}
			//Console.WriteLine(ints[0]);
			//var total1 = 0;

			//for (var idx = 0; idx < ints1.Length; idx++)
			//{
			//	if (ints1[idx] % 2 == 0)
			//	{
			//		total1 = total1 + ints1[idx];
			//	}
			//}
			//Console.WriteLine($"the total of array 1 is {total1}");


			//var total = 0;
			//for (var idx = 0; idx < ints2.Length; idx++)
			//{
			//	total = total + ints2[idx];
			//}
			//Console.WriteLine($"Total of ints2 is {total}");

			//var total3 = 0;
			//for (var idx = 0; idx < ints3.Length; idx++)
			//{
			//	if (ints3[idx] % 2 == 1)
			//	{
			//		total3 = total3 + ints3[idx];
			//	}
			//}
			//Console.WriteLine($"The total of array 3 is {total3}");
			////counts the array length for you

			/*
			var sum = 0;
		foreach(var i in ints2){
				if (i % 3 == 0)
				{
					sum += i;
				}
			}
			Console.WriteLine($"Sum is {sum}"); */

			/*
			var thriller = new Song
			
			 {
				Title = "Thriller",
				Artist = "Michael Jackson",
				Genre = "Pop",
				Released = new DateTime(1984, 6, 1),
				Platinum = true
			};
			var thunderstruck = new Song
			{
				Title = "Thunderstruck",
				Artist = "ACDC",
				Genre = "Rock",
				Released = new DateTime(1973, 1, 5),
				Platinum = true
			};
			var wastedOnTheWay = new Song
			{
				Title = "Wasted On The Way",
				Artist = "Crosby, Stills, @ Nash",
				Genre = "Folk",
				Released = new DateTime(1972, 2, 5),
				Platinum = false
			};

			var Songs = new Song[]
			{
				thriller, thunderstruck, wastedOnTheWay
			};
			foreach (var song in Songs)
			{
				if (song.Platinum == true)
				{
					Console.WriteLine($"This is the  {song.Title}");
				}
			}
			*/
			/*
			var nbr = 1;
			while(nbr <= 25)
			{	if(nbr% 2 != 0) {
					Console.WriteLine($"The number is {nbr*nbr*nbr}"); }
				nbr += 2;
			} */
			/*
			var stateCode = "OH";
			var stateName = "";
			switch (stateCode)
			{
				case "IN": stateName = "Indiana";break;
				case "OH": stateName = "Ohio"; break;
				case "KY": stateName = "Kentucky";break;
				default:
					stateName = "not found";break;
			}
			Console.WriteLine($"The state code is {stateCode}, name is {stateName}");     */


			/*
			var stateCode = "OH";
			var stateName = stateCode switch
			{
				"OH" => "Ohio",
				"KY" => "Kentucky",
				"IN" => "Indiana",
				_ => "Not Found"
			}; */


			/*
			var trafficLight = "red";
			var command = (trafficLight == "red") ? "Stop" : "Go";
			{
				Console.WriteLine($"sign says {command}");
			} */

			for (var FB = 1; FB <= 30; FB++)
			{
				if (FB % 3 == 0 && FB % 5 != 0)
				{
					Console.WriteLine($"FIZZ");
				}

				else if (FB % 5 == 0 && FB % 3 != 0)
				{
					Console.WriteLine($"BUZZ");

				}
				else if (FB % 5 == 0 && FB % 3 == 0)
				{
					Console.WriteLine($"FIZZBUZZ");
				}
				else Console.WriteLine($"number is {FB}");
			}
		}
	}
}
