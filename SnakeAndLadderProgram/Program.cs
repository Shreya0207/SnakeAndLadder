using System;

namespace SnakeAndLadderProgram
{
    class Program
    {
        public const int ENDING_POSITION = 100;
        static void Main(string[] args)
        {
            TwoPlayer player1 = new TwoPlayer();
            TwoPlayer player2 = new TwoPlayer();
            while (player1.currentPosition < ENDING_POSITION && player2.currentPosition < ENDING_POSITION)
            {
                player1.playATurn();
                player2.playATurn();
            }
            if (player1.currentPosition == ENDING_POSITION)
            {
                Console.WriteLine("Player 1 Won");
            }
            else
            {
                Console.WriteLine("Player 2 Won");
            }
            Console.WriteLine("Final Position of Player 1 :" + player1.currentPosition);
            Console.WriteLine("Final Position of Player 2 :" + player2.currentPosition);
        }
    }
}
