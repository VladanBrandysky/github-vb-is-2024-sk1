using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Proměnná "again" uchovává rozhodnutí uživatele, zda chce program spustit znovu
        string again = "a";

        // Cyklus "while" pokračuje, dokud uživatel zadá "a" (pro opakování programu)
        while (again.ToLower() == "a")
        {
            // Vyčistí konzoli, aby se text zobrazoval čistě bez předchozích výstupů
            Console.Clear();

            // Tiskne nadpis programu na obrazovku
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            // Zde uživatel zadává počet generovaných čísel
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            // Kontrola, zda uživatel zadal platné celé číslo a je větší než 0
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Nezadali jste kladné celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            // Zadání dolní a horní meze s kontrolou, že dolní mez není větší než horní mez
            int dm, hm;
            do
            {
                // Zadání dolní meze
                Console.Write("Zadejte dolní mez (celé číslo): ");
                // Kontrola, zda je zadána hodnota jako celé číslo
                while (!int.TryParse(Console.ReadLine(), out dm))
                {
                    Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
                }

                // Zadání horní meze
                Console.Write("Zadejte horní mez (celé číslo): ");
                // Kontrola, zda je zadána hodnota jako celé číslo
                while (!int.TryParse(Console.ReadLine(), out hm))
                {
                    Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
                }

                // Zkontroluje, že dolní mez není větší než horní mez
                if (dm > hm)
                {
                    Console.WriteLine("Dolní mez nemůže být větší než horní mez. Zadejte znovu.");
                }
            } while (dm > hm);

            // Potvrdí zadání a vypíše hodnoty, které uživatel zadal
            Console.WriteLine("\n==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==========================================\n");

            // Vytvoří pole, do kterého se uloží náhodná čísla
            int[] myArray = new int[n];
            // Vytvoří objekt "Random" pro generování náhodných čísel
            Random randomNumber = new Random();

            // Generuje náhodná čísla a ukládá je do pole
            Console.WriteLine("Náhodná čísla:");
            for (int i = 0; i < n; i++)
            {
                // Generuje náhodné číslo mezi dolní a horní mezí
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0}; ", myArray[i]);
            }

            // Vytvoří objekt Stopwatch pro měření času
            Stopwatch stopwatch = new Stopwatch();
            // Spustí měření času
            stopwatch.Start();

            // Seřazení pole vzestupně pomocí Bubble Sort algoritmu
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Pokud je aktuální prvek větší než následující, prohodí je
                    if (myArray[j] > myArray[j + 1])
                    {
                        int tmp = myArray[j + 1];
                        myArray[j + 1] = myArray[j];
                        myArray[j] = tmp;
                    }
                }
            }

            // Zastaví měření času
            stopwatch.Stop();

            // Vypíše potřebný čas na seřazení pole pomocí Bubble Sort algoritmu
            Console.WriteLine("\n\nPotřebný čas na seřazení pole pomocí algoritmu Bubble sort: {0} ms", stopwatch.ElapsedMilliseconds);

            // Vypíše seřazené pole
            Console.WriteLine("\n\nSeřazené pole:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}; ", myArray[i]);
            }

            // Zeptá se uživatele, zda chce program spustit znovu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu 'A'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();
        }
    }
}
