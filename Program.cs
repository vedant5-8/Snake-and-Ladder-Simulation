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

            int dieRoll = random.Next(1, 6);

            Console.WriteLine("Player roll a die and get => " + dieRoll);

        }
    }
}
