using System;

class Program
{
    static void Main()
    {
        // Požádáme uživatele o vstupní text
        Console.Write("Zadejte text: ");
        string input = Console.ReadLine();

        // Počítadla pro samohlásky, souhlásky a ostatní znaky
        int vowelCount = 0;
        int consonantCount = 0;
        int otherCount = 0;

        // Definice samohlásek
        string vowels = "aeiouyáéíóúýěáí";

        // Procházení každého znaku v textu
        foreach (char c in input)
        {
            // Zkontrolujeme, zda je znak písmenem
            if (char.IsLetter(c))
            {
                // Zkontrolujeme, zda je znak samohláska
                if (vowels.Contains(char.ToLower(c)))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
            // Pokud znak není písmeno, považujeme ho za "ostatní znak"
            else
            {
                otherCount++;
            }
        }

        // Výstup výsledků
        Console.WriteLine($"Počet samohlásek: {vowelCount}");
        Console.WriteLine($"Počet souhlásek: {consonantCount}");
        Console.WriteLine($"Počet ostatních znaků: {otherCount}");
    }
}
