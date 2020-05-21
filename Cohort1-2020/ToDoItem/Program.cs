using System;
using System.Collections.Generic;

namespace ToDoItem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDoItem> list = new List<ToDoItem>();
            bool done = true;

            do
            {
                Console.WriteLine("Enter a brief description.");
                string desc = Console.ReadLine();
                Console.WriteLine("Enter a due date.");
                string dueDate = Console.ReadLine();
                Console.WriteLine("Enter a priority: Low - Medium - High");
                string priority = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter another item? y/n");
                string cont = Console.ReadLine().ToLower();
                list.Add(new ToDoItem(desc, dueDate, priority));

                if (cont == "y")
                {
                    done = true;
                }
                else if (cont == "n")
                {
                    done = false;
                }

            } while (done);

            foreach (var item in list)
            {
                Console.WriteLine($" Description: {item.Description} \n Due Date: {item.DueDate} \n Priority: {item.Priority} \n ");
            }
            Console.ReadKey();


        }
    }

    public class ToDoItem
    {
        public string Description { get; set; }

        public string DueDate { get; set; }

        public string Priority { get; set; }
        
        public ToDoItem(string desc, string dueDate, string priority)
        {
            Description = desc;
            DueDate = dueDate;
            Priority = priority;
        }
    }
}
