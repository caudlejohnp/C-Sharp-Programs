using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string answer = string.Empty;
            Dictionary<string, string> gradeBook = new Dictionary<string, string>();

            do
            {
                Console.WriteLine("Enter a student name.");
                name = Console.ReadLine();
                Console.WriteLine("Enter the student's grades.");
                string grades = Console.ReadLine();

                gradeBook.Add(name, grades);

                Console.WriteLine("Press ENTER to add another student's name? Enter quit to stop.");
                answer = Console.ReadLine().ToLower();

            } while (!answer.Equals("quit"));   // answer != "quit"

            int lowestGrade = 0;
            int highestGrade = 0;
            double average = 0.00;

            foreach (var item in gradeBook)
            {
                Console.WriteLine("");
                Console.WriteLine($"{item.Key}\n");

                int[] singleGrades = Array.ConvertAll<string, int>(gradeBook[item.Key].Split(), Convert.ToInt32);

                highestGrade = singleGrades.Max();
                lowestGrade = singleGrades.Min();
                average = singleGrades.Average();

                Console.WriteLine($"Highest grade = {highestGrade}  \nLowest grade = {lowestGrade}   \nAverage = {average}");
            }
        }
    }
}
