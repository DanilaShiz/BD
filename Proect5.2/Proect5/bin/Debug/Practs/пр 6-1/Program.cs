using System;
using static System.Console;


namespace Пр_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            WriteLine("Введите n(>1)");
            bool bbbb = int.TryParse(ReadLine(), out n);
            if (bbbb)
            {
                if (n > 1)
                {
                    int[] a = new int[n];
                    Write("Введите массив:");
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
                    int q = a[1] - a[0];
                    for (int i = 0; i < n; i++)
                    {
                        if (a[i] != (a[0] + (i) * q))
                        {
                            q = 0;
                        }
                    }
                    WriteLine("Разность прогресси =" + q);
                }
                else
                    WriteLine("ПРОЧИТАЙТЕ ЕЩЁ РАЗ.");
            }
            else
                Write("Не то.");
            ReadLine();
        }
    }
}
