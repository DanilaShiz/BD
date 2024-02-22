using System;
using System.IO;

namespace пр_13
{
    class Program
    {
        struct Info
        {
            public string FIO;
            public string date;
            public string datexit;
            public string cost;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество человек , которое вы хотите увидеть-");
            bool bb = int.TryParse(Console.ReadLine(), out n);
            if (bb)
            {
                Info[] info = new Info[n];
                var sr = new StreamReader(@"1.txt", true);
                int number = 1;
                for (int i = -1; ++i < n;)
                {
                    Console.WriteLine("Клиент №" + number);
                    info[i].FIO = sr.ReadLine();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("ФИО: " + info[i].FIO);
                    info[i].date = sr.ReadLine();
                    Console.WriteLine("Дата сдачи: " + info[i].date);
                    info[i].datexit = sr.ReadLine();
                    Console.WriteLine("Дата выдачи:" + info[i].datexit);
                    info[i].cost = sr.ReadLine();
                    Console.WriteLine("Стоимость ремонта:" + info[i].cost);
                    Console.WriteLine("==------------------------==");
                    sr.ReadLine();
                    sr.ReadLine();
                    number++;
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("Поиск человека: (Введите дату сдачи) ");
                string Find = Console.ReadLine();
                for (int i = -1; ++i < n;)
                    for (int j = -1; ++j < Find.Length;)
                        if (info[i].date == Find)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Клиент найден!");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("ФИО: " + info[i].FIO);
                            Console.WriteLine("Дата сдачи: " + info[i].date);
                            Console.WriteLine("Дата выдачи: " + info[i].datexit);
                            Console.WriteLine("Стоимость ремонта:" + info[i].cost);
                            Console.WriteLine("========================");
                            Console.ReadKey();
                        }
            }
            else
                Console.WriteLine("НУ да");
            ReadLine();
        }
    }
}
