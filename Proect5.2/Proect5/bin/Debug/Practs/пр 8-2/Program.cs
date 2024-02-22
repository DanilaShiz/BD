using System;
using static System.Console;

namespace пр_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Сортировка массивов"); //ЗАДАНИЕ №2
            int a = 0;
            int n;
            bool bbb = int.TryParse(ReadLine(), out n);
            if (bbb)
            {
                int[] dd = new int[n];
                int temp;
                if (n >= 1)
                {
                    while (a < n)
                    {
                        Write("Введите число = ");
                        dd[a] = Convert.ToInt32(ReadLine());
                        a++;
                    }
                    a = 0;
                    WriteLine("МАССИВ");
                    while (a < n)
                    {
                        Write(dd[a]);
                        a++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            if (dd[i] > dd[j])
                            {
                                temp = dd[i];
                                dd[i] = dd[j];
                                dd[j] = temp;
                            }
                        }
                    }
                    a = 0;
                    WriteLine("Отсортированный массив");
                    while (a < n)
                    {
                        WriteLine(dd[a]);
                        a++;
                    }
                    WriteLine("Поиск элементов в массиве");
                    Write("Введите число = ");
                    int b = Convert.ToInt32(ReadLine());
                    int L = 0;
                    int R = n - 1;
                    int R1 = R;
                    int L1 = L;
                    int k = (R + L) / 2;
                    int F = 0;
                    while ((L < R - 1) | (F == 0) & ((R >= L1) & (L <= R1)))
                    {
                        k = (R + L) / 2;
                        if (dd[k] == b)
                        {
                            WriteLine("Элемент найден на позиции -" + k);
                            F = 1;
                        }
                        if (dd[k] < b)
                            L = k + 1;
                        else
                            R = k;
                    }
                    if (F == 0)
                    {
                        WriteLine("Элемент не найден");
                    }
                }
                else
                    WriteLine("Массива не существует");
                ReadKey();
            }
            else
                WriteLine("Сообщение.");
            ReadLine();
        }
    }
}
