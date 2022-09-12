using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Magazine : Printable
    {
        string Name;
        string Geolocation;
        string Specialization;
        public Magazine(string Name, string Geolocation, string Specialization)
        {
            this.Name = Name;
            this.Geolocation = Geolocation;
            this.Specialization = Specialization;
        }

        public void print()
        {
            Console.WriteLine($"Название магазина: {Name}, Расположение: {Geolocation}, Специализация: {Specialization}");
        }

        public static void printMagazines(Printable[] printable)
        {
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i] is Book)
                {
                    printable[i].print();
                }
            }
        }
    }
}
