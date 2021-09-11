using System;
using System.Collections.Generic;

namespace A1
{
	class Program
	{
		static void Main(string[] args)
		{
			bool ExitCode;

			do
			{
				Console.WriteLine("Enter the number of cards to pick; 0 = Quit: ");
				string line = Console.ReadLine();
				if (int.TryParse(line, out int numCards))
				{
					foreach (var card in CardPicker.PickSomeCards(numCards))
					{
						Console.WriteLine(card);
					}

					ExitCode = numCards == 0 ? true : false; // Exit the loop if the user entered 0
				}
				else
				{
					Console.WriteLine("Please enter a valid number.");
					ExitCode = false;
				}
			} 
			while (!ExitCode);
		}
	}

	public static class SubsequenceFinder
	{
		/// <summary>
		/// Determines whether a list of integers is a subsequence of another list of integers
		/// </summary>
		/// <param name="seq">The main sequence of integers.</param>
		/// <param name="subseq">The potential subsequence.</param>
		/// <returns>True if subseq is a subsequence of seq and false otherise.</returns>
		public static bool IsValidSubsequeuce(List<int> seq, List<int> subseq)
		{
			foreach (int val in subseq)
			{
				if (seq.Contains(val) is false) // The moment there's a value in the subsequence not found in the sequence, the subsequence is invalid
				{
					return false;
				}
			}

			return true;
		}
	}

	class CardPicker
	{
		static Random random = new Random(1);
		/// <summary>
		/// Picks a random (with replacement) number of cards.
		/// </summary>
		/// <param name="numCards">The number of cards to choose at random.</param>
		/// <returns>An array of strings where each string represents a card.</returns>
		public static string[] PickSomeCards(int numCards)
		{
			string[] PickedCards = new string[numCards];

			for (int i = 0; i < numCards; i++)
            {
				PickedCards[i] = string.Format("{0} of {1}", RandomValue(), RandomSuit());
            }

			return PickedCards;
		}
		/// <summary>
		/// Chooses a random value for a card (Ace, 2, 3, ... , Queen, King)
		/// </summary>
		/// <returns>A string that represents the value of a card</returns>
		private static string RandomValue()
		{
			Dictionary<int, string> CardValue = new Dictionary<int, string>() { { 1, "Ace" }, { 2, "2" }, { 3, "3" }, { 4, "4" }, { 5, "5" }, { 6, "6" }, { 7, "7" }, { 8, "8" }, { 9, "9" }, { 10, "10" }, { 11, "Jack" }, { 12, "Queen" }, { 13, "King" } };

			return CardValue[random.Next(1, 13)];
		}
		/// <summary>
		/// Chooses a random suit for a card (Clubs, Diamonds, Hearts, Spades)
		/// </summary>
		/// <returns>A string that represents the suit of a card.</returns>
		private static string RandomSuit()
		{
			Dictionary<int, string> CardSuit = new Dictionary<int, string>() { {1, "Hearts" }, {2, "Diamonds" }, {3, "Clubs" }, {4, "Spades" } };

			return CardSuit[random.Next(1, 4)];
		}
	}
}
