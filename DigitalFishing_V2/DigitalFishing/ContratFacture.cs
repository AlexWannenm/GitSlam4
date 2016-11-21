using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFishing
{
    public class ContratFacture : Contrat
    {
        private bool _factureContrat;

        public bool FactureContrat
        {
            get { return _factureContrat; }
            set { _factureContrat = value; }
        }

         #region Constructeur

        public ContratFacture (int numcon, string lettacccon, double montbrutcon, double montnetcon, bool factcon, int etatcon, Pigiste pigcon, Magazine magcon, string datepaie) : base(numcon, lettacccon, montbrutcon, montnetcon, etatcon, pigcon, magcon, datepaie)
        {

            _factureContrat = factcon;

        }
       
        #endregion
    }
}
