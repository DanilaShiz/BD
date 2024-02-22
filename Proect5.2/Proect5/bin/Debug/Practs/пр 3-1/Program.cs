using System;
using static System.Console;

namespace пр_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            Write("Первое число = ");
            bool bbb = int.TryParse(ReadLine(), out a);
            Write("Второе число = ");
            bool bbbb = int.TryParse(ReadLine(), out b);
            if (bbb && bbbb)
            {

                if (a == 0)
                {
                    WriteLine("Делить на нуль невозможно");
                }
                else
                 if (b == -1)
                {
                    WriteLine("Делить на нуль невозможно");
                }
                else
                 if (a > b)
                {
                    WriteLine(x = a - b / a);
                }
                else
                 if (a < b)
                {
                    WriteLine(x = a / b + 1);
                }
                else
                 if (a == b)
                {
                    WriteLine(-71);
                }
                else;
            }
            else
                Write("ERROR VISKI");
            ReadLine();
        }
    }
}
