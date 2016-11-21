using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFishing
{
    public class ContratAgessa : Contrat
    {
        private bool _declarationAgessaContrat;

        public bool DeclarationAgessaContrat
        {
            get { return _declarationAgessaContrat; }
            set { _declarationAgessaContrat = value; }
        }


         #region Constructeur

        public ContratAgessa (int numcon, string lettacccon, double montbrutcon, double montnetcon, bool declagessacon, int etatcon, Pigiste pigcon, Magazine magcon, string datepaie) : base(numcon, lettacccon, montbrutcon, montnetcon, etatcon, pigcon, magcon, datepaie)
        {
           
            _declarationAgessaContrat = declagessacon;
            
        }
        #endregion
    }
}
