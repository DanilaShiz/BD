using System;
using static System.Console;

namespace пр_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, s = 0;
            int n;
            Write("Размерность массива: ");
            bool bbbb = int.TryParse(ReadLine(), out n);
            if (bbbb)
            {

                if (n > 1)
                {
                    int[] a = new int[n];
                    Write("Введите элементы массив:");
                    for (int i = 0; i < n; i++)
                    {
                        bool bbb = int.TryParse(ReadLine(), out a[i]);
                        if (bbb!)
                        {
                            Write("Введите следу. число:");
                        }
                        else
                            break;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (a[i] == a[j])
                                k = k + 1;
                        }
                        if (k == 1)
                            s = s + 1;
                        k = 0;
                    }
                    WriteLine("Количество различных элементов =" + s);
                    ReadKey();
                }
                else
                    WriteLine("Не-а.");
            }
            else
                Write("НЕ цифра.");
            ReadLine();
        }
    }
}
