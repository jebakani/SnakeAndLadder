using System;

namespace SnakeAndLadder
{
    class Program
    {

        /// <summary>
        /// Snake and Ladder computation
        /// UC1-Initialize player and Initial position
        /// UC2- Generating Die Roll using Random class
        /// UC3- Checking whether to move forward backward based on player choice
        /// </summary>
        /// <param name="args">The arguments.</param>
        

        const int LADDER = 2;
        const int SNAKE = 1;
        const int NO_PLAY = 0;
        const int WIN = 100;

       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder World");

            //initializing local variable where no. of player is 1 and initial position is 0
            int player = 1;
            int playerPos = 0;
            //creating object for Random class
            Random random = new Random();

            while (playerPos < WIN)
            {
                //Generating DieRoll using Next method
                int dieRoll = random.Next(1, 7);

                //Generating the player choice
                int playerChoice = random.Next(0, 3);

                //current position of player
                playerPos = PlayerChoice(playerChoice, playerPos, dieRoll);
                Console.WriteLine("Player Position:" + playerPos);


            }

            
            Console.Read();
        }

        //method check whether snake or ladder
        public static int PlayerChoice(int choice,int pos,int die)
        {
            switch(choice)
            {
                case LADDER:
                    pos += die;
                    break;
                case SNAKE:
                    pos -= die;
                    break;
                default:
                    break;
            }
            if(pos<0)
            {
                pos = 0;
            }
            return pos;
        }

        
    }
}
