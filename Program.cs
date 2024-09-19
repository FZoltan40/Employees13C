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
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");

            for (int i = 0; i < 100; i++)
            {
                Employer emp = new Employer(sr.ReadLine());
                employers.Add(emp);
            }

            feladat3();
        }
    }
}
