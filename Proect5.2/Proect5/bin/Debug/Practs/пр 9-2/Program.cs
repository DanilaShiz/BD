using System;
using static System.Console;

namespace пр_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ReadLine();
            string s1 = ReadLine();
            string s2 = ReadLine();
            int idx = s.LastIndexOf(s1);
            if (idx != -1)
                s = s.Remove(idx, s1.Length).Insert(idx, s2);
            WriteLine(s);
            ReadKey();
            ReadLine();
        }
    }
}
