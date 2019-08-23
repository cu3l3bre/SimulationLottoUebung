
#region Aufgabe_a
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
#endregion


#region Aufgabe_b
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

#endregion


using System;

namespace SimulationLottoUebung
{
    class Program
    {
        static void Main(string[] args)
        {
            Lotto_A.simulation();
            Lotto_B.simulation();


            Console.ReadKey();

        }
    }
}
