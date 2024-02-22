using System;
using static System.Console;

namespace пр_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Система замены на онлайн:");
            Write("Введите текст:");
            string c = ReadLine();
            string s;
            s = "";
            for (int i = 0; i < c.Length; i++)
            {
                if ((c[i] == 'o') && (c[i + 1] == 'n'))
                {
                    s = s + "online";
                    i++;
                }
                else
                    s = s + c[i];
            }
            WriteLine(s);
            ReadLine();
        }
    }
}
