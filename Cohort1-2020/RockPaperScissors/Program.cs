using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareHands();
        }

        static void CompareHands()
        {
            Random random = new Random();
            int compHand = random.Next(1, 3);

            Console.WriteLine("Choose rock, paper, or scissor");
            string answer = Console.ReadLine().ToLower();

            Console.WriteLine("The computer chose " + compHand);

            int playerHand = 0;

            switch (answer)
            {
                case "rock":
                    playerHand = 1;
                    break;
                case "paper":
                    playerHand = 2;
                    break;
                case "scissor":
                    playerHand = 3;
                    break;
            }

            if (compHand == 1) //Computer chose ROCK
            {
                if (playerHand == 1) //Player chose ROCK
                {
                    Console.WriteLine("You Tied.");
                }
                else if (playerHand == 2) //Player chose PAPER
                {
                    Console.WriteLine("Player won.");
                }
                else if (playerHand == 3) //Player chose SCISSORS
                {
                    Console.WriteLine("Computer won.");
                }    
            }

            if (compHand == 2) // Computer chose PAPER
            {
                if (playerHand == 1) //Player chose ROCK
                {
                    Console.WriteLine("Computer won.");
                }
                else if (playerHand == 2) //Player chose PAPER
                {
                    Console.WriteLine("You tied.");
                }
                else if (playerHand == 3) //Player chose SCISSORS
                {
                    Console.WriteLine("Player won.");
                }

            }

            if (compHand == 3) //Computer chose SCISSORS
            {
                if (playerHand == 1) //Player chose ROCK
                {
                    Console.WriteLine("Player won.");
                }
                else if (playerHand == 2) //Player chose PAPER
                {
                    Console.WriteLine("Computer won.");
                }
                else if (playerHand == 3) //Player chose SCISSORS
                {
                    Console.WriteLine("You tied.");
                }
            }
        }
    }
}