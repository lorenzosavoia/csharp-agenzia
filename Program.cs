using System;

namespace csharp_agenzia // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box immobile1 = new Box(4 ,"123512", "santa margherita", "27011","belgioiso", 50);
            
            Console.WriteLine(immobile1.ToString());

            Agenzia az = new Agenzia("lorenzo");

            az.AddImmobile(immobile1);
            
        }
    }
}