using SankeAndLadder;
using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To SNAKE AND LADDER Game");
            SnakeLadder playerOne = new SnakeLadder();
            playerOne.DieRolling();
            playerOne.PlayerCheck();
        }
    }
}