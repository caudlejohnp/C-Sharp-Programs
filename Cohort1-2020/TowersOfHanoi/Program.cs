using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        private static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();    //creates a stack 
            stack.Push(4);                          //bottom item of the stack can not be "popped" without popping the prior stacks
            stack.Push(3);                          
            stack.Push(2);
            stack.Push(1);                          //top of the stack this item will be "popped" first 
            board.Add("A", stack);                  //the stack after the "A" string is the name of the above created stack which then adds all the items in the stack
            board.Add("B", new Stack<int>());       //empty stack
            board.Add("C", new Stack<int>());       //empty stack

            do
            {
                Console.Clear();    //clears the console for better/easier readablitiy
                PrintBoard();       //prints the board out with all the changes that the player has chosen
                Console.WriteLine("Enter the tower you want to move FROM.");    //player chooses a tower to pop a stack item from
                string from = Console.ReadLine().ToUpper();                     //saves the players choice for "IsMoveValid()" method
                Console.WriteLine("Enter the tower you want to move TO.");      //player chooses a tower to push an item to
                string to = Console.ReadLine().ToUpper();                       //saves the players choice for the "IsMoveValid()" method

                if (IsMoveValid(from, to))  //if the move is valid it executes
                {
                    board[to].Push(board[from].Pop());  //this line of code adds the players choice to the selected tower (array)
                }
                else            //if the move is not valid it writes out the below error messege
                {
                    Console.WriteLine("Invalid Move.");
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }
            } while (!CheckWin());      //it then checks the CheckWin() method to see if the player has completed moving everything the C tower
                                        //the ! is there so that while the CheckWin() reads as false it will go back into the do loop
            Console.Clear();            //clears the board for better readability
            PrintBoard();               //prints the board with all the changes the player has made
            Console.WriteLine("You Win.");      //Writes out that the player has won because we are now out side the do loop
            Console.ReadKey();
        }

        private static bool IsMoveValid(string from, string to)     //method to check if the move is valid
        {
            if (board[from].Count == 0)         //checks if the player chose a tower with no pop_able items
            {
                return false;
            }
            else if (to == from)                //checks if the player chose to push an item to the tower that he just popped from
            {
                return false;
            }
            else if (board[to].Count != 0)      //checks if the tower has an item already in it
            {
                if (board[to].Peek() < board[from].Peek())  //if it does this line checks to see if the item they pushed is less than the one the popped from
                {                                           //the reason for this is to make sure that the player is not pushing something that is greater than what
                    return false;                           //is already in the tower
                }
                return true;
            }
            else                                            //if the other if statements return true then the move is valid and then the item is pushed to the corresponding tower
            {
                return true;
            }
        }

        private static bool CheckWin()                      //This method checks to see if the player has successfully moved all items to tower (array) C
        {
            if (board["C"].Count == 4)                      //Given the rules for the IsMoveValid() method the player will have stacked all items in tower C
            {                                               //meaning that the array count now equals 4 returning a true bool and stepping out of the Do While Loop
                return true;                                
            }
            return false;                                   //otherwise it remains false and the do loop keeps going
        }

        private static void PrintBoard()
        {
            foreach (var item in board)
            {
                Console.WriteLine($"\n{item.Key}: ");       //writes the array on the cosole for the user to see
                var numbers = item.Value.ToArray();         

                for (int i = numbers.Length; i > 0; i--)    //goes through the for loop to create the board with the A B C towers 
                {
                    Console.Write(numbers[i - 1] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
