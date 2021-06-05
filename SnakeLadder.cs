using System;

namespace Programming
{
	public class SnakeLadder
	{
		public static void Main(String[] args)
		{
			//variables
			int diceRoll = 0;
			int[] SnakeArray = { 54, 90, 99 };
			int[] LadderArray = { 9, 40, 67 };
			Console.WriteLine("<-------Welcome to the Game of SNAKE & LADDER------->");
           		Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine("Starting Position of the Player =  0" );
			for (int playerPosition = 1; playerPosition <= 100; playerPosition++)
			{
				//generating Random numbers from 1 to 6
				Random random = new Random();
				diceRoll = random.Next(1, 7);
				//Displays Dice Number
				Console.WriteLine("Dice Number =" + " " + diceRoll);
				playerPosition = playerPosition + diceRoll;
				playerPosition = playerPosition - 1;
				Console.WriteLine("Current Position =" + " " + playerPosition);
				if (diceRoll == 0)
				{
					playerPosition = playerPosition - diceRoll;
					Console.WriteLine("You have to stay on the same position!!");
				}
				if (playerPosition == SnakeArray[0])
				{
					playerPosition = 19;
					Console.WriteLine("OOPS!! IT'S A SNAKE.");
					Console.WriteLine("OOPS!! Now, You are at " + playerPosition + " position.");
				}
				else if (playerPosition == SnakeArray[1])
				{
					playerPosition = 48;
					Console.WriteLine("OOPS!! IT'S A SNAKE.");
					Console.WriteLine("OOPS!! Now, You are at " + playerPosition + " position.");
				}
				else if (playerPosition == SnakeArray[2])
				{
					playerPosition = 77;
					Console.WriteLine("OOPS!! IT'S A SNAKE.");
					Console.WriteLine("OOPS!! Now, You are at " + playerPosition + " position.");

				}
				else if (playerPosition == LadderArray[0])
				{
					playerPosition = 34;
					Console.WriteLine("LUCKY!! YOU GOT A LADDER.");
					Console.WriteLine("YUPP!! Now, You are at " + playerPosition + " position.");
				}
				else if (playerPosition == LadderArray[1])
				{
					playerPosition = 64;
					Console.WriteLine("LUCKY!! YOU GOT A LADDER.");
					Console.WriteLine("YUPP!! Now, You are at " + playerPosition + " position.");
				}
				else if (playerPosition == LadderArray[2])
				{
					playerPosition = 86;
					Console.WriteLine("LUCKY!! YOU GOT A LADDER.");
					Console.WriteLine("YUPP!! Now, You are at " + playerPosition + " position.");
				}

			}
		}
	}
}
