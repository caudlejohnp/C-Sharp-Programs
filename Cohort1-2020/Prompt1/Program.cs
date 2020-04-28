using System;

namespace Prompt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 5, 10, 4, 2 };
            int j = 0;
            int divFour = 0;
            int theSum = 0;

            foreach (int i in myArr)
            {
                j = (i * i);
                if (j % 4 == 0)
                {
                    divFour = j;
                    theSum += divFour;
                }
            }
            Console.WriteLine(theSum);
            Console.ReadKey();
        }
    }
}
