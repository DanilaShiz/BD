using System;
using System.IO;

namespace пр_14
{
    public class Node
    {
        public string FullName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Price { get; set; }
        public Node Link { get; set; }
        public Node(string fname, string date1, string date2, string price)
        {
            FullName = fname;
            StartDate = date1;
            EndDate = date2;
            Price = price;
        }
        public Node(string fio)
        {
            FullName = fio;
        }
    }
    public class SingleLinkedList
    {
        public Node First { get; private set; }
        public Node Last { get; private set; }
        public void Print()
        {
            Node node = First;
            while (node != null)
            {
                Console.WriteLine($"{node.FullName}\n{node.StartDate}\n{node.EndDate}\n{node.Price}\n");
                if (node == node.Link) return;
                node = node.Link;
            }
        }


        public void Find(string time)
        {
            Node node = First;
            int count = 0;
            int k = 0;
            while (node != null)
            {
                if (node.StartDate == time)
                {
                    count++;
                }
                k++;
                node = node.Link;
            }
            Console.WriteLine($"Найдено {count} записей соответствующих критерию поиска");
            Console.WriteLine("Находится на позиции {0}", k);
        }
        public void Insert(int pos, Node node)
        {
            if (pos < 1) return;
            Node current = First;
            Node previuos = null;
            int n = 0;
            while (++n != pos)
            {
                previuos = current;
                if (current.Link == null)
                {
                    current.Link = node;
                    Last = node;
                    return;
                }
                current = current.Link;
            }
            node.Link = current;
            if (previuos == null)
                First = node;
            else
                previuos.Link = node;
        }
        public void Remove(int pos)
        {
            if (pos < 1) return;
            Node current = First;
            Node previous = null;
            int n = 0;
            while (current != null)
            {
                if (++n == pos)
                {
                    if (previous == null)
                        First = current.Link;
                    else
                        previous.Link = current.Link;
                    if (current.Link == null)
                        Last = current;
                    break;
                }
                previous = current;
                current = current.Link;
            }
            Console.WriteLine("Успешно!");
        }
        public void Add(Node node)
        {
            if (First == null) First = node;
            if (Last == null) Last = node;
            Last.Link = node;
            Last = node;
        }

    }
    class Program
    {
        static void Main()
        {
            SingleLinkedList list = new SingleLinkedList();
            int count = 4;
            string txt = File.ReadAllText(@"1.txt");
            string[] strs = txt.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            for (int i = -1; ++i < count;)
            {
                int n = i * 4;
                Node newnode = new Node(strs[n++], strs[n++], strs[n++], strs[n++]);
                list.Add(newnode);
            }


            while (true)
            {
                Console.WriteLine("         Выбор опции \n");
                Console.WriteLine("1 - Показать список");
                Console.WriteLine("2 - Поиск");
                Console.WriteLine("3 - Удалить");
                Console.WriteLine("4 - Вставить");
                Console.WriteLine("5 - Выход");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            list.Print();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Введите дату: "); string time = Console.ReadLine();
                            list.Find(time);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Введите позицию которую вы хотите удалить: "); int pos = Convert.ToInt32(Console.ReadLine());
                            list.Remove(pos);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Введите позицую:"); int pos = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Введите что вы хотите вставить"); string чтонадовставить = Console.ReadLine();
                            list.Insert(pos, new Node(чтонадовставить));
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
                ReadLine();


            }



        }
    }

}

