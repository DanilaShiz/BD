using System;
using System.IO;
using static System.Console;

namespace пр_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0, c = 0, x1 = 0, x2 = 0, n = 0, s = 0, sr = 0;
            string a;
            StreamReader text = new StreamReader(@"1.txt");
            while (!text.EndOfStream)
            {
                a = text.ReadLine();
                b++;
            }
            text.Close();
            int[] mass = new int[b];
            StreamReader text1 = new StreamReader(@"1.txt", true);
            StreamReader text2 = new StreamReader(@"2.txt", true);
            while (c < b)
            {
                x1 = Convert.ToInt32(text1.ReadLine());
                x2 = Convert.ToInt32(text2.ReadLine());
                mass[c] = x1 + x2;
                s += x1 + x2;
                c++;
            }
            WriteLine("Сумма чисел нового массива :" + s);
            sr = s / 20;
            c = 0;
            WriteLine("Новый массив :");
            while (c < 20)
            {
                if (mass[c] < sr)
                    n++;
                Write(mass[c] + " ");
                c++;
            }
            c = 0;
            WriteLine();
            WriteLine("Число элементов массива которые меньше среднего значения -" + n);
            WriteLine("Среднее значение - " + sr);
            ReadLine();
        }
    }
}
