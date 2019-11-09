using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int oper;
            double a;
            double b;
            double wynik = 0;
            bool wybor, koniec = false;
            string operacja = "";
            Console.WriteLine("Program wykonuje podstawowe operacje arytmetyczne na dwoch liczbach");
            do
            {
                while (true)
                {
                    Console.WriteLine("Podaj pierwsza liczbe");
                    if (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Wprowadzono niepoprawną wartość");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Podaj drugą liczbe");
                    if (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Wprowadzono niepoprawną wartość");
                    }
                    else
                    {
                        break;
                    }
                }
                do
                {
                    while (true)
                    {
                        wybor = true;
                        Console.WriteLine("1. Suma liczb");
                        Console.WriteLine("2. Różnica liczb");
                        Console.WriteLine("3. Iloczyn liczb");
                        Console.WriteLine("4. Iloraz liczb");
                        Console.WriteLine("5. Koniec program");
                        Console.WriteLine("Podaj operacje");
                        if (!int.TryParse(Console.ReadLine(), out oper))
                        {
                            Console.WriteLine("Wprowadzono niepoprawną wartość");
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }

                    }
                    switch (oper)
                    {
                        case 1:
                            wynik = a + b; operacja = "Wynik dodawania";
                            break;
                        case 2:
                            wynik = a - b; operacja = "Wynik odejmowania";
                            break;
                        case 3:
                            wynik = a * b; operacja = "Wynik mnożenia";
                            break;
                        case 4:
                            wynik = a / b; operacja = "Wynik dzielenia";
                            break;
                        case 5:
                            koniec = true;
                            break;
                        default:
                            Console.WriteLine("Wybrano niedozwolona opcje");
                            wybor = false;
                            break;
                    }
                } while (!wybor && koniec == false);
                {
                    Console.WriteLine("{0} to: {1}", operacja ,wynik);
                }
                Console.WriteLine();
            } while (!koniec);
        }
    }
}
