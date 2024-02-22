using System;
using static System.Console;

namespace пр_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            WriteLine("Введите строку");
            str = ReadLine();
            if (str != "")
            {
                for (int i = str.Length; i > 0; i--)
                {
                    Write(str[i - 1]);
                }
            }
            ReadKey();
            ReadLine();
        }
    }
}
