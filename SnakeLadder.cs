using System;

namespace Programming
{
	public class SnakeLadder
	{
		public static void Main(String[] args)
		{
			//variables
			int playerPosition = 0;
			int diceRoll = 0;
			Console.WriteLine("<-------Welcome to the Game of SNAKE & LADDER------->");
           		Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine("Starting Position of the Player = " + playerPosition);
			
			//generating Random numbers from 1 to 6
			Random random = new Random();
		    	diceRoll = random.Next(1, 7);
			
			//Displays Dice Number
            		Console.WriteLine("Dice Number =" + " " + diceRoll);
		}
	}
}
