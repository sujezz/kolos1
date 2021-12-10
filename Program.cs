using System;
using System.Linq;

namespace Kolos1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // zad 1

            Console.WriteLine("Zadanie 1:");
            Console.WriteLine("Podaj 3 liczby oddzielając spacją");
            string[] liczba = Console.ReadLine().Split(' ');
            foreach (string str in liczba)
            {
                if (liczba.Count() != 3 || !int.TryParse(str, out int id))
                {
                    Console.WriteLine("Miały być 3 liczby!");
                    Environment.Exit(0);
                }

            }
            Array.Sort(liczba);
            foreach (string i in liczba)
            {
                Console.WriteLine(i);
            }

            // zad 2

            Console.WriteLine("Zadanie 2:");
            Console.WriteLine("Podaj Email");
            string email = Console.ReadLine();
            if (!email.Contains('@') || !email.Contains('.'))
            {
                Console.WriteLine("Nieprawidłowy email");
                Environment.Exit(0);
            }
            string[] dane = email.Split('@', 2);
            foreach (string d in dane) // alternatywnie po prostu wypisac dane[0] i dane [1]
            {
                Console.WriteLine(d);
            }

            // zad 3

            Console.WriteLine("Zadanie 3:");
            string szerokosc, wysokosc, znak;
            Console.WriteLine("Podaj szerokość");
            szerokosc = Console.ReadLine();
            Console.WriteLine("Podaj wysokość");
            wysokosc = Console.ReadLine();
            Console.WriteLine("Podaj znak");
            znak = Console.ReadLine();
            if (int.TryParse(szerokosc, out int x) && int.TryParse(wysokosc, out int y) && znak.Length > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                        Console.Write(znak[0]);
                    Console.WriteLine();

                }
            }
            else Console.WriteLine("Szerokość i wysokość muszą być liczbami a znak nie może być pusty");
            Console.ReadKey(); // niektórym od razu zamyka konsole
        }
    }
}