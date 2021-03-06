using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        public const int NO_PLAY = 0;
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        static void Main(string[]args)
        {
            int playerPosition =0 ;
              
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice Number :" + diceRoll);

            Random random1 = new Random();
            int optionCheck = random1.Next(0, 3);
            Console.WriteLine("Option " + optionCheck);
            switch (optionCheck)
            {
                case NO_PLAY:
                    playerPosition = 0;
                    break;
                case IS_LADDER:
                   playerPosition += diceRoll;
                    break;
                case IS_SNAKE:
                    playerPosition -= diceRoll;
                    break;
            }
            Console.WriteLine("Player Position :" +playerPosition);
        }
    }
}
