using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace ToDoApp
{
    public class ConsoleUtils
    {
        public int UserOption()
        {
            bool correct = true;
            int choice = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6 || choice == 7)
                {
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine("Please enter a valid option.");
                    correct = false;
                }
            } while (!correct);
            return choice;
        }

        public void MainMenu()                      
        {
            Console.WriteLine("Select an option.");
            Console.WriteLine(" 1: Add an item. \n 2: Delete an item. \n 3: Mark an item as complete.");
            Console.WriteLine(" 4: Print pending items. \n 5: Print completed items. \n 6: Print all items. \n 7: Quit.");
        }

        public ToDoItem AddItem()
        {
            Console.WriteLine("Please enter a brief description.");
            string desc = Console.ReadLine();
            ToDoItem newItem = new ToDoItem(desc);
            return newItem;
        }

        public int ChangeItem()
        {
            Console.WriteLine("Select an item to update.");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }


        public int DeleteItem()
        {
            Console.WriteLine("Enter the id number of the item you wish to delete.");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public void InvalidInput()
        {
            Console.WriteLine("Invalid input.");
        }

        public List<ToDoItem> Print(List<ToDoItem> list)
        {

            foreach (var item in list)
            {
                Console.WriteLine($"ID #: {item.Id} \n Descrption: {item.Desc} \n Pending {item.Pending}");
            }
            return list;
        }
    }
}
