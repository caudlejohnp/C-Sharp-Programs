using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;

namespace Checkers
{
    public class Game
    {
        public string winner;

        private Board board;
        public Game()
        {
            this.board = new Board();
        }

        private bool CheckForWin()
        {
            //return board.checkers.All(x => x.Team == Color.White) || board.checkers.All(x => x.Team == Color.Black);
            int black = 0;
            int white = 0;
            for (int i = 0; i < board.checkers.Count(); i++)        
            {
                if (board.checkers[i].Team == Color.Black)
                {
                    black += 1;
                }
                else if (board.checkers[i].Team == Color.White)
                {
                    white += 1;
                }
            }

            if ( black == 0 )
            {
                winner = "White";
                return true;
            }
            else if ( white == 0)
            {
                winner = "Black";
                return true;
            }
            return false;
        }

        public void Start()
        {
            DrawBoard();
            
            while(!CheckForWin())
            {
                ProcessInput();
            }

            Console.WriteLine($"Congratulations {winner} has won!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public bool IsLegalMove(Color player, Position src, Position dest)
        {
            if (src.row < 0 || src.row > 7 || src.col < 0 || src.col > 7 || dest.row < 0 || dest.row > 7 || dest.col < 0 || dest.col > 7 )
            {
                return false;   //Checks to see if the moves entered were on available on the board
            }

            //Checks to ensure the player moved more than 0 squares or less than 2 squares
            int rowDistance = Math.Abs(dest.row - src.row);
            int colDistance = Math.Abs(dest.col - src.col);

            if (colDistance == 0 || rowDistance == 0 )  //checks to make sure that the checker is not moving in a straight line
            {
                return false;
            }
            if (rowDistance / colDistance != 1 )        //checks that the move is diagonal
            {
                return false;
            }

            if (rowDistance > 2)        //Player selected a square beyond it movement square choices
            {
                return false;
            }

            if (colDistance > 2)        //Player selected a square beyond it movement square choices
            {
                return false;
            }
            Checker c = board.GetChecker(src);
            
            if (c == null)      //There is no checker at the src selection
            {
                return false;
            }

            if (Program.playerTurn != c.Team)
            {
                return false;
            }


            c = board.GetChecker(dest);
            
            
            if ( c != null)     //Make sure there is no checker at the dest selection
            {
                return false;
            }

            if (rowDistance == 2)       //checks that if they player did move 2 was it because of a capture
            {
                if (IsCapture(src, dest))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }

        public bool IsCapture(Position src, Position dest)
        {
            int rowDistance = Math.Abs(dest.row - src.row);
            int colDistance = Math.Abs(dest.col - src.row);

            if (rowDistance == 2 && colDistance == 2)   //checks to see if there is a checker in the square that was jumped
            {
                int rowMid = (dest.row + src.row) / 2;
                int colMid = (dest.col + src.col) / 2;

                Position p = new Position(rowMid, colMid);

                Checker c = board.GetChecker(p);

                Checker player = board.GetChecker(src);

                if ( c == null)
                {
                    return false;
                }
                else
                {
                    if (c.Team == player.Team)      //checks to seee if the checker that was jumped is the same as the player that jumped it
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Checker GetCaptureChecker(Position src, Position dest)
        {

            if (IsCapture(src, dest))
            {
                int rowMid = (dest.row + src.row) / 2;
                int colMid = (dest.col + src.col) / 2;

                Position p = new Position(rowMid, colMid);

                Checker CapturedChecker = board.GetChecker(p);
                return CapturedChecker;
            }
            return null;
        }

        public void ProcessInput()
        {
            bool isValid1 = false;
            bool isValid2 = false;
            Position from = new Position(0, 0);
            Position to = new Position(0, 0);

            do
            {
                Console.WriteLine($"It is {Program.playerTurn}'s turn");
                Console.WriteLine("Select a row and column. (row,col)");
                string[] src = Console.ReadLine().Split(",");
                int srcCount = src.Count();
                

                if (srcCount == 2)
                {
                    try
                    {
                        from = new Position(int.Parse(src[0]), int.Parse(src[1]));
                        isValid1 = true;
                    }
                    catch
                    {
                        throw new ApplicationException("Please enter 2 numbers seperated by a comma: 0,0");
                    }
                } else
                {
                    Console.WriteLine("Please enter 2 numbers seperated by a comma: 0,0");
                }

                Console.WriteLine("Select a row and column to move the checker to. (row,col)");
                string[] dest = Console.ReadLine().Split(",");
                int destCount = dest.Count();

                if (destCount == 2)
                {
                    try
                    {
                        to = new Position(int.Parse(dest[0]), int.Parse(dest[1]));
                        isValid2 = true;
                    }
                    catch
                    {
                        throw new ApplicationException("Please enter 2 numbers seperated by a comma: 0,0");

                    }

                } else
                {
                    Console.WriteLine("Please enter 2 numbers seperated by a comma: 0,0");
                }

            } while (!isValid1 && !isValid2);

            Checker srcChecker = board.GetChecker(from);

            if (srcChecker == null)
            {
                Console.WriteLine("Invalid Choice. There is no checker at the chosen spot.");
            }
            else
            {
                if (IsLegalMove(srcChecker.Team, from, to))
                {
                    if (IsCapture(from, to))
                    {
                        Checker JumpChecker = GetCaptureChecker(from, to);
                        board.RemoveChecker(JumpChecker);
                        board.MoveChecker(srcChecker, to);
                    }
                    else
                    {
                        board.MoveChecker(srcChecker, to);
                    }
                }
            }
            Console.Clear();
            DrawBoard();
            if (Program.playerTurn == Color.White)
            {
                Program.playerTurn = Color.Black;
            }
            else
            {
                Program.playerTurn = Color.White;
            }
        }

        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.checkers)
            {
                grid[c.Position.row][c.Position.col] = c.Symbol;
            }

            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int r = 0; r < 8; r++)
            {
                Console.Write(r);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(" {0}", grid[r][c]);
                }
                Console.WriteLine();
            }
        }


    }
}
