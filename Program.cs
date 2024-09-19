using System;
using System.Collections.Generic;
using System.IO;

namespace Employees
{
    internal class Program
    {
        public static List<Employer> employers = new List<Employer>();

        public static void feladat3()
        {
            Console.WriteLine("Az összes dolgozó neve: ");
            foreach (var item in employers)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void feladat4()
        {
            int max = employers[0].Salary;
            int id = 0;

            foreach (var item in employers)
            {
                if (item.Salary > max)
                {
                    max = item.Salary;
                    id = item.Id;
                }
            }

            Console.WriteLine($"A legjobban kereső dogozó Id: {id}, Neve: {employers[id - 1].Name}");

        }

        public static void feladat5()
        {
            Console.WriteLine("Nyugdíj előtt lévők:");
            foreach (var item in employers)
            {
                if (item.Age == 55)
                {
                    Console.WriteLine($"Név: {item.Name}, Kor: {item.Age}");
                }
            }
        }

        public static int feladat6()
        {
            int count = 0;

            foreach (var item in employers)
            {
                if (item.Salary > 50000)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");

            for (int i = 0; i < 100; i++)
            {
                Employer emp = new Employer(sr.ReadLine());
                employers.Add(emp);
            }

            feladat3();
            feladat4();
            feladat5();
            Console.WriteLine($"Összesen {feladat6()} keresnek többet mint 50000 ft.");
        }
    }
}
