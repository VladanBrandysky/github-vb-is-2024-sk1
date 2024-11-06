using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string again;

        do
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            // Zadání počtu generovaných čísel
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int numberOfValues;
            while (!int.TryParse(Console.ReadLine(), out numberOfValues) || numberOfValues <= 0)
            {
                Console.Write("Nezadali jste platné celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            // Zadání dolní meze
            Console.Write("Zadejte dolní mez (celé číslo): ");
            int minRange;
            while (!int.TryParse(Console.ReadLine(), out minRange))
            {
                Console.Write("Nezadali jste platné celé číslo. Zadejte dolní mez znovu: ");
            }

            // Zadání horní meze
            Console.Write("Zadejte horní mez (celé číslo): ");
            int maxRange;
            while (!int.TryParse(Console.ReadLine(), out maxRange) || maxRange < minRange)
            {
                Console.Write("Nezadali jste platné celé číslo nebo je menší než dolní mez. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine($"Počet čísel: {numberOfValues}; dolní mez: {minRange}; horní mez: {maxRange}");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // Generování pole náhodných čísel pomocí MyArray
            int[] numbers = MyArray(numberOfValues, minRange, maxRange);

            // Výpis vygenerovaných čísel
            Console.WriteLine("Vygenerovaná čísla:");
            Console.WriteLine(string.Join("; ", numbers));

            // Výpočet a výpis maximální hodnoty
            int max = numbers.Max();
            Console.WriteLine($"\nMaximální hodnota mezi čísly je: {max}");

            // Opakování programu
            Console.WriteLine("\nChcete vygenerovat další sadu čísel? Pokud ano, napište 'a'. Pro ukončení stiskněte libovolnou jinou klávesu.");
            again = Console.ReadLine();
        }
        while (again?.ToLower() == "a");
    }

    // Metoda MyArray generuje pole náhodných čísel
    static int[] MyArray(int size, int min, int max)
    {
        Random rand = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(min, max + 1); // +1 pro zahrnutí max do rozsahu
        }

        return array;
    }
}
