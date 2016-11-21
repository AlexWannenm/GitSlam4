namespace DigitalFishing
{
    public class Contrat
    {
        #region Champs

        private int _numContrat;
        private string _lettreAccordContrat;
        private double _montantBrutContrat;
        private double _montantNetContrat;
        private bool _declarationAgessaContrat;
        private bool _factureContrat;
        private int _etatContrat;
        private Pigiste _pigisteContrat;
        private Magazine _magazineContrat;
        private string _datePaiement;

        #endregion

        #region Accesseur/Mutateur

        public int NumContrat
        {
            get { return _numContrat; }
            set { _numContrat = value; }
        }

        public string LettreAccordContrat
        {
            get { return _lettreAccordContrat; }
            set { _lettreAccordContrat = value; }
        }

        public double MontantBrutContrat
        {
            get { return _montantBrutContrat; }
            set { _montantBrutContrat = value; }
        }

        public double MontantNetContrat
        {
            get { return _montantNetContrat; }
            set { _montantNetContrat = value; }
        }

        public bool DeclarationAgessaContrat
        {
            get { return _declarationAgessaContrat; }
            set { _declarationAgessaContrat = value; }
        }

        public bool FactureContrat
        {
            get { return _factureContrat; }
            set { _factureContrat = value; }
        }

        public int EtatContrat
        {
            get { return _etatContrat; }
            set { _etatContrat = value; }
        }

        public Pigiste PigisteContrat
        {
            get { return _pigisteContrat; }
            set { _pigisteContrat = value; }
        }

        public Magazine MagazineContrat
        {
            get { return _magazineContrat; }
            set { _magazineContrat = value; }
        }

        public string DatePaiment
        {
            get { return _datePaiement; }
            set { _datePaiement = value; }
        }
        #endregion

        #region Constructeur

        public Contrat(int numcon, string lettacccon, double montbrutcon, double montnetcon, int etatcon, Pigiste pigcon, Magazine magcon, string datepaie)
        {
            _numContrat = numcon;
            _lettreAccordContrat = lettacccon;
            _montantBrutContrat = montbrutcon;
            _montantNetContrat = montnetcon;
            _etatContrat = etatcon;
            _pigisteContrat = pigcon;
            _magazineContrat = magcon;
            _datePaiement = datepaie;
        }
       
        #endregion
    }
}
