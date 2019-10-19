using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad 1. Moodle
            /*string str = Console.ReadLine();
            string str1 = Console.ReadLine();
            float a = float.Parse(str);
            float b = float.Parse(str1);
            float wynik = (a * a + b) / (a * a + b * b);
            Console.WriteLine("Wynik wynosi: {0}", wynik);
            Console.ReadKey();

            float a, b;
            Console.Write("Podaj liczbe a ");
            if (!float.TryParse(Console.ReadLine(), out a)) // Jesli blad parsowania to komunikat
            {
                Console.WriteLine("Wprowadzono niepoprawny format liczby");
            }
            else // Jesli format liczby ok to wprowadzamy liczbe b
            {
                Console.Write("Podaj liczbe b ");
                if (!float.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Wprowadzono niepoprawny format liczby");
                }
                else // Jesli oba parsowania ok to obliczanie liczby
                {
                    if (a == -b) Console.WriteLine("Proba dzielenia przez 0");
                    else Console.WriteLine("Wartosc wyrazenia wynosi: " + ((a*a+b)/((a+b)*(a+b))));
                }
            }
            */

            // Zad 2 Moodle
            double a,b,c;
            Console.WriteLine("Podaj liczbe a: ");
            if (!Double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Wprowadzono niepoprawny format liczby a");
            }
            else
            {
                Console.WriteLine("Podaj liczbe b: ");
                if (!Double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Wprowadzono niepoprawny format liczby b");
                }
                else
                {
                    Console.WriteLine("Podaj liczbe c: ");
                    if (!Double.TryParse(Console.ReadLine(), out c))
                    {
                        Console.WriteLine("Wprowadzono niepoprawny format liczby c");
                    }
                    else
                    {
                        if (c > 0)
                        {
                            Console.WriteLine("Wynik wynosi: " + (a*a+b));
                        }
                        if (c < 0)
                        {
                            Console.WriteLine("Wynik wynosi: " + (a - b * b));
                        }
                        if (c == 0)
                        {
                            if(a==b)
                            {
                                Console.WriteLine("Proba dzielenia przez 0");
                            }
                            else
                            {
                                Console.WriteLine("Wynik wynosi: " + (1 / (a - b)));
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
