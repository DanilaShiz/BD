using System;
using System.IO;
using static System.Console;

namespace пр_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, t;
            Write("Введите число строк матрицы - ");
            bool b = int.TryParse(ReadLine(), out x);
            Write("Введите число столбцов матрицы - ");
            bool bb = int.TryParse(ReadLine(), out y);
            Write("Введите минимально возможное, значение, в матрицы - ");
            bool bbb = int.TryParse(ReadLine(), out z);
            Write("Введите максимальное возможное, значение, в матрицы - ");
            bool bbbb = int.TryParse(ReadLine(), out t);
            if (b && bb && bbb && bbbb)
            {
                CATCH cat = new CATCH(x, y, z, t);
            }
            else
                Write("НЕЕЕЕТ");
        }
    }
    class CATCH
    {
        public CATCH(int x, int y, int z, int t)
        {
            int[,] mass = new int[x, y];
            int a = 0, a1 = 0, b = 0, b1 = 0, min = z, minch = t, maxch = z - 1, max = t;
            for (int i = -1; ++i < 4;)
            {
                for (int j = -1; ++j < 5;)
                {
                    mass[i, j] = new Random().Next(min, max);
                }
            }
            for (int i = -1; ++i < 4;)
            {
                for (int j = -1; ++j < 5;)
                {
                    Write(mass[i, j] + " ");
                }
                WriteLine();
            }
            for (int i = -1; ++i < 4;)
            {
                for (int j = -1; ++j < 5;)
                {
                    if (mass[i, j] > maxch)
                    {
                        maxch = mass[i, j];
                        a = 1;
                        a1 = j;
                    }
                    if (mass[i, j] > minch)
                    {
                        minch = mass[i, j];
                        b = 1;
                        b1 = j;
                    }
                }
            }
            ForegroundColor = ConsoleColor.White;
            mass[a, a1] = minch;
            mass[b, b1] = maxch;
            WriteLine("===============");
            WriteLine("Массив с заменой - ");
            ForegroundColor = ConsoleColor.Green;
            for (int i = -1; ++i < 4;)
            {
                for (int j = -1; ++j < 5;)
                {
                    Write(mass[i, j] + " ");
                }
                WriteLine();


        }
            ReadLine();
        }
    }
}
