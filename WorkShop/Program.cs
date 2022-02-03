using System;

namespace WorkShop
{
    class Program
    {
        public static void OutputUC1()
        {
            var app = new TicTacToe();
            int count = 0;
            foreach (var item in app.GameUCOne())
            {
                Console.WriteLine($"position: {count}, value :{item}");
                count++;
            }
        }
        public static void OutputUC2()
        {
            var app = new TicTacToe();
            int count = 0;
            foreach (var item in app.GameUCTwo())
            {
                Console.WriteLine($"position: {count}, value :{item}");
                count++;
            }
        }
        public static void OutputUC3()
        {
            var app = new TicTacToe();
            app.ShowBoard(app.GameUCTwo());
        }
        
        static void Main(string[] args)
        {
            // OutputUC1(); // uc1
            // OutputUC2(); // uc2
            OutputUC3(); // uc3
        }
    }
}