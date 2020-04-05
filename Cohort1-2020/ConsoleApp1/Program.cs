using System;

namespace Cohort1_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Addition();
            CatDog();
            OddEvent();
            Inches();
            Echo();
            KillGrams();
            Date();
            Age();
            Guess();
        }

        public static void Hello()
        {
            Console.WriteLine("Hello, what is your name?");
            string answer = Console.ReadLine();
            Console.WriteLine("Bye" + " " + answer);
        }

        public static void Addition()
        {
            Console.WriteLine("Enter a number");
            string answer = Console.ReadLine();
            Console.WriteLine("Now enter another number and I will give you there sum.");
            string secondAnswer = Console.ReadLine();

            int first = Convert.ToInt32(answer);
            int second = Convert.ToInt32(secondAnswer);
            Console.WriteLine("The sum is " + (first + second));
        }

        public static void CatDog()
        {
            Console.WriteLine("Are you a cat person or a dog person");
            string pet = Console.ReadLine();

            string animal = pet.ToLower();

            if (animal == "cat")
            {
                Console.WriteLine("Meow!");
            }
            else if (animal == "dog")
            {
                Console.WriteLine("Woof");
            }
        }

        public static void OddEvent()
        {
        

            Console.WriteLine("Please enter a number and I will tell you if it is odd or even.");
            string number = Console.ReadLine();
            int newNumber = Convert.ToInt32(number);

            if (newNumber % 2 == 0)
            {
                Console.WriteLine("Thats an even number");
            }
            else if (newNumber % 2 != 0)
            {
                Console.WriteLine("That is an odd number");
            }
        }

        public static void Inches()
        {
            Console.WriteLine("Give me your height in feet and I will convert it into inches?");
            string biggin = Console.ReadLine();
            int height = Convert.ToInt32(biggin);
            Console.WriteLine(height * 12 + " inches.");
        }

        public static void Echo()
        {
            Console.WriteLine("Type a word and it shall be echoed");
            string echo = Console.ReadLine();
            string bigEcho = echo.ToUpper();
            Console.WriteLine(bigEcho);
            string lilEcho = bigEcho.ToLower();
            Console.WriteLine(lilEcho);
            Console.WriteLine(lilEcho);
        }

        public static void KillGrams()
        {
            Console.WriteLine("Tell me how many pounds you weigh and I will convert it into kilograms.");
            string weight = Console.ReadLine();
            int intWeight = Convert.ToInt32(weight);
            Console.WriteLine(intWeight / 2.20 + " kilograms");

        }

        public static void Date()
        {
            Console.WriteLine("Would you like to know todays date y/n");
            string date = Console.ReadLine();

            if (date == "y")
            {
                Console.WriteLine("Todays date is...");
                Console.WriteLine(DateTime.Today.ToString("MM-dd-yyyy"));
            }
            else
            {
                Console.WriteLine("Very well");
            }
        }

        public static void Age()
        {
            Console.WriteLine("Tell me the year you were born and I will tell you how old you are.");
            string year = Console.ReadLine();
            int age = Convert.ToInt32(year);
            Console.WriteLine(2020 - age + " years old");
        }

        public static void Guess()
        {
            Console.WriteLine("Guess a word and I will tell you if you are right or wrong.");
            string answer = Console.ReadLine();

            if (answer == "CSHARP")
            {
                Console.WriteLine("CORRECT!!!");
            }
            else
            {
                Console.WriteLine("WRONG!!!");
                Console.WriteLine("Would you like to try again y/n");
                string anew = Console.ReadLine();
                string aNew = anew.ToLower();

                if (aNew == "y")
                {
                    Guess();
                }
                else
                {
                    Console.WriteLine("Quitter");
                }
                Console.ReadKey();
            }
        }
    }
}
