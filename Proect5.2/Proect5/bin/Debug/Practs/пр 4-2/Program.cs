using System;
using static System.Console;

namespace пр_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, k = 1;
            Double sum = 0;
            Write("Введите количество чисел:");
            bool bb = int.TryParse(ReadLine(), out n);
            if (bb)
            {
                if (n <= 0)
                    WriteLine("ОШИБКА");
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Write("Введите" + i + "-е число:");
                        bool bbb = int.TryParse(ReadLine(), out x);
                        if (bbb)
                        {
                            if (x < 0)
                                sum = sum + x;
                            if (x > 0)
                                k = k * x;
                        }
                        else break;
                    }

                    WriteLine("Среднее арифметическое отрицательных чисел = " + sum / n);
                    WriteLine("Произведение полодительных чисел = " + k);

                }
            }
            else
                Write("Ошибка");
            ReadLine();
        }
    }
}

