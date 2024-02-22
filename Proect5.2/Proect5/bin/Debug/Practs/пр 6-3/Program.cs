using System;
using static System.Console;

namespace пр_6_3
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
                    int[] A = new int[n];
                    int[] C = new int[n];
                    int[] B = new int[n];
                    Write("Заполните массив A[{0}]:", n);
                    for (int i = 0; i < n; i++)
                    {
                        bool bbb = int.TryParse(ReadLine(), out A[i]);
                        if (bbb)
                        {
                            WriteLine(" ");
                        }
                        else
                            break;
                    }
                    int b1 = 0;
                    int c1 = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (A[i] > 0)
                        {
                            B[b1] = A[i]; b1++;
                        }
                        else
                        {
                            C[c1] = A[i]; c1++;
                        }
                    }
                    WriteLine("Размер массива B = {0}", b1);
                    for (int i = 0; i < b1; i++)
                        Write("B[{0}]={1};", i, B[i]);
                    WriteLine("\nРазмер массива C = {0}", c1);
                    for (int i = 0; i < b1; i++)
                        Write("C[{0}]={1};", i, C[i]);
                    ReadKey();
                }
                else
                    WriteLine("Не хватает дерева.");
            }
            else
                Write("НЕEEE. Ошибка.");
            ReadLine();
        }
    }
}
