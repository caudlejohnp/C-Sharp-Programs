using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[] { 5, 17, 87, 42, 52};
            int h = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] > h)
                {
                    h = myArr[i];
                }
            }

            Console.WriteLine($"The highest number in the array is {h}. ");

        }
    }
}
