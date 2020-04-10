using System;

namespace manyMethodsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Addition();
            CatDog();
            OddEven();
            Inches();
            Echo();
            Kilograms();
            Date();
            Age();
            Guess();

        }

        public static void Hello()
        {
            Console.WriteLine("Hello, what is your name?");
            string answer = Console.ReadLine();
            Console.WriteLine("Greetings " + answer);
            Console.WriteLine("Goodbye " + answer);
        }

        public static void Addition()
        {
            Console.WriteLine("Give me a number");
            string answer = Console.ReadLine();
            int first = Convert.ToInt32(answer);

            Console.WriteLine("Give me a second number and I will give you the sum.");
            string secAnswer = Console.ReadLine();
            int second = Convert.ToInt32(secAnswer);

            Console.WriteLine("There sum is " + (first + second));
        }

        public static void CatDog()
        {
            Console.WriteLine("Do you prefer cats or dogs?");
            string answer = Console.ReadLine();
            string lowAnswer = answer.ToLower();

            if (lowAnswer == "cats")
            {
                Console.WriteLine("Meow!");
            }
            else if (lowAnswer == "dogs")
            {
                Console.WriteLine("Woof!");
            }
        }

        public static void OddEven()
        {
            Console.WriteLine("Tell me a number and I will tell you if it is even or odd.");
            string answer = Console.ReadLine();
            int numAnswer = Convert.ToInt32(answer);

            if (numAnswer % 2 == 0)
            {
                Console.WriteLine("That number is even.");
            }

            else if (numAnswer % 2 != 0)
            {
                Console.WriteLine("That number is odd.");
            }
        }

        public static void Inches()
        {
            Console.WriteLine("How tall are you to the nearest foot?");
            string answer = Console.ReadLine();
            int numAnswer = Convert.ToInt32(answer);
            Console.WriteLine("That is " + (numAnswer * 12) + " inches");
        }

        public static void Echo()
        {
            Console.WriteLine("Tell me a word and I shall see it echoed!");
            string answer = Console.ReadLine().ToUpper();
            Console.WriteLine(answer);
            string lowAnswer = answer.ToLower();
            Console.WriteLine(lowAnswer);
            Console.WriteLine(lowAnswer);
        }

        public static void Kilograms()
        {
            Console.WriteLine("If you tell me your weight I will convert it to kilograms.");
            string answer = Console.ReadLine();
            int kilo = Convert.ToInt32(answer);
            Console.WriteLine("That is " + (kilo / 2.2) + " kilograms");
        }

        public static void Date()
        {
            Console.WriteLine("Would you like to know todays date y/n");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("Todays date is ");
                Console.WriteLine(DateTime.Today.ToString("MM-dd-yyyy"));
            }
            else if (answer == "n")
            {
                Console.WriteLine("Very well.");
            }
        }

        public static void Age()
        {
            Console.WriteLine("What year were you born?");
            string answer = Console.ReadLine();
            int born = Convert.ToInt32(answer);
            Console.WriteLine("You are " + (2020 - born) + " years old.");
        }

        public static void Guess()
        {
            Console.WriteLine("Guess a word.");
            string answer = Console.ReadLine().ToLower();

            if (answer == "CSHARP")
            {
                Console.WriteLine("Woo!!! That is correct.");
            }
            else if (answer != "CSHARP")
            {
                Console.WriteLine("That is wrong.");
                Console.WriteLine("Would you like to try again? y/n");
                string again = Console.ReadLine().ToUpper();

                if (again == "y")
                {
                    Guess();
                }
                else if (again == "n")
                {
                    Console.WriteLine("Quitter!!!");
                }
            }

            Console.ReadKey();
        }

    }
}
