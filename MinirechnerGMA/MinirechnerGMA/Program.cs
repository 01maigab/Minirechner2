using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int Zahl1 = 0;
            int Zahl2 = 0;
            int Aktion = 0;
            int Ergebnis = 0;

            Console.WriteLine("Erste Zahl eingeben:");
            Zahl1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Zweite Zahl eingeben");
            Zahl2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Wähle die Aktion: Subtraktion =2");
            Aktion = Convert.ToInt16(Console.ReadLine());

            if (Aktion == 2)
                Ergebnis = Subtrahieren(Zahl1, Zahl2);



            Console.WriteLine("Ergebnis = " + Ergebnis);
            Console.ReadKey();
        }

        static int Subtrahieren(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 - Zahl2;
            return Erg;

        }
    }

}