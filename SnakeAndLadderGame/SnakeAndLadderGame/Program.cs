using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game...");

            Console.WriteLine("Player is at starting position: START :Roll the Dice");
            Random random = new Random();
            int diceRoll = random.Next(1,7);
            Console.WriteLine("Dice Number :"+diceRoll);
        }
    }
}
