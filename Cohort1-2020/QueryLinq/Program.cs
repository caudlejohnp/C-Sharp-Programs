using System;
using System.Linq;

namespace QueryLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();
            QueryIntArray();
        }

        static void QueryStringArray()
        {
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Lassie", "Snoopy" };

            var dogSpaces = from dog in dogs where dog.Contains(" ") orderby dog ascending select dog;

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
        }

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

            var gt20 = from i in nums where i > 20 orderby i select i;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine($"Get Type : {gt20.GetType()}");

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            return arrayGT20;
        }
    }
}
