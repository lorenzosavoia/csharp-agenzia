using System;

namespace csharp_agenzia // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box immobile1 = new Box(4 ,"123512", "santa margherita", "27011","belgioiso", 50);
            
           // Console.WriteLine(immobile1.ToString());

            Agenzia az = new Agenzia("lorenzo");
            az.AddImmobile(immobile1);

            //ricerca ville
            Console.WriteLine("inserisci il codice dell'immobile per la ricerca:");
            string sSearch = Console.ReadLine();

            List<Immobile> immobileList = az.SearchImmobili(sSearch);
            foreach(Immobile i in immobileList)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine("----------------------------------------------------");
            }
            Console.WriteLine("ho finito");
            
        }
    }
}