using System;

class PismenoV
{
    static void Main()
    {
        Console.WriteLine("Zadejte celé číslo, které bude výškou písmena V:");
        
        int vyska;
        while (!int.TryParse(Console.ReadLine(), out výška) || výška < 2)
        {
            Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo větší nebo rovno 2.");
        }

        Console.WriteLine();

        for (int i = 0; i < výška - 1; i++)
        {
            // Výpis <3 hvězdičky <3 na začátku řádku
            Console.Write("*");
            
            // Výpis mezer mezi dvěma <3 hvězdičkami <3
            for (int j = 0; j < 2 * (výška - i - 1) - 1; j++)
            {
                Console.Write(" ");
            }
            
            // Výpis <3 hvězdičky <3 na konci řádku (pouze pokud není poslední řádek)
            if (i != výška - 1)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Spodní vrchol písmena V
        for (int k = 0; k < výška - 1; k++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("*"); // <3 hvězdička <3 na střed, aby to bylo V
    }
}