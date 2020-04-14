using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[] { "red", "yellow", "blue" };
            List<string> compChoice = new List<string>();
            List<string> userColor = new List<string>();
            Random random = new Random();
            int compColor = random.Next(2, 3);

            //Checking for win
            if (userColor[0].Equals(compChoice[0]) && userColor[1].Equals(compChoice[1]))
            {
                Console.WriteLine("Correct! Outstanding job.");
                break;
            }
            //One color matches and is in the correct position
            else if (userColor[0].Equals(compChoice[0]) || userColor[1].Equals(compChoice[1]))
            {
                Console.WriteLine("\n - 1. You guessed one of the colors in the correct position.");
                Console.WriteLine();
            }
            //One color is correct
            else if (userColor[0].Contains(compChoice[0]) || userColor[1].Contains(compChoice[1]))
            {
                //Checking if colors are correct but position incorrect
                if (userColor[0].Equals(compChoice[1]) || userColor[1].Equals(compChoice[0]))
                {
                    Console.WriteLine("\n2 - 0. You guessed the correct colors but the position was wrong.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\n1 - 0. You guessed one of the colors correctly but got the wrong position.");
                    Console.WriteLine();
                }
            }
            //no matching colors
            else
            {
                Console.WriteLine("\n0 - 0. You did not guess any correct color.");
            }

            Console.WriteLine("\nWould you like to play again? y/n");
            isPlaying = Console.ReadLine().ToUpper().Contains("Y") ? true : false;
        }

            Console.WriteLine("Goodbye");
            Console.ReadKey();

    }
}
