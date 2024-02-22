using System;
using static System.Console;

namespace пр_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, p, s, summa, k1, p1, s1, i;
            Write("Введите количество простыней: ");
            bool bb = int.TryParse(ReadLine(), out k);
            Write("Введите количество пододеальников: ");
            bool bbb = int.TryParse(ReadLine(), out p);
            Write("Введите количество скатертей: ");
            bool bbbb = int.TryParse(ReadLine(), out s);
            if (bb && bbb && bbbb)
            {
                k1 = k * 500;
                p1 = p * 500;
                s1 = s * 500;
                summa = k1 + p1 + s1;
                i = summa / 12000;
                Write("Израсходовано пачек" + i);
            }
            else
                Write("ПОЖАЛУЙ ЦИФРЫ.");
            ReadLine();
        }

    }
}
