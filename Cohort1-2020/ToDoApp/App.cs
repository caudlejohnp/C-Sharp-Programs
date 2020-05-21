using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ToDoApp
{
    public class App
    {
        ConsoleUtils consoleUtils;
        ItemRepository itemRepository;

        public App()
        {
            consoleUtils = new ConsoleUtils();
            itemRepository = new ItemRepository();
        }

        public void Menu()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                consoleUtils.MainMenu();
                int choice = consoleUtils.UserOption();

                if (choice == 1)                                    //Add an item to list
                {
                    itemRepository.AddItem(consoleUtils.AddItem());
                }
                else if (choice == 2)                               //Delete an item
                {
                    consoleUtils.Print(itemRepository.PrintAll());
                    int id = consoleUtils.DeleteItem();
                    if (itemRepository.IdChecker(id))
                    {
                        itemRepository.DeleteItem(id);
                    }
                    else
                    {
                        consoleUtils.InvalidInput();
                    }
                }
                else if (choice == 3)                               //Mark an item as complete
                {
                    consoleUtils.Print(itemRepository.PrintAll());
                    int id = consoleUtils.ChangeItem();

                    if (itemRepository.IdChecker(id))
                    {
                        itemRepository.ChangeItem(id);
                    }
                    else
                    {
                        consoleUtils.InvalidInput();
                    }
                }
                else if (choice == 4)                               //Print pending items
                {
                    consoleUtils.Print(itemRepository.PrintPending());
                    Console.ReadKey();
                }
                else if (choice == 5)                               //Print completed items
                {
                    consoleUtils.Print(itemRepository.PrintComplete());
                    Console.ReadKey();
                }
                else if (choice == 6)                               //Print all Items
                {
                    consoleUtils.Print(itemRepository.PrintAll());
                    Console.ReadKey();
                }
                else if (choice == 7)                               //Quit the app
                {
                    isRunning = false;
                }
            }
        }
    }
}
