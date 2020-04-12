using System;

namespace TicTacToe
{
    class Program
    {
        public static string[,] Board;

        static void Main(string[] args)
        {
            InitialBoard();
            bool isPlaying = true;
            string playerLetter = "X";

            while (isPlaying)
            {
                WriteBoard();
                Console.WriteLine($"Player {playerLetter} choose a number.");

                string answer = Console.ReadLine();
                Marker(answer, playerLetter);
                if (playerLetter == "X")
                {
                    playerLetter = "O";
                }
                else
                {
                    playerLetter = "X";
                }
                Winner(playerLetter);
                IsTie(playerLetter);

                if (Winner(playerLetter) || IsTie(playerLetter))
                {
                    isPlaying = false;
                }
            }
        }

        static void Marker(string answer, string playerLetter)
        {
                switch (answer)
                {
                    case "1":
                        if (Board[0, 0] == "1")
                        {
                            Board[0, 0] = playerLetter;
                        }
                        break;

                    case "2":
                        if (Board[0, 1] == "2")
                        {
                            Board[0, 1] = playerLetter;
                        }
                        break;

                    case "3":
                        if (Board[0, 2] == "3")
                        {
                            Board[0, 2] = playerLetter;
                        }
                        break;

                    case "4":
                        if (Board[1, 0] == "4")
                        {
                            Board[1, 0] = playerLetter;
                        }
                        break;

                    case "5":
                        if (Board[1, 1] == "5")
                        {
                            Board[1, 1] = playerLetter;
                        }
                        break;

                    case "6":
                        if (Board[1, 2] == "6")
                        {
                            Board[1, 2] = playerLetter;
                        }
                        break;

                    case "7":
                        if (Board[2, 0] == "7")
                        {
                            Board[2, 0] = playerLetter;
                        }
                        break;

                    case "8":
                        if (Board[2, 1] == "8")
                        {
                            Board[2, 1] = playerLetter;
                        }
                        break;

                    case "9":
                        if (Board[2, 2] == "9")
                        {
                            Board[2, 2] = playerLetter;
                        }
                    break;     
                }
        }

        private static bool Winner(string playerLetter)
        {
            DiagonalWin(playerLetter);
            VerticalWin(playerLetter);
            HorizontalWin(playerLetter);

            if (DiagonalWin(playerLetter) || VerticalWin(playerLetter) || HorizontalWin(playerLetter))
            {
                Console.WriteLine($"{playerLetter} has won!");
                return true;
            }
            else
            {
                return false;
            }
        }
            

        private static bool IsTie(string playerLetter)
        {
            if (Board[0, 0].Equals(playerLetter) && Board[0, 1].Equals(playerLetter) && Board[0, 2].Equals(playerLetter) &&
                Board[1, 0].Equals(playerLetter) && Board[1, 1].Equals(playerLetter) && Board[1, 2].Equals(playerLetter) &&
                Board[2, 0].Equals(playerLetter) && Board[2, 1].Equals(playerLetter) && Board[2, 2].Equals(playerLetter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool VerticalWin(string playerLetter)
        {
            if (Board[0, 0].Equals(playerLetter) && Board[0, 1].Equals(playerLetter) && Board[0, 2].Equals(playerLetter) || 
                Board[1, 0].Equals(playerLetter) && Board[1, 1].Equals(playerLetter) && Board[1, 2].Equals(playerLetter) ||
                Board[2, 0].Equals(playerLetter) && Board[2, 1].Equals(playerLetter) && Board[2, 2].Equals(playerLetter))
            {
                return true;
            }
            return false;
        }

        private static bool HorizontalWin(string playerLetter)
        {
            if (Board[0, 0].Equals(playerLetter) && Board[0, 1].Equals(playerLetter) && Board[0, 2].Equals(playerLetter) ||
                Board[1, 0].Equals(playerLetter) && Board[1, 1].Equals(playerLetter) && Board[1, 2].Equals(playerLetter) ||
                Board[2, 0].Equals(playerLetter) && Board[2, 1].Equals(playerLetter) && Board[2, 2].Equals(playerLetter))
            {
                return true;
            }
            return false;
        }

        private static bool DiagonalWin(string playerLetter)
        {
            if(Board[0,0].Equals(playerLetter) && Board[1,1].Equals(playerLetter) && Board[2,2].Equals(playerLetter) ||
               Board[0,2].Equals(playerLetter) && Board[1,1].Equals(playerLetter) && Board[2,0].Equals(playerLetter))
            {
                return true;
            }
            return false;
        }

        static void WriteBoard()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\t" + Board[i, 0] + " | " + Board[i, 1] + " | " + Board[i, 2]);
                if (i < 2)
                {
                    Console.WriteLine("\t----------");
                }
            }
        }

        static void InitialBoard()
        {
            Board = new string[3, 3]

            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };
        }
    }
}
