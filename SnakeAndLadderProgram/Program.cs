using System;

namespace SnakeAndLadderProgram
{
    class Program
    {
        public const int STARTING_POSITION = 0;
        public const int ENDING_POSITION = 100;
        public static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
        static void Main(string[] args)
        {
            int diceNumber = DiceRoll();
        }
    }
}
