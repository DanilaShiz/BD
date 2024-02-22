using System;
using static System.Console;

namespace пр_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, i1, c, min, min1, m1, n1;
            WriteLine("Введите размер матрицы:");
            bool bbb = int.TryParse(ReadLine(), out m);
            bool bbbb = int.TryParse(ReadLine(), out n);
            if (bbb && bbbb)
            {

                int[,] _MNM = new int[m, n];
                int[] _MNM1 = new int[n];
                int[] _MNM2 = new int[m];
                WriteLine("Введите столбец из " + m + " строк");
                c = 1;
                m1 = 0;
                n1 = 0;
                for (i1 = 0; i1 < n; i1++)
                {
                    WriteLine("Введите" + c + " столбец");
                    for (i = 0; i < m; i++)
                    {
                        _MNM[i, i1] = Convert.ToInt32(ReadLine());
                    }
                    c++;
                }
                for (i = 0; i < n; i++)
                {
                    _MNM1[i] = _MNM[0, i];
                }
                for (i = 0; i < m; i++)
                {
                    _MNM2[i] = _MNM[i, 0];
                }
                for (i = 1; i < n; i++)
                {
                    for (i1 = 0; i1 < m; i1++)
                    {
                        if (_MNM2[i1] > _MNM[i1, i])
                            _MNM2[i1] = _MNM[i1, i];
                    }
                }
                for (i = 1; i < m; i++)
                {
                    for (i1 = 0; i1 < n; i1++)
                    {
                        if (_MNM1[i1] > _MNM[i, i1])
                            _MNM1[i1] = _MNM[i, i1];
                    }
                }
                min = _MNM1[0];
                min1 = _MNM2[0];
                for (i = 0; i < n; i++)
                {
                    if (min > _MNM1[i])
                    {
                        m1 = i;
                        min = _MNM1[i];
                    }
                }
                for (i = 0; i < m; i++)
                {
                    if (min > _MNM2[i])
                    {
                        n1 = i;
                        min = _MNM1[i];
                    }
                }
                WriteLine("Введенный массив:");
                for (i = 0; i < m; i++)
                {
                    for (i1 = 0; i1 < n; i1++)
                    {
                        Write(_MNM[i, i1] + " ");
                    }
                    WriteLine(" ");
                }
                n1++;
                m1++;
                WriteLine(" ");
                WriteLine("Минимальный элемент располагается в " + n1);
                WriteLine("строке" + m1 + " столбца");
            }
            else
                WriteLine("Массивов...нет.");
            ReadLine();
        }
    }
}
