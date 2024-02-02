using System;
using System.Collections.Generic;
namespace Uppgift_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namnLista = new List<string>();

            Console.WriteLine("Mata in så många namn du vill. Skriv en tom rad när du vill sluta");

            while (true) //Matar in namn i listan
            {
                string nyttNamn = Console.ReadLine();
                if (nyttNamn == "")
                {
                    break;
                }
                namnLista.Add(nyttNamn);
            }

            namnLista.Sort(); //Sorterar i alfabetisk ordning

            Console.WriteLine("\nHär kommer alla namn du skrev i omvänd bokstavsordning:");
            for (int i = 0; i < namnLista.Count; i++) //Skriver listan med det sista elementet först
            {
                Console.WriteLine(namnLista[namnLista.Count-1-i]);
            }


            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}