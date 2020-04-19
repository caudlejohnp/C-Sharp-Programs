using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        private static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            board.Add("A", stack);            //starting point
            board.Add("B", new Stack<int>()); //empty stack
            board.Add("C", new Stack<int>()); //empty stack

            do
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("Enter the tower you want to move FROM.");
                string from = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter the tower you want to move TO.");
                string to = Console.ReadLine().ToUpper();

                if (IsMoveValid(from, to))
                {
                    board[to].Push(board[from].Pop());
                }
                else
                {
                    Console.WriteLine("Invalid Move.");
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }
            } while (!CheckWin());

            Console.Clear();
            PrintBoard();
            Console.WriteLine("You Win.");
            Console.ReadKey();
        }

        private static bool IsMoveValid(string from, string to)
        {
            if (board[from].Count == 0)
            {
                return false;
            }
            else if (to == from)
            {
                return false;
            }
            else if (board[to].Count != 0)
            {
                if (board[to].Peek() < board[from].Peek())
                {
                    return false;
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        private static bool CheckWin()
        {
            if (board["C"].Count == 4)
            {
                return true;
            }
            return false;
        }

        private static void PrintBoard()
        {
            foreach (var item in board)
            {
                Console.WriteLine($"\n{item.Key}: ");
                var numbers = item.Value.ToArray();

                for (int i = numbers.Length; i > 0; i--)
                {
                    Console.Write(numbers[i - 1] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
