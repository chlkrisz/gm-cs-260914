using System;
using System.Collections.Generic;
using System.Linq;

namespace _260914_Ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. FELADAT - számok összege
            int osszeg = 0; // A végső összeg yay
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Kérem a(z) {0}. számot: ", i + 1);
                int szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
            }
            Console.WriteLine("A számok összege: {0}", osszeg);

            //// 2. FELADAT - random szamok
            Random rnd = new Random();
            List<int> randomSzamok = new List<int>();
            for (int i = 0; i < 10; i++) //10 random szam 1 es 100 kozott
            {
                randomSzamok.Add(rnd.Next(1, 101));
            }
            Console.WriteLine("A random számok: {0}", string.Join(", ", randomSzamok));
            Console.WriteLine("A legnagyobb random szám: {0}", randomSzamok.Max());
            Console.WriteLine("A legkisebb random szám: {0}", randomSzamok.Min());

            //// 3. FELADAT - szamok bekerese
            List<int> szamok = new List<int>();
            int last = 0;
            do {
                Console.Write("Kérek egy számot: ");
                last = Convert.ToInt32(Console.ReadLine());
                if (last != 0)
                {
                    szamok.Add(last);
                }
            } while (last != 0);
            Console.WriteLine("{0} számot adott meg.", szamok.Count);

            //// 4. FELADAT - csillagok csillagok mondjátok el nekem
            Console.Write("Kérem a csillagok számát: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}