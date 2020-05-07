using System;

namespace Checkers
{
    class Program
    {
        public static Color playerTurn = Color.White;
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
            Console.ReadKey();
        }
    }
}
