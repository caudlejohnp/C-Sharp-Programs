using System;
using System.Collections.Generic;

namespace ToDoItem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDoItem> toDoList = new List<ToDoItem>();
            bool stop = true;

            do
            {
                Console.WriteLine("Enter a brief To Do description, a due date and and low, medium or high priority");
                string answer = Console.ReadLine();
                ToDoItem item1 = new ToDoItem("", "", "");
            } while (stop == true);
        }
    }

    class ToDoItem
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
