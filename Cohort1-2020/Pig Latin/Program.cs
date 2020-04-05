using System;

namespace Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] consonant = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter a word.");
            string answer = Console.ReadLine();
            string answerLower = answer.ToLower();

            string firstLetter = answerLower.Substring(0, 1);
            string lastLetter = answerLower.Substring(answerLower.Length - 1, 1);
            int vowelIndex = answerLower.IndexOfAny(vowels);
            string leadCon = answerLower.Substring(0, vowelIndex);   //grabs the leading consonants
            string leftOvers = answerLower.Substring(vowelIndex); //consonants before the vowel
            int conIndex = answerLower.IndexOfAny(consonant);
            

            string newWord = answerLower.Substring(vowelIndex) + leadCon;

            if (answerLower.IndexOfAny(vowels) == -1)    // no vowels
            {
                Console.WriteLine(newWord + "ay");
            }

            else if (firstLetter.IndexOfAny(vowels) == 0)  //first letter is vowel
            {
                if (lastLetter.IndexOfAny(vowels) == 0)
                {
                    Console.WriteLine(answerLower + "yay");
                }

                else
                {
                    Console.WriteLine(answerLower + "ay"); //ends in a vowel            
                }
            }

            if (answerLower.IndexOfAny(consonant) == 0) //first letter is a consonant
            {
                Console.WriteLine(leftOvers + leadCon + "ay");
            }

            Console.ReadLine();
        }
    }
}
