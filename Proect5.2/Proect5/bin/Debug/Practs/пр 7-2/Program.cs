using System;
using static System.Console;

namespace пр_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, c, i1, k, c1;
            WriteLine("Введите матрицу разммером 8:8: ");
            WriteLine("Ввод осуществляется по столбцам ");
            int[,] _hey_Monika = new int[8, 8];
            c = 1;
            c1 = 1;
            for (i1 = 0; i1 < 8; i1++)
            {
                WriteLine("Введите" + c + " столбец");
                for (i = 0; i < 8; i++)
                {
                    _hey_Monika[i, i1] = Convert.ToInt32(ReadLine());
                }
                c++;
            }
            WriteLine("Введенный массив: ");
            for (i = 0; i < 8; i++)
            {
                for (i1 = 0; i1 < 8; i++)
                {
                    Write(_hey_Monika[i, i1] + " ");
                }
                WriteLine(" ");
            }
            WriteLine("Введите строку и столбец.");
            WriteLine("которые надо сравнить:");
            k = Convert.ToInt32(ReadLine());
            k = k - 1;
            for (i = 0; i < 8; i++)
            {
                if (_hey_Monika[i, k] == _hey_Monika[k, i])
                    continue;
                else
                    c1 = 0;
            }
            if (c1 == 1)
                WriteLine("Строки равны");
            else
                WriteLine("Строки НЕ равны");
            ReadLine();
        }
    }
}
