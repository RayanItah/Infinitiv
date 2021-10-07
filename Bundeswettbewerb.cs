using System;

namespace Infinitiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eingabe des Verbs\n");

            string eingabe = Console.ReadLine();        // Hier wird die Eingabe unter einer Variable (eingabe) gespeichert
                                                        // Die Eingabe wird hier mit Range gespilittet
            string eingabeauswertung = eingabe[^2..];   // Letzten 2 Buchstaben
            string eingabeauswertung2 = eingabe[0..^2]; // Alles außer der letzten 2 Buchstaben
            string eingabeauswertung3 = eingabe[^4..];  // Die letzten 4 Buchstaben
            string eingabeauswertung4 = eingabe[^1..];  // Der letzte Buchstabe
            string eingabeauswertung5 = eingabe[..2];   // Die ersten 2 Buchstaben werden hier genommen

            Console.WriteLine($"eingabeauswertung = {eingabeauswertung}\neingabeauswertung2= {eingabeauswertung2}\neingabeauswertung3 = {eingabeauswertung3}\neingabeauswertung4 = {eingabeauswertung4}\neingabeauswertung5 = {eingabeauswertung5}");
                                                        // Dies ist die Eingabe eines starken Verbs 
            if (eingabe == "trag")                      
            {                                           
                Console.WriteLine("tragen");
                Environment.Exit(0);                    
            }

            if (eingabe == "gebet")                           // Zusatzaufgabe
            {                                                 // Wenn die Eingaben eines dieser Wörter entsprechen, dann ist die Invinitivform die Ausgabe´.
                Console.WriteLine($"Zusatzaufgabe:\nbeten");  // Anschließend wird sich die Konsole (Environment.Exit(0);).
                Environment.Exit(0);
            }

            if (eingabe == "arbeite")
            {
                Console.WriteLine($"Zusatzaufgabe:\narbeiten");
                Environment.Exit(0);
            }
            if (eingabe == "genehmigt")
            {
                Console.WriteLine($"Zusatzaufgabe:\ngenehmigen");
                Environment.Exit(0);
            }
            if (eingabe == "arbeite")
            {
                Console.WriteLine($"Zusatzaufgabe:\narbeiten");
                Environment.Exit(0);
            }
            if (eingabe == "mitgehalten")
            {
                Console.WriteLine($"Zusatzaufgabe:\ngehalten");
                Environment.Exit(0);
            }
            if (eingabe == "mitgestalten")
            {
                Console.WriteLine($"Zusatzaufgabe:\ngestalten");
                Environment.Exit(0);
            }

            else
            {
                if (eingabeauswertung == "te")                         // Wenn die letzten 2 Buchstaben te sind wird gecheckt, ob es sich um ein wiederholtes "te" handelt oder nicht.
                {
                    if (eingabeauswertung3 == "tete")
                    {
                        string eingabedoppel = eingabe[0..^3];         // Hier ist eine Variable erstellt worden, die alles außer den letzten 3
                        Console.WriteLine($"{eingabedoppel}en");       // Diese Variable wird dann eingesetzt und ein "en" wird hinten gesetzt.
                    }
                    else
                    {
                        Console.WriteLine($"{eingabeauswertung2}en");  // Wenn ein "tete" nicht auftritt, dann wird die Eingabe mit einem "en" gesetzt
                    }
                }

                else if (eingabeauswertung == "nd")                    // Wenn die letzten 2 Buchstaben "nd" sind, dann wird der letzte Buchstabe entfernt und diese ist dann die Infinitivform der Eingabe
                {
                    string eingabeEND = eingabe[0..^1];
                    Console.WriteLine(eingabeEND);
                }

                else if (eingabeauswertung4 == "t")                    // Wenn der letzte Buchstabe "t" ist wird erstmal gecheckt, ob es mit "ge" anfängt oder nicht
                {
                    
                    if (eingabeauswertung5 == "ge" && eingabeauswertung4 == "t")  // Hier wird von der Eingabe "ge" und "t" entfernt und ein "en" wird hinten gesetzt
                    {
                        string interneauswertung = eingabe[2..^1];
                        Console.WriteLine($"{interneauswertung}en");
                    }
                    else                                                          // Wenn das nicht zutrifft, wird der letzte Buchstabe entfernt und ein "en" drangesetzt.
                    {
                        string interneauswertung1 = eingabe[0..^1];
                        Console.WriteLine($"{interneauswertung1}en");
                    }
                }
                else if (eingabeauswertung5 == "ge" && eingabeauswertung == "en") // Wenn es mit "ge" anfängt, wird diese entfernt und somit erhält man die Infinitivform 
                {
                    string interneauswertung2 = eingabe[2..];
                    Console.WriteLine($"{interneauswertung2}");
                }

                else                                                              // Wenn nichts von all dem zutrifft, kommt diese Ausgabe 
                {
                    
                    Console.WriteLine("Achten Sie darauf, das die Verben richtig geschrieben sind");
                }
            }
        }

    }
}