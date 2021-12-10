using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kolos1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
            
                Console.WriteLine("Wybierz opcję");
                Console.WriteLine("1. Sortowanie liczb");
                Console.WriteLine("2. Sprawdzanie email");
                Console.WriteLine("3. Rysowanie prostokąta znakiem");
                Console.WriteLine("4. Wyjście");
                ConsoleKeyInfo KP = Console.ReadKey();
                if (KP.Key == ConsoleKey.D4) exit = true;
                // zad 1
                if (KP.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Zadanie 1:");
                    Console.WriteLine("Podaj 3 liczby");
                    string[] liczba = new string[3];
                    for (int i = 0; i < 3; i++)
                    {
                        liczba[i] = Console.ReadLine();
                        while (!int.TryParse(liczba[i], out int si))
                        {

                            Console.WriteLine("To nie jest liczba");
                            liczba[i] = Console.ReadLine();
                        }
                    }

                    Array.Sort(liczba);
                    foreach (string i in liczba)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (KP.Key == ConsoleKey.D2)
                {
                    // zad 2
                    Console.Clear();
                    Console.WriteLine("Zadanie 2:");
                    Console.WriteLine("Podaj Email");
                    string email = Console.ReadLine();
                    var reg = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                    if (!Regex.IsMatch(email, reg, RegexOptions.IgnoreCase))
                    {
                        // if (email.Count(f => f == '@') != 1 || !email.Contains('.') || email[0] != '@') można się bawić...

                        Console.WriteLine("Nieprawidłowy email");
                    }
                    else
                    {
                        string[] dane = email.Split('@', 2);
                        foreach (string d in dane) // alternatywnie po prostu wypisac dane[0] i dane [1]
                        {
                            Console.WriteLine(d.ToUpper());
                        }
                    }
                }

                if (KP.Key == ConsoleKey.D3)
                {
                    // zad 3
                    Console.Clear();
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
                                Console.Write(znak[0]); // bierze tylko pierwszy wpisany znak
                            Console.WriteLine();

                        }
                    }
                    else Console.WriteLine("Szerokość i wysokość muszą być liczbami a znak nie może być pusty");
                }
            }
        }
    }
}