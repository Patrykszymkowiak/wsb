using System;

namespace _23_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int liczba,dzielnik;
            string we;
            while(true)
            {
                Console.Write("Podaj liczbe ");
                we = Console.ReadLine();
                try
                {
                    liczba = int.Parse(we);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Spróbuj jeszcze raz");
            }
            // Deklaracaja tablicy o 1 większej niż liczba
            bool[] sito = new bool[liczba + 1];
            // Wypelnienie tablicy wartosciami true
            for(int i = 0; i<=liczba; i++)
            {
                sito[i] = true;
            }
            // Sito erastoteneesa do wyszukania liczb pierwszych w zakresie
            for(int i = 2; i<=liczba; i++)
            {
                if(sito[i]==true)
                {
                    x = i;
                    x = x + i;
                    while(x<=liczba)
                    {
                        sito[x] = false;
                        x = x + i;
                        // Wyznaczanie dzielnika
                        if(x==liczba)
                        {
                            dzielnik = i;
                        }
                    }
                    // Jezeli znajdujemy dzielnik wiekszy od 1 wychodzimy z fora bo liczba jest i tak złożona
                    if(dzielnik>1)
                    {
                        break;
                    }
                }
            }
            /*
            Console.WriteLine("Liczby pierwsze w tym zakresie:");
            for (int i=1; i<=liczba; i++)
            {
                if(sito[i]==true)
                Console.Write(i + " ");
            }
            */
            if(sito[liczba] == true)
            {
                Console.WriteLine("Liczba {0} jest liczbą pierwszą", liczba);
            }
            else
            {
                Console.WriteLine("Liczba {0} jest liczbą złożoną podzielną przez {1}", liczba,dzielnik);
            }
        }
    }
}
