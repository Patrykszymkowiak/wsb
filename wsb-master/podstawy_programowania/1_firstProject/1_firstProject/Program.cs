using System;

namespace _1_firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /* zajecia 1
            Console.Write("Imie: ");
            Console.WriteLine("Janusz");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("#\n##\n###");
            string name = "Patryk";
            Console.WriteLine("Masz na imię " + name); // Konkatynancja +
            Console.WriteLine("Masz na imię {0}", name);
            int age = 23;
            Console.WriteLine("Masz na imię {0}, twój wiek {1}", name, age);
            sbyte age1 = 23;
            Console.WriteLine("Masz na imię {0}, twój wiek1 {1}", name, age1);
            Console.ReadKey();
            */

            /* Zajecia 2
            // Uzytkownik podaje z klawiatury bok kwadratu i oblicza pole kwadratu
            Console.Write("Podaj bok a: ");
            string a = Console.ReadLine();
            double boka = double.Parse(a);
            
            // 1 sposób
            double pole;
            pole = boka * boka;
            Console.WriteLine("Pole kwadratu wynosi: {0}", pole);

            // 2 sposób
            double pole;
            boka *= boka;
            Console.WriteLine("Pole kwadratu wynosi: {0}", boka);
            ############################################################
            // Pole trojkata
            Console.WriteLine("Podaj podstawe trojkata");
            string podstawa = Console.ReadLine();
            double p = double.Parse(podstawa);
            Console.WriteLine("Podaj wysokosc trojkata");
            string wysokosc = Console.ReadLine();
            double h = double.Parse(wysokosc);
            double pole = (p*h)/2; // double pole = 0.5 * double.Parse(podstawa) * double.Parse(wysokosc);          bez deklaracji innych zmiennych i przypisania im wartości
            Console.WriteLine("Pole trojkata wynosi: {0}", pole);
            Console.Clear(); */
            /*
            string str;
            int liczba;
            Console.WriteLine("Podaj liczbe calkowita");
            str = Console.ReadLine();
            // liczba = int.Parse(str);
            if (int.TryParse(str, out liczba) == false)
                Console.WriteLine("Zły format liczby");
            else
                Console.WriteLine("LIczba wynosi: {0}", liczba);

            // Sprawdz czy liczba podana z klawiatury jest prawidlowa, nastepnie sprawdz czy jest parzysta.
            uint numberuint;
            Console.WriteLine("Podaj liczbe całkowitą");
            string number = Console.ReadLine();
            if (uint.TryParse(number, out numberuint) == true)
            {
                if (numberuint % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest parzysta", numberuint);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest nieparzysta", numberuint);
                }
            }
            else
            {
                Console.WriteLine("Podane dane z klawiatury są błędne");
            }
            ######################################################################*/
            //

            sbyte wiek = 3;
            switch(wiek)
            {
                case 5:
                    Console.WriteLine("Liczba = 5");
                break;
                case 10:
                    Console.WriteLine("Liczba = 10");
                break;
                default:
                    Console.WriteLine("Liczba wynosi: {0}",wiek);
                break;
            }
            Console.ReadKey();
        }
    }
}
