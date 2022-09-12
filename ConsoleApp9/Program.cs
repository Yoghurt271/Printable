using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Printable[] printable = new Printable[] { new Book("Ведьмак Последнее желание", "Анджей Сапковский", "1993г"),
            new Magazine("Пятерочка", "Александров", "Продажа продуктов питания") };
            for (int i = 0; i < printable.Length; i++)
            {
                printable[i].print();
            }
        }
    }
}
