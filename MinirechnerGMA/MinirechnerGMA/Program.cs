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

            Console.WriteLine("Wähle die Aktion: Addition =1, Subtraktion =2 , Multiplication =3, Division=4");
            Aktion = Convert.ToInt16(Console.ReadLine());

            if(Aktion == 1)
                Ergebnis = Addieren(Zahl1, Zahl2);

            if (Aktion == 2)
                Ergebnis = Subtrahieren(Zahl1, Zahl2);

            if (Aktion == 3)
                Ergebnis = Multiplizieren(Zahl1, Zahl2);

            if (Aktion == 4)
                Ergebnis = Dividieren(Zahl1, Zahl2);

            

            Console.WriteLine("Ergebnis = " + Ergebnis);
            Console.ReadKey();
        }

        static int Addieren(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 + Zahl2;
            return Erg;
        }

        static int Subtrahieren(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 - Zahl2;
            return Erg;
        }
        static int Multiplizieren(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 * Zahl2;
            return Erg;
        }
        static int Dividieren(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 / Zahl2;
            return Erg;
        }
       
        }
    }

