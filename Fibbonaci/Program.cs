using System;

namespace Fibbonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            string dlugosc;
            int a,b,c = 0;
            while (true)
            {
                Console.WriteLine("Podaj dlugosc ciagu fibbonaciego (liczba naturalna)");
                dlugosc = Console.ReadLine();
                try
                {
                    a = int.Parse(dlugosc);
                    if (a > 0 && a <= 2147483647) break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba przekroczyła zakres dla typu int ");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
            }
            while(true)
            {
                Console.WriteLine("Podaj od ktorego elementu chcesz wyswietlic ciag");
                if (!int.TryParse(Console.ReadLine(), out b) || b<=0 || b>a)
                {
                    Console.WriteLine("Niepoprawny zakres lub format liczby");
                }
                else
                {
                    Console.WriteLine("Podaj do ktorego elementu chcesz wyswietlic ciag");
                    if (!int.TryParse(Console.ReadLine(), out c) || c<=0 || c>a)
                    {
                        Console.WriteLine("Niepoprawny zakres lub format liczby");
                    }
                    else
                    {
                        if(c<b)
                        {
                            Console.WriteLine("Niepoprawny zakres");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Fibbonaci(a, b, c);
            Console.ReadKey();
        }
        static int ReadInt(string komunikat, int min = int.MinValue, int max = int.MaxValue)
        {
            string dlugosc;
            int a = 0;
            while (true)
            {
                Console.WriteLine("Podaj dlugosc ciagu fibbonaciego (liczba naturalna)");
                dlugosc = Console.ReadLine();
                try
                {
                    a = int.Parse(dlugosc);
                    if (a > min && max <= a)
                    {
                        return a;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba przekroczyła zakres dla typu int ");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
            }
        }
        static void Fibbonaci(int a, int b, int c)
        {
            int[] T = new int[a];
            T[0] = T[1] = 1;
            for (int i = 2; i < a; i++)
            {
                T[i] = T[i - 1] + T[i - 2];
            }
            Console.WriteLine("Caly ciag: ");
            for (int i = 0; i < a; i++)
            {
                Console.Write("{0}, ", T[i]);
            }
            Console.WriteLine("\nCiag w zakresie od {0} do {1}",b,c);
            for (int i = b-1; i<c; i++)
            {
                Console.Write("{0}, ", T[i]);
            }
        }
    }
    // http://wsbpoz.pl/pp/pliki/sito.txt
}
