using System;

namespace SnakeAndLadderProgram
{
    class Program
    {
        public const int STARTING_POSITION = 0;
        public const int ENDING_POSITION = 100;
        public const int NO_PLAY = 1;
        public const int LADDER = 2;
        public const int SNAKE = 3;
        public static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
        public static int newPosition(int diceNumber)
        {
            int toAdd = 0;
            Random random = new Random();
            int toDo = random.Next(1, 4);
            switch (toDo)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    toAdd = diceNumber;
                    break;
                case SNAKE:
                    toAdd = -diceNumber;
                    break;
            }
            return toAdd;
        }
        static void Main(string[] args)
        {
            int numOnDie = DiceRoll();
            int toAdd = newPosition(numOnDie);
        }
    }
}
