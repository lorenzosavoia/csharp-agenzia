using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class Immobile
    {
        public string sCodice { get; set; }
        public string sIndirizzo { get; set; }
        public string sCap{ get; set; }
        public string sCitta { get; set; }
        public int iSupMq { get; set; }

        public Immobile(string sCodice, string sIndirizzo, string sCap, string sCitta, int iSupMq)
        {
            this.sCodice = sCodice;
            this.sIndirizzo = sIndirizzo;
            this.sCap = sCap;
            this.sCitta = sCitta;
            this.iSupMq = iSupMq;
        }
        public override string ToString()
        {
            return string.Format("Immobile:\n{0}", Write());
        }

        protected virtual string Write()
        {
            return string.Format("Codice: {0}\n Indirizzo: {1}\n Cap: {2}\n Cittá: {3}\n Superficie in mq: {4}",
                sCodice,
                sIndirizzo,
                sCap,
                sCitta,
                iSupMq);       
        }
        //una sorta di ricerca poco raffinata sfruttando i contains
        public virtual bool Contains(string key)
        {
            if (sCodice.Contains(key)) return true;
            else if (sIndirizzo.Contains(key)) return true;
            else if (sCap.Contains(key)) return true;
            else if (sCitta.Contains(key)) return true;
            else if (iSupMq.ToString().Contains(key)) return true;
            else return false;
        }


    }
}
