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

            // UC 2 - The Player rolls the die to get a number between 1 to 6.

            Random random = new Random();

            int dieRoll = random.Next(1, 7);

            Console.WriteLine("Player roll a die and get => " + dieRoll);

            // UC 3 - The Player then checks for a Option. They are No Play, Ladder or Snake.

            int option = random.Next(1, 4);

            switch (option)
            {
                case 1: 
                    Console.WriteLine("No Play. \nThe Player Stays in Same Position");
                    break;
                case 2:
                    Console.WriteLine("Ladder. \nThe Player Moves Ahead By " + dieRoll + " Positions");
                    currentPosition += dieRoll;
                    break;
                case 3:
                    Console.WriteLine("Snake. \nThe Player Moves Behind By " + dieRoll + " Positions");
                    currentPosition -= dieRoll;
                    break;
            }

            if (currentPosition < 0)
            {
                currentPosition = 0;
            }

            Console.WriteLine("Current Position = " + currentPosition);

        }
    }
}
