using System;
using static System.Console;

namespace пр_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Write("Введите координату по x = ");
            bool bbb = int.TryParse(ReadLine(), out x);
            Write("Введите координату по y = ");
            bool bbbb = int.TryParse(ReadLine(), out y);
            if (bbb && bbbb)
            {
                if (x * x + y * y <= 6 * 6 & x >= 2)
                {
                    WriteLine("точка принадлежит заштрихованной области");
                }
                else
                    WriteLine("точка не принадлежит заштрихованной области");
            }
            else
                Write("Дело сделано.");
            ReadLine();
        }
    }
}
