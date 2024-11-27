using System;

class Program
{
    static void Main()


string again = "a";
        
        while(again == "a")    {  
     Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("******** intervaly ********");
            Console.WriteLine("****************************");
            Console.WriteLine("***** Vladan Brandýský *****");
            Console.WriteLine("****************************");
            Console.WriteLine();

        int n;
        Console.WriteLine("Zadejte počet iterací:");
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Zadejte platné kladné celé číslo pro počet iterací.");
            return;
        }
    
        double pi = 0.0;
        for (int k = 0; k < n; k++)
        {
            pi += Math.Pow(-1, k) / (2 * k + 1);
        }
        pi *= 4; // Výsledné přibližné π

        Console.WriteLine($"Aproximace čísla π po {n} iteracích je: {pi}");
    }
}