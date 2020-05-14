using System;

namespace BookInventory
{
    class Program
    {
        public static BookContext context = new BookContext();
        public static bool quit = true;

        static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            do
            {
                Menu(quit);

            } while (quit);
        }

        public static void Menu(bool quit)
        {
            bool mainMenu = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to your Library.");
                Console.WriteLine("Press 1 to enter a new book into your library.");
                Console.WriteLine("Press 2 to update a book in your library.");
                Console.WriteLine("Press 3 to remove a book from your library.");
                Console.WriteLine("Press 4 to print out all books in your library.");
                Console.WriteLine("Press 5 to quit.");
                int response = Convert.ToInt32(Console.ReadLine());

                if (response == 1)
                {
                    AddBook();
                }
                else if (response == 2)
                {
                    UpdateBook();
                }
                else if (response == 3)
                {
                    RemoveBook();
                }
                else if (response == 4)
                {
                    context.PrintLibrary();
                }
                else if (response == 5)
                {
                    quit = false;
                }
                else
                {
                    Console.WriteLine("Invalid input please enter 1, 2, 3, 4 or 5");
                    mainMenu = false;
                }
            }
            while (!mainMenu);
        }

        public static void AddBook()
        {
            Console.WriteLine("Please enter the title of your new book.");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter the author of your new book.");
            string author = Console.ReadLine();

            Book bookAdd = new Book(title, author);

            context.Add(bookAdd);
            context.SaveChanges();

            Console.WriteLine("Return to main menu? y/n");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                quit = true;
            }
            else
            {
                quit = false;
            }
        }

        public static void UpdateBook()
        {
            context.PrintLibrary();
            Console.WriteLine("Please enter the ID number of the book you wish to update.");
            int id = Convert.ToInt32(Console.ReadLine());
            Book book = FindBook(id);
            Console.WriteLine("Please enter the updated Title.");
            book.Title = Console.ReadLine();
            Console.WriteLine("Please enter the updated Author.");
            book.Author = Console.ReadLine();
            context.Update(book);
            context.SaveChanges();

            Console.WriteLine("Return to main Menu? y/n");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                quit = true;
            }
            else
            {
                quit = false;
            }
            
        }

        public static void RemoveBook()
        {
            context.PrintLibrary();
            Console.WriteLine("Please enter the ID number of the book your wish to delete.");
            int id = Convert.ToInt32(Console.ReadLine());
            Book book = FindBook(id);
            context.Remove(book);
            context.SaveChanges();
            Console.WriteLine("Return to main menu. y/n");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                quit = true;
            }
            else
            {
                quit = false;
            }
        }

        public static Book FindBook(int id)
        {
            return context.Books.Find(id);
        }
    }
}
