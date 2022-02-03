using System;

namespace WorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new TicTacToe();
            int count = 0;
            foreach (var item in app.GameUCOne())
            {
                Console.WriteLine($"position: {count}, value :{item}");
                count++;
            } 
        }
    }
}