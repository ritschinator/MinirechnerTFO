using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerTFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Titel("Titel");

            Console.WriteLine("Zahl_1 ?");
            int Zahl_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zahl_2 ?");
            int Zahl_2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Addition");
            Console.WriteLine(Addiere(Zahl_1, Zahl_2));
            Console.WriteLine("Subtraktion");
            Console.WriteLine(Subtrahiere(Zahl_1, Zahl_2));
            Console.WriteLine("Multiplikation");
            Console.WriteLine(Multipliziere(Zahl_1, Zahl_2));

            Console.ReadKey();
        }

        static void Titel(string titel)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < Console.WindowWidth / 2 - titel.Length; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(titel);

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }

        static int Addiere(int Zahl1, int Zahl2)
        {
            return Zahl1 + Zahl2;
        }

        static int Subtrahiere(int Zahl1, int Zahl2)
        {
            return Zahl1 - Zahl2;
        }

        static int Multipliziere(int Zahl1, int Zahl2)
        {
            return Zahl1 * Zahl2;
        }
    }
}
