using System;

namespace WorkShop
{
    public class TicTacToe
    {
        private char _computerOption = 'x';
        private char _playerOption;
        
        private int _computerPosition = 1;
        private int _playerPosition = 0;
        
        private char[] _option = new char[10];
        
        public char[] GameUCOne()
        {
            char[] option = new char[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    continue;
                else
                    option[i] = random.Next(0, 2) == 0?'x':'o';
            }
            return option;
        }

        public char[] GameUCTwo()
        {
            Random random = new Random();
            Console.Write("Type 'X' or 'O' to choose your option:" );
            if (Console.ReadLine().ToLower() == "x")
            {
                this._computerOption = 'o';
                this._playerOption = 'x';
            }
            else
            {
                this._playerOption = 'o';
            }

            for (int i = 0; i < 10; i++)
            {
                int choice = random.Next(0, 2);
                if (i == 0)
                    continue;
                else
                {
                    if ( choice == this._computerPosition)
                        this._option[i] = this._computerOption;
                    if (choice == this._playerPosition)
                        this._option[i] = this._playerOption;
                }
            }
            return _option;
        }

        public void ShowBoard(char[] options)
        {
            // uc-3
            Console.WriteLine($"{options[1]} | {options[2]} | {options[3]} \n" +
                              $"{options[4]} | {options[5]} | {options[6]} \n" +
                              $"{options[7]} | {options[8]} | {options[9]} \n");
        }
    }
}