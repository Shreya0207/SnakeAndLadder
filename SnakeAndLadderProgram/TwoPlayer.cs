using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderProgram
{
    class TwoPlayer
    {
        public const int STARTING_POSITION = 0;
        public const int ENDING_POSITION = 100;
        public const int NO_PLAY = 1;
        public const int LADDER = 2;
        public const int SNAKE = 3;
        public int currentPosition = STARTING_POSITION, nextPosition, throws = 0;
        public int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
        public int newPosition(int diceNumber)
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
        public void playATurn()
        {
            int diceNumber = this.DiceRoll();
            this.throws++;
            int toAdd = this.newPosition(diceNumber);
            if (toAdd > 0)
            {
                this.playATurn();
            }
            if (this.currentPosition + toAdd > ENDING_POSITION)
            {
                this.nextPosition = this.currentPosition;
            }
            else
            {
                this.nextPosition = this.currentPosition + toAdd;
            }
            if (this.nextPosition < STARTING_POSITION)
            {
                this.currentPosition = STARTING_POSITION;
            }
            else
            {
                this.currentPosition = this.nextPosition;
            }
        }
    }
}
            
