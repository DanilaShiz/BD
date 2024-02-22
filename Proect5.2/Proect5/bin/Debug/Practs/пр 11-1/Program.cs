using System;
using System.IO;
using static System.Console;

namespace пр_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите подстроку из 3 символов - ");
            string a = ReadLine();
            string b;
            int n = 0, z = 0, k = 0;
            if (a.Length != 3)
            {
                ForegroundColor = ConsoleColor.Red;
                Write("EHE");
            }
            else
            {
                StreamReader text = new StreamReader(@"1.txt");
                while (!text.EndOfStream)
                {
                    b = text.ReadLine();
                    while ((k > -1) & (z < b.Length))
                    {
                        if (b.IndexOf(a, z) > -1)
                        {
                            n++;
                            z = b.IndexOf(a, z) + 1;
                        }
                        else
                            k = b.IndexOf(a, z);
                    }
                }
                z = 0;
                k = 0;
            }
            WriteLine("Было найдено -" + n);
            ReadLine();
        }
    }
}
