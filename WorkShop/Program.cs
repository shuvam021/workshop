using System;

namespace WorkShop
{
    class Program
    {
        public void OutputUC1()
        {
            var app = new TicTacToe();
            int count = 0;
            foreach (var item in app.GameUCOne())
            {
                Console.WriteLine($"position: {count}, value :{item}");
                count++;
            }
        }
        public void OutputUC2()
        {
            var app = new TicTacToe();
            int count = 0;
            foreach (var item in app.GameUCTwo())
            {
                Console.WriteLine($"position: {count}, value :{item}");
                count++;
            }
        }
        static void Main(string[] args)
        {
            var app = new Program();
            // app.OutputUC1(); // uc1
            app.OutputUC2(); // uc2
        }
    }
}