using System;
using static System.Console;

namespace пр_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите последний элемент таблицы =");
            double n = 1;
            double k;
            int N;
            bool bbb = int.TryParse(ReadLine(), out N);
            if (bbb)
            {

                if (N > 0)
                {
                    while (n <= N)
                    {
                        k = n * 453 / 1000;
                        WriteLine(n + "Фунт = " + k + "кг.");
                        n++;
                    }
                }
                else
                    WriteLine("Таблицы не существует!");
            }
            else
                Write("ну почти");
            ReadLine();
        }
    }
}
