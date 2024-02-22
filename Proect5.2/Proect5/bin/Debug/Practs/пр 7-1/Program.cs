using System;
using static System.Console;

namespace пр_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, n, m, i, i1, c, c1;
            WriteLine("Введите размер матрицы(m,n):");
            bool bbb = int.TryParse(ReadLine(), out m);
            bool bbbb = int.TryParse(ReadLine(), out n);
            if (bbb && bbbb)
            {
                if (m > 0 && n > 0)
                {
                    Write("Введите числоо (d):");
                    bool bbbbb = int.TryParse(ReadLine(), out d);
                    if (bbbbb)
                    {
                        int[,] ARA = new int[m, n];
                        WriteLine("Введите столбец из " + m + "строк");
                        for (i = 0; i < m; i++)
                        {
                            bool bbbbbb = int.TryParse(ReadLine(), out ARA[i, 0]);
                            if (bbbbbb)
                            {
                                WriteLine("");
                            }

                        }
                        WriteLine("Готовый массив, прибавленный на " + d);
                        c = 0;
                        c1 = 0;
                        for (i = 0; i < m; i++)
                        {
                            for (i1 = 1; i1 < n; i1++)
                            {
                                ARA[i, i1] = ARA[c1, c] + d;
                                c++;
                            }
                            c = 0;
                            c1++;
                        }
                        for (i = 0; i < m; i++)
                        {
                            for (i1 = 0; i1 < n; i1++)
                            {
                                Write(ARA[i, i1] + " ");
                            }
                            WriteLine(" ");
                        }
                    }
                    else
                        WriteLine("They near by");
                }
                else
                    WriteLine("Ну нет");
            }
            else
                WriteLine("И нет.");
            ReadLine();
        }
    }
}
