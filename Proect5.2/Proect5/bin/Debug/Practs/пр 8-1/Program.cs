using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            Write("Вводи-");
            bool bbbb = int.TryParse(ReadLine(), out r);
            if (bbbb)
            {
                int[] mass = new int[r];
                int[] orig = new int[r];
                for (int i = 0; i < orig.Length; i++)
                {
                    Write("Введите" + (i + 1) + "элемент массива: ");
                    orig[i] = Convert.ToInt32(ReadLine());
                }
                WriteLine("Массив");
                for (int i = 0; i < orig.Length; i++)
                {
                    Write(orig[i] + "");
                }
                Array.Copy(orig, mass, r);
                WriteLine(" ");
                WriteLine("Отфильтрованный массив");
                for (int i = 0; i < mass.Length; i++)
                {
                    int min = i;
                    for (int j = i; j < mass.Length; j++)
                    {
                        if (mass[j] < mass[min])
                        {
                            min = j;
                        }
                    }
                    int t = mass[i];
                    mass[i] = mass[min];
                    mass[min] = t;
                    Write(mass[i] + " ");
                }
                Array.Copy(orig, mass, r);
                WriteLine(" ");
                WriteLine("Отфильтрованный массив...Ещё раз");
                for (int i = 0; i < mass.Length; i++)
                {
                    for (int j = mass.Length - 1; j > 0 + i; j--)
                    {
                        if (mass[j] < mass[j - 1])
                        {
                            int t = mass[j];
                            mass[j] = mass[j - 1];
                            mass[j - 1] = t;
                        }
                    }
                }
                for (int i = 0; i < mass.Length; i++)
                    WriteLine(mass[i] + " ");
                WriteLine(" ");
                WriteLine("ФИЛЬТРАЦИЯ 2.0");

                Array.Copy(orig, mass, r);
                WriteLine(" ");
                WriteLine("Отфильтрованный массив...Ещё раз");
                for (int i = 0; i < mass.Length; i++)
                {
                    for (int j = 0; j < mass.Length - i - 1; j++)
                    {
                        if (mass[j] > mass[j + 1])
                        {
                            int t = mass[j];
                            mass[j] = mass[j + 1];
                            mass[j + 1] = t;
                        }
                    }
                }
                for (int i = 0; i < mass.Length; i++)
                    WriteLine(mass[i] + " ");
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
            }
            else
                WriteLine("Не Сообщение.");
            ReadLine();
        }
    }
}
