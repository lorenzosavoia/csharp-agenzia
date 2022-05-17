using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class Villa : Appartamento
    {
        public int iGiardino { get; set; }
        public Villa(int iGiardino, int iNumeroVani, int iNumeroBagni, string sCodice, string sIndirizzo, string sCap, string sCitta, int iSupMq) : base(iNumeroVani, iNumeroBagni, sCodice, sIndirizzo, sCap, sCitta, iSupMq)
        {
            this.iGiardino = iGiardino;
        }
        public override string ToString()
        {
            return string.Format("Villa:\n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\n Giardino:{1} mq",
                base.Write(),
                iGiardino);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (iGiardino.ToString().Contains(key)) return true;
            else return false;
        }


    }
}
