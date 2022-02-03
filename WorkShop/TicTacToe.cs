using System;

namespace WorkShop
{
    public class TicTacToe
    {
        private char[] _option = new char[10];
        public char ComputerOption { get; set; } = 'X';
        public char PlayerOption { get; set; } = 'O';
        public char[] Game()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0) continue;
                else _option[i] = ' ';
            }
            return _option;
        }
        public void GetChoice()
        {
            Console.Write("Choose a Option [X]/[O] :" );
            var option = Console.ReadLine();
            if(option == null)
                throw new NullReferenceException();
            if (option.ToUpper() != "X") return;
            this.ComputerOption = 'O';
            this.PlayerOption = 'X';
        }

        public void ShowBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {this._option[1]}  |  {this._option[2]}  |  {this._option[3]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {this._option[4]}  |  {this._option[5]}  |  {this._option[6]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {this._option[7]}  |  {this._option[8]}  |  {this._option[9]}");
            Console.WriteLine("     |     |      ");
        }
    }
}