using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFishing
{
    public class Magazine
    {
        #region Champs
        private int _numMagazine;
        private string _dateBouclageMagazine;
        private string _dateParutionMagazine;
        private string _datePaiementMagazine;
        private int _budgetMagazine;
        #endregion


        #region Accesseur/Mutateur



        public int NumMagzine
        {
            get { return _numMagazine; }
            set { _numMagazine = value; }
        }

        

        public string DateBouclageMagazine
        {
            get { return _dateBouclageMagazine; }
            set { _dateBouclageMagazine = value; }
        }

        

        public string DateParutionMagazine
        {
            get { return _dateParutionMagazine; }
            set { _dateParutionMagazine = value; }
        }

        public string DatePaiementMagazine
        {
            get { return _datePaiementMagazine; }
            set { _datePaiementMagazine = value; }
        }
        
        public int BudgetMagazine
        {
            get { return _budgetMagazine; }
            set { _budgetMagazine = value; }
        }
        #endregion

        #region Constructeur

        public Magazine(int n, string db, string dp, string dpm, int b)
        {
            _numMagazine = n;
            _dateBouclageMagazine = db;
            _dateParutionMagazine = dp;
            _datePaiementMagazine = dpm;
            _budgetMagazine = b;
        }
        #endregion

        #region Methode

        public override string ToString()
        {
            return _numMagazine+ " "+_dateParutionMagazine;
        }
        #endregion
    }
}
