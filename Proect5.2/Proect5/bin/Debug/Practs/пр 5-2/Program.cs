using System;
using static System.Console;

namespace пр_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double day = 1;
            double s = 10;
            do
            {
                day = day + 1;
                s = s + s * 0.1;
            }
            while (s < 20);
            WriteLine(day);
            ReadLine();
        }
    }
}
