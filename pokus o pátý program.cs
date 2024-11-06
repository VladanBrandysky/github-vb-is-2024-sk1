using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Počet čísel, která chcete vygenerovat
        int numberOfValues = 10;

        // Rozsah pro generátor náhodných čísel (např. mezi 5 a 10)
        int minRange = 5;
        int maxRange = 10;

        // Vytvoření generátoru náhodných čísel
        Random rand = new Random();

        // Vygenerování pole náhodných čísel
        int[] numbers = new int[numberOfValues];
        for (int i = 0; i < numberOfValues; i++)
        {
            numbers[i] = rand.Next(minRange, maxRange + 1); // +1 pro zahrnutí maxRange
        }

        // Najdeme maximální hodnotu
        int max = numbers.Max();

        // Výstup
        Console.WriteLine("Vygenerovaná čísla:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine($"Maximální hodnota mezi čísly je: {max}");
    }
}
