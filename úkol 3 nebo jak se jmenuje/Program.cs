using System;
using System.Threading.Tasks.Dataflow;

class Obrazce{
    static void Main(){
        
        string again = "a";
        while(again == "a"){

        Console.WriteLine("Zadejte číslo, nebo něco, to je jedno.");
        int velikost;
        while (!int.TryParse(Console.ReadLine(),out velikost)){
            Console.WriteLine("Nezadal jste číslo, zadejte prosím číslo, nebo něco, ale spíš to číslo.");
        }
        if (velikost < 0){
            Console.WriteLine ("Zadejte kladné číslo.");
            goto opakovani;
        }
        Console.WriteLine("\nŠachovnice");
        for (int i = 0; i < velikost; i++){
            for(int j = 0; j < velikost; j++){
                if ((i+j)%2==0 ){
                    Console.Write ("* ");
                } else Console.Write (" ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }
            Console.WriteLine();
        }  

        opakovani:
            Console.WriteLine("Pro opakovani programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}