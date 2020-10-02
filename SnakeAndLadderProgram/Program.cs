using System;

namespace SnakeAndLadderProgram
{
    class Program
    {
        public const int STARTING_POSITION = 0;
        public const int ENDING_POSITION = 100;
        static void Main(string[] args)
        {
            int currentPosition = STARTING_POSITION; 
            Console.WriteLine("Welcome to the Snake and Ladder game");
            Console.WriteLine("Player Position: " + currentPosition);
        }
    }
}
