using System;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again.ToLower() == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Výpis řady čísel *****");
            Console.WriteLine("****************************");
            Console.WriteLine("******* Tomáš Žižka ********");
            Console.WriteLine("****************************");
            Console.WriteLine();

            // Vstup hodnot do programu s kontrolou správnosti
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first = GetValidInt();

            Console.Write("Zadejte poslední číslo řady (celé číslo): ");
            int last = GetValidInt();

            Console.Write("Zadejte diferenci (celé číslo): ");
            int step = GetValidInt();

            // Výpis zadaných hodnot
            Console.WriteLine();
            Console.WriteLine("Zadali jste tyto hodnoty: ");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0}", last);
            Console.WriteLine("Diference: {0}", step);

            // Výpis řady
            Console.WriteLine();
            Console.WriteLine("==================");
            Console.WriteLine("Výpis číselné řady");
            int current = first;
            while(current <= last) {
                Console.WriteLine(current);
                current += step; // Přičtení diference
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A, jinak stiskněte libovolnou jinou klávesu.");
            again = Console.ReadLine().ToLower();
        }
    }

    static int GetValidInt() {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value)) {
            Console.Write("Nezadali jste celé číslo. Zkuste to znovu: ");
        }
        return value;
    }
}
