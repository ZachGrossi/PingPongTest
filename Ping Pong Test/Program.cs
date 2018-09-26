using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ping_Pong_Test
{
	public class Program
	{
		/// <summary>
		/// The first multiple to test for
		/// </summary>
		public const int FirstMultiple = 3;

		/// <summary>
		/// The string to print when the number to be printed is a multiple of 3
		/// </summary>
		public const string FirstMultipleString = "Ping";

		/// <summary>
		/// The second multiple to test for
		/// </summary>
		public const int SecondMultiple = 5;

		/// <summary>
		/// The string to print when the number to be printed is a multiple of 5
		/// </summary>
		public const string SecondMultipleString = "Pong";

		/// <summary>
		/// Print the numbers 1 - 100. If number is a multiple of 3, print "Ping". If a multiple of 5, print "Pong".
		/// If multiple of both, print "PingPong". If not a multiple of either, print the number.
		/// </summary>
		/// <param name="args">N/A</param>
		public static void Main(string[] args)
		{
			PrintNumbers(1, 100);

			// Wait for exit
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		/// <summary>
		/// Print the range of numbers from startingNumber to finalNumber. If a multiple of FirstMultiple,
		/// print FirstMultipleString. If a multiple of SecondMultiple, print SecondMultipleString. If a multiple of both,
		/// print both strings. If not a multiple of either, print the number.
		/// </summary>
		/// <param name="startingNumber">The first number in the range to analyze</param>
		/// <param name="finalNumber">The last number in the range to analyze</param>
		public static void PrintNumbers(int startingNumber, int finalNumber)
		{
			// Start by checking that the input numbers are valid
			if (startingNumber > finalNumber)
			{
				Console.WriteLine("Start: {0}, Final: {1} - Starting number greater than final number. Skipping.",
					startingNumber, finalNumber);
				return;
			}

			// Start loop, printing each number (or string) and incrementing by 1 each execution
			for (int num = startingNumber; num <= finalNumber; num++)
			{
				bool printString = false;

				// Check for the first multiple
				if (num % FirstMultiple == 0)
				{
					Console.Write(FirstMultipleString);
					printString = true;
				}

				// Check for the second multiple
				if (num % SecondMultiple == 0)
				{
					Console.Write(SecondMultipleString);
					printString = true;
				}

				// If we haven't printed a string yet, print the number
				if (!printString) { Console.Write(num); }

				Console.WriteLine();
			}
		}
	}
}
