using System;
using static System.Console;

namespace пр_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("DDDD");
            double a, b, p, a1, b1;
            string l;
            Write("Старая цена на первый товар: ");
            bool bb = double.TryParse(ReadLine(), out a);
            Write("Старая цена на второй товар: ");
            bool bbb = double.TryParse(ReadLine(), out b);
            Write("Процент: ");
            bool bbbb = double.TryParse(ReadLine(), out p);
            if (bb && bbb && bbbb)
            {
                double V = a * (100.0 + p) / 100.0;
                a1 = V;
                double V1 = b * (100.0 + p) / 100.0;
                b1 = V1;
                WriteLine("Старая цена первого и второго товара: " + a + "; " + b);
                WriteLine("Новая цена первого и второго товара: " + a1 + "; " + b1);
            }
            else
                WriteLine("ЦИФРЫ НАДО!!!!");
            ReadLine();
            
        }
    }
}
