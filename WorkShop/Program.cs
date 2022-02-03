using System;

namespace WorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new TicTacToe();
            
            // // uc1
            // int count = 0;
            // foreach (var item in app.Game())
            // {
            //     Console.WriteLine($">> position: {count}, value :{item},");
            //     count++;
            // }
            
            // uc2
            app.GetChoice();
            Console.WriteLine($">> player: {app.PlayerOption}, computer: {app.ComputerOption}");
            
            // // uc3
            // app.ShowBoard();
        }
    }
}