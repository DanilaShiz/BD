using System;
using static System.Console;

namespace пр_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0;
            Write("Введите A:");
            bool bb = int.TryParse(ReadLine(), out a);
            Write("Введите B:");
            bool bbb = int.TryParse(ReadLine(), out b);
            if (bb && bbb)
            {

                for (int i = a; i <= b; i++)
                    sum += i;
                if (a > b)
                    Write("Ошибка при вводе.");
                else
                    Write("Сумма = " + sum);
            }
            else
                Write("NUMBER Ne NUMBER");
            ReadLine();
        }
    }
}
