using System;
using static System.Console;

namespace пр__6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Write("N = ");
            bool bbbb = int.TryParse(ReadLine(), out n);
            if (bbbb)
            {
                if (n > 1)
                {
                    int[] mass = new int[n];
                    Write("Вводите массив-");
                    for (int i = 0; i < n; i++)
                    {
                        bool bbb = int.TryParse(ReadLine(), out mass[i]);
                        if (bbb!)
                        {
                            Write("Введите эллемент массива под номером" + i + ":");
                            if (mass[i] > 0)
                                i++;
                        }
                        else
                            break;

                    }
                    for (int i = 0; i < n; i++)
                        Write(mass[i] + " ");
                    ReadKey();
                }
                else
                    WriteLine("ВОЙСКО ЖЕЛЕЗНЫХ СОЛДАТ.");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Ну нет.");
            }
            ReadLine();
        }
    }
}
