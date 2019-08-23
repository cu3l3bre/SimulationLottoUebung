// Uebung a)
//
// Simulation der Ziehung von Lottozahlen (6 aus 49),
// indem die 6 "gezogenen" Zahlen in einem Array abgespeichert werden
//
//                  - dabei ist zu vermeiden, dass Duplikate entstehen
//                  - mit Zusatzzahl
//                  - mit Sortierung der Ziehungszahlen (ohne Zusatzzahl)
//
//      Varianten: (1) immer 7 Zahlen "ziehen" und erst dann auf Duplikate prüfen
//                 (2) für jede "gezogene" Zahl prüfen, ob sie ein Duplikat ist (Übungsvorschlag)
//
//      Übung: Implementierung der Variante (2)
//     


using System;

namespace SimulationLottoUebung
{
    // hier mach ich static weil ich will eigentlich kein objekt erzeugen
    // macht dann hier so keinen sinn, ne objekt von zu machen
    public static class Lotto_A
    {

       public static void simulation()
       {
            Console.WriteLine("");
            Console.WriteLine("---------------");
            Console.WriteLine("--- Lotto A ---");
            Console.WriteLine("---------------");

            int[] zahlen = new int[7];
            int tempZahl = 0;

            Random rng = new Random();
            bool zahlVorhanden;


            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlVorhanden = true;
                while (zahlVorhanden)
                {
                    zahlVorhanden = false;
                    tempZahl = rng.Next(1, 49);

                    for (int j = 0; j < i; j++)
                    {
                        if (tempZahl == zahlen[j])
                        {
                            zahlVorhanden = true;
                            //Console.WriteLine("Zahl gibts schon {0} = {1}", tempZahl, zahlen[j]);
                        }
                    }

                    if (!zahlVorhanden)
                    {
                        zahlen[i] = tempZahl;
                    }
                }
            }

            Array.Sort(zahlen,0,6);
  
            for (int i= 0; i<zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
                if(i==zahlen.Length-2)
                {
                    Console.WriteLine("----Zusatzzahl-----");
                }
            }
       }
    }
}
