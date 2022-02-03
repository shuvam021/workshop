using System;

namespace WorkShop
{
    public class TicTacToe
    {
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
    }
}