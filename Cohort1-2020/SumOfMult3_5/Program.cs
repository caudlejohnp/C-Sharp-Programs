using System;

namespace SumOfMult3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            for ( i = 0; i < 1000; i++)
            {
                if ( i % 5 == 0 || i % 3 == 0)
                {
                    j += i;
                }
            }

            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
