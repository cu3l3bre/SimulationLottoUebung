// Uebung b)
// Übung: Simulieren Sie die Ziehung der Lottozahlen(6 aus 49, ggf.mit Zusatzzahl)
// mittels eines logischen Feldes('bool'-Array)
// 
// Hinweis: Bei dessen Instanziierung werden automatisch
// alle 'bool'-Werte mit 'false' initialisiert.

//
// Duplikatsvermeidung: Implementieren Sie eine geeignete Schleife, 
// innerhalb der so lange mit dem Zufallsgenerator('Random'-Objekt)
// neue Index-Werte zwischen 1 und 49 erzeugt werden,
// bis 6 Werte(bzw. 7 Werte bei Variante mit Zusatzzahl)
// auf 'true' gesetzt werden konnten.

//
// Sortierung: Geben Sie mit einer 'for'-Schleife einfach alle Indices aus, 
// deren Wert im 'bool'-Array 'true' ist.


using System;

namespace SimulationLottoUebung
{
    public static class Lotto_B
    {
        public static void simulation()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------");
            Console.WriteLine("--- Lotto B ---");
            Console.WriteLine("---------------");

            bool[] zahlen = new bool[50]; // index entspricht der zahl: 1=1, 2=2 usw
            int tempZahl = 0;
            int anzahlZahlen = 0;

            Random rng = new Random();

            while(anzahlZahlen < 6)
            {
                tempZahl = rng.Next(1, 50);

                if(!zahlen[tempZahl])
                {
                    zahlen[tempZahl] = true;
                    anzahlZahlen++;
                }
                else
                {
                    //Console.WriteLine("Zahl {0} wurde schon gezogen", tempZahl);
                }
            }

            for(int i=1; i<zahlen.Length; i++)
            {
                if(zahlen[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
