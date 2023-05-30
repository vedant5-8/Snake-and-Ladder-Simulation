using System;
using System.Numerics;

namespace Snake_and_Ladder_Simulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Snake and Ladder Simulator---\n");

            // UC 1 - Snake and game played single player at position 0

            int currentPosition = 0;
            int finalPosition = 100;
            Console.WriteLine("Start Position => " + currentPosition);

            int[] playerPosition = new int[2];
            int currentPlayer = 0;
            int diceRoll = 0;

            // UC 2 - The Player rolls the die to get a number between 1 to 6.

            Random random = new Random();

            while (playerPosition[currentPlayer] < finalPosition)
            {
                int dieRoll = random.Next(1, 7);

                Console.WriteLine("Player " + (currentPlayer + 1) + " roll a die and get => " + dieRoll);

                // UC 3 - The Player then checks for a Option. They are No Play, Ladder or Snake.

                int option = random.Next(1, 4);

                switch (option)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("**No Play**");
                        Console.ResetColor();

                        Console.WriteLine(" The Player Stays in Same Position");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("**Ladder**");
                        Console.ResetColor();

                        Console.WriteLine(" Player" + (currentPlayer + 1) + " Moves Ahead By " + dieRoll + " Positions");
                        
                        if (playerPosition[currentPlayer] + dieRoll <= finalPosition)
                            playerPosition[currentPlayer] += dieRoll;

                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("**Snake**");
                        Console.ResetColor();

                        Console.WriteLine(" Player" + (currentPlayer + 1) + " Moves Behind By " + dieRoll + " Positions");

                        playerPosition[currentPlayer] -= dieRoll;

                        if (playerPosition[currentPlayer] < 0)
                        {
                            playerPosition[currentPlayer] = 0;
                        }

                        break;
                }
                
                if (currentPosition > finalPosition)
                {
                    currentPosition = finalPosition;
                }
                diceRoll++;
                Console.WriteLine("Player " + (currentPlayer + 1) + " current position => " + playerPosition[currentPlayer]);

                if (option != 1)
                {
                    currentPlayer = (currentPlayer + 1) % 2;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCongratulations! Player " + (currentPlayer + 1) + " Has reached to the winning position.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Number of DiceRolls = " + diceRoll);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player " + (currentPlayer + 1) + " wins the game.");
            Console.ResetColor();
        }
    }
}
