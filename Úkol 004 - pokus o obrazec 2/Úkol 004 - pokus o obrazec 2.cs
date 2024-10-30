using System;
using System.Threading;

class Obrazce
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("Zadejte číslo, nebo něco, to je jedno.");
            
            int velikost;
            while (!int.TryParse(Console.ReadLine(), out velikost) || velikost < 0)
            {
                Console.WriteLine("Nezadal jste číslo, zadejte prosím celé číslo, nebo něco, ale spíš to číslo.");
            }

            Console.WriteLine("\nŠachovnice");
            for (int i = 0; i < velikost; i++)
            {
                for (int j = 0; j < velikost; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    Thread.Sleep(100);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a', jinak libovolnou jinou klávesu pro ukončení.");
            again = Console.ReadLine().ToLower();
        }
    }
}