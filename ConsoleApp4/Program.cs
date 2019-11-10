using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] T = new int[5] { 10, 20, 30, 40, 50 };
            int element;
            Console.WriteLine("Rozmiar tablicy: {0}",T.Length);
            // Wypisanie elementów tablicy forem
            Console.WriteLine("\nWypisanie elementow tablicy forem \n");
            for (int i = 0; i < T.Length; i++)
            {
                element = i + 1;
                Console.WriteLine("Element Tablicy {0}: {1}",element,T[i]);
            }
            // Wypisanie elementow tablicy foreachem
            element = 1;
            Console.WriteLine("\nWypisanie elementow tablicy foreachem \n");
            foreach (int item in T)
            {
                Console.WriteLine("Element Tablicy {0}: {1}",element,item);
                element++;
            }
            // Uzytkownik podaje z klawiatury swoje 3 ulubione kolory, przypisz je do
            // tablicy o nazwie colors a nastepnie wyswietl na ekranie w formacie Kolor 1 : nazwa itd.
            // Do przypisania kolorow do tablicy wykorzystaj pętlę for.
            // Do wyswietlenia kolorow z tablicy wykorzystaj pętlę while
            string[] colors = new string[3];
            element = 1;
            // Przypisanie nazw kolorow do elementow tablicy
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Podaj {0} kolor:",element);
                colors[i] = Console.ReadLine();
                element++;
            }
            element = 1;
            int kolor = 0;
            // Wyswietlenie kolorow w tablicy whilem
            while(element<=3)
            {
                Console.WriteLine("Kolor nr.{0} to: {1}",element,colors[kolor]);
                kolor++;
                element++;
            }

            Console.ReadKey();
        }
    }
}
