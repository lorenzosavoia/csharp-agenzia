using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class Agenzia
    {
        public string Nome { get; set; }
        //lista di immobili
        public List<Immobile> Immobili { get; set; }
        //costruttore agenzia
        public Agenzia(string Nome)
        {
            this.Nome = Nome;
            Immobili = new List<Immobile>();
        }
        public void AddImmobile(Immobile immobile)
        {
            Immobili.Add(immobile);
        }
        
        
        public List<Immobile> SearchImmobili(string key)
        {
            return Immobili.FindAll(i => i.Contains(key));
        }
        
    }
}
