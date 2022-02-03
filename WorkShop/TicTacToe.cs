using System;

namespace WorkShop
{
    public class TicTacToe
    {
        private char _computerOption;
        private char _playerOption;
        // private char[] _option = new char[10];
        private char[] _option = { ' ', 'x', 'o', 'x', 'o', 'o', 'x', 'x', 'x', 'x'};
        
        public char[] Game()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    continue;
                _option[i] = ' ';
            }
            return _option;
        }
        public void GetChoice()
        {
            Console.Write("Choose a Option [X]/[O] :" );
            if (Console.ReadLine().ToLower() == "x")
            {
                this._computerOption = 'O';
                this._playerOption = 'X';
            }
            else
            {
                this._computerOption = 'x';
                this._playerOption = 'o';
            }

            Console.WriteLine($">> player: {this._playerOption}, computer: {this._computerOption}");
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