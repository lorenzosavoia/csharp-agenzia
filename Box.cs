using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    class Box : Immobile
    {
        public int iPostoAuto { get; set; }
       
        public Box(int iPostoAuto, string sCodice, string sIndirizzo, string sCap, string sCitta, int iSupMq) : base(sCodice, sIndirizzo, sCap, sCitta, iSupMq)
        {
            this.iPostoAuto = iPostoAuto;
        }
        public override string ToString()
        {
            return string.Format("Box:\n{0}",Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\n Posti auto:{1}",
                base.Write(),
                iPostoAuto);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (iPostoAuto.ToString().Contains(key)) return true;
            else return false;
        }

    }
}
