using System;

namespace _1_firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Imie: ");
            Console.WriteLine("Janusz");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("#\n##\n###");
            string name = "Patryk";
            Console.WriteLine("Masz na imię " + name); // Konkatynancja +
            Console.WriteLine("Masz na imię {0}",name);
            int age = 23;
            Console.WriteLine("Masz na imię {0}, twój wiek {1}",name,age);
            sbyte age1 = 23;
            Console.WriteLine("Masz na imię {0}, twój wiek1 {1}", name, age1);
            Console.ReadKey();
        }
    }
}
