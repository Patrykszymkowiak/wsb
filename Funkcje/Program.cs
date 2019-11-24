using System;

namespace Funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1, 2, 3);
            Console.WriteLine("Pole wynosi: " + SquareArea(4));
            // Domyslnie uzywa funkcji 4 parametrowej podajac 1 argument
            Console.WriteLine("Wynik dodawania wynosi: " + Add(1));
            // Za pomocą : zmieniamy wartosc parametru w funkcji
            Console.WriteLine("Wynik dodawania wynosi: " + Add(1,d:2));
            Data("Janusz",wiek:30);
            // Zadanie 1
            bool b = true;
            int a = 0;
            Console.WriteLine("Program sprawdzajacy czy liczba jest Parzysta. \nPodaj liczbe:");
            while (b == true)
            {
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Wprowadzono niepoprawną wartość");
                }
                else
                {
                    b = false;
                    Parzyste(a);
                }
            }
            // Zadanie 2
            int c;
            Console.WriteLine("Program zliczajacy wszystkie cyfry. \nPodaj liczbe:");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Wprowadzono niepoprawną wartość");
                }
                else
                {
                    SumaCyfr(c);
                    break;
                }
            }
            // Zadanie 3
            int x = 3;
            Console.WriteLine("X w mainie wynosi: "+x);
            Increment(ref x);
            Increment(ref x);
            Increment(ref x);
        }
        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania: " + result);
        }
        static void Add(int a,int b,int c)
        {
            int result = a + b + c;
            Console.WriteLine("Wynik dodawania: " + result);
        }
        static int SquareArea(int a)
        {
            return a*a;
        }
        static int Add(int a, int b = 3, int c = 2, int d = 1)
        {
            return a + b + c + d;
        }
        static void Data(string name, string nazwisko = "Nowak", int wiek = 20 )
        {
            Console.WriteLine("Imie: {0}, Nazwisko: {1}, Wiek: {2}",name,nazwisko,wiek);
        }

        // Zadanie 1. Napisz program który sprawdza czy liczba calkowita podana przez uzytkownika 
        // Jest parzysta lub nieparzysta 
        // Napisz funkcje ktora przyjmuje jako argument liczbe calkowita podana przez uzytkownika 
        // z klawiatury
        static void Parzyste(int a)
        {
            if(a%2==0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }
        }
        // Zadanie 2. Napisz program liczacy sume cyfr w liczbie calkowitej
        static void SumaCyfr(int a)
        {
            int result = 0;
            do
            {
                result = result + a%10;
                a = a / 10;
            }
            while (a != 0);
            Console.WriteLine("Suma cyfr wynosi: "+result);
        }
        // Zadanie 3. 
        static void Increment(ref int x)
        {
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji wynosi: "+x);
        }
    }
}
