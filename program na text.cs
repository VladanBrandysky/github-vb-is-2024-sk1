using System;

class Program
{
    static void Main()
    {
        // Požádáme uživatele o vstupní text
        Console.Write("Zadejte text: ");
        string input = Console.ReadLine();

        // Počítadla pro samohlásky, souhlásky a ostatní znaky
        int samohlásky = 0;
        int souhlásky = 0;
        int ostatní = 0;

        // Definice samohlásek
        string samo = "aeiouyáéíóúýěáí";

        // Procházení každého znaku v textu
        foreach (char c in input)
        {
            // Zkontrolujeme, zda je znak písmenem
            if (char.IsLetter(c))
            {
                // Zkontrolujeme, zda je znak samohláska
                if (samo.Contains(char.ToLower(c)))
                {
                    samohlásky++;
                }
                else
                {
                    souhlásky++;
                }
            }
            // Pokud znak není písmeno, považujeme ho za "ostatní znak"
            else
            {
                ostatní++;
            }
        }

        // Výstup výsledků
        Console.WriteLine($"Počet samohlásek: {samohlásky}");
        Console.WriteLine($"Počet souhlásek: {souhlásky}");
        Console.WriteLine($"Počet ostatních znaků: {ostatní}");
    }
}
