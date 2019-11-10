using System;

namespace Tablice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tablice prostokątne
            int[,] T = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            // Wszystkie elementy w tablicy
            Console.WriteLine("Ilosc elementow w tablicy {0}",T.Length);
            Console.WriteLine("{0}",T.GetLength(0));
            Console.WriteLine("{0}",T.GetLength(1));
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    Console.Write("{0}\t",T[i,j]);
                }
                Console.WriteLine();
            }
            // Tablice wielowymiarowe (tablica tablic)
            int[][] tab = new int[][]
            {
                new int[]{1,2},
                new int[]{3,4,5},
                new int[]{6}
            };
            // Wyswietl zawartosc tablicy za pomocą 2 pętli for
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write("{0} ",tab[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
