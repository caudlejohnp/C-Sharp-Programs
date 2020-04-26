using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a color. Red, Yellow, Blue.");
            string answer1 = Console.ReadLine().ToLower();
            
            //WORK IN PROGRESS FOR USER INPUT ERROR
            //if (answer1 != "red","yellow","blue")
            //{
            //    Console.WriteLine("Invalid Entry. Please chose again.");
            //}
            //Console.WriteLine("Please choose another color. Red, Yellow, Blue.");
            string answer2 = Console.ReadLine().ToLower();
            

            Random random = new Random();
            int compChoice1 = random.Next(1, 3);    //computers first choice
            int compChoice2 = random.Next(1, 3);    //computers second choice
            int userChoice1 = 0;                    //place holder for user first choice switch
            int userChoice2 = 0;                    //place holder for users second choice switch
            string compColor1 = string.Empty;       //place holder for computers first choice switch so it can be printed on screen
            string compColor2 = string.Empty;       //place holder for computers second choice switch so it can be printed on screen

            switch (answer1)    //user first choice switch for comparison
            {
                case "red":
                    userChoice1 = 1;
                    break;
                case "yellow":
                    userChoice1 = 2;
                    break;
                case "blue":
                    userChoice1 = 3;
                    break;
            }

            switch (answer2)    //user second choice switch for comparison
            {
                case "red":
                    userChoice2 = 1;
                    break;
                case "yellow":
                    userChoice2 = 2;
                    break;
                case "blue":
                    userChoice2 = 3;
                    break;
            }

            //Player chose the same colors and order as the computer.
            if (compChoice1 == userChoice1 && compChoice2 == userChoice2)
            {
                Console.WriteLine("Congratulations! You win!");
            }

            //Player chose the correct colors but in the wrong order.
            if (compChoice1 == userChoice2 && compChoice2 == userChoice1)
            {
                Console.WriteLine("You chose the correct colors but in the wrong order.");
            }

            //Player got first color correct but not the second
            if (compChoice1 == userChoice1 && compChoice2 != userChoice2)
            {
                Console.WriteLine("1 - 0 You got one color in the correct spot.");
            }

            //Player got second color correct but not first
            if (compChoice1 != userChoice1 && compChoice2 == userChoice2)
            {
                Console.WriteLine("0 - 1 You got one color in the correct spot.");
            }

            //Player did not guess the correct color or order for both guesses
            if (compChoice1 != userChoice1 && compChoice2 != userChoice2)
            {
                Console.WriteLine("0 - 0 You did not get any guesses correct.");
            }

            //Converting what the computer chose so that player can see the computers guesses.
            switch (compChoice1)
            {
                case 1:
                    compColor1 = "Red";
                    break;
                case 2:
                    compColor1 = "Yellow";
                    break;
                case 3:
                    compColor1 = "Blue";
                    break;
            }

            switch (compChoice2)
            {
                case 1:
                    compColor2 = "Red";
                    break;
                case 2:
                    compColor2 = "Yellow";
                    break;
                case 3:
                    compColor2 = "Blue";
                    break;
            }

            //What the computer chose.
            Console.WriteLine("The computer chose " + compColor1 + " and " + compColor2);
            Console.ReadKey();


            
        }

    }
}
