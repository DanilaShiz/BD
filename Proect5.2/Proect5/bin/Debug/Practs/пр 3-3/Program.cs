using System;
using static System.Console;

namespace пр_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght;
            int u;
            Write("Введите единицы измерения (1 - дециметр, 2 - километр, 3 - метр, 4 - миллиметр, 5 - сантиметр):");
            while (!int.TryParse(ReadLine(), out u) || u < 1 || u > 5)
            {
                Write("Ошибка при ввода!\n Введите ещё раз единицы измерения (1 - дециметр, 2 - километр, 3 - метр, 4 - миллиметр, 5 - сантиметр):");
            }
            Write("Введите длину в указанных единицах измерения:");
            while (!double.TryParse(ReadLine(), out lenght))
            {
                Write("Ошибка при ввода!\n Введите ещё раз длину в указанных единицах измерения:");
            }
            WriteLine($"\n Указанная длина составляет в метрах {Lenght(u, lenght)}");
            ReadLine();
            double Lenght(int u, double length)
            {
                switch (u)
                {
                    case 1: return lenght * 0.1;
                    case 2: return lenght * 1000.0;
                    case 3: return lenght;
                    case 4: return lenght * 0.001;
                    case 5: return lenght * 0.01;
                    default: throw new ArgumentException("Данной величины не существует");
                }
            }
            ReadLine();
        }
    }
}
