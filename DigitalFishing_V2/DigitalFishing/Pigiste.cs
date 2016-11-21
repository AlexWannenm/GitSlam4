using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFishing
{
   public class Pigiste
   {
       #region Champs
       private int _numPigiste;
       private string _nomPigiste;
       private string _prenomPigiste;
       private string _adressePigiste;
       private string _villePigiste;
       private string _mailPigiste;
       private string _cpPigiste;
       private string _numSecuPigiste;
       private string _contratCadrePigiste;
       #endregion

       #region Accesseur/Mutateur

       public int NumPigiste
       {
           get { return _numPigiste; }
           set { _numPigiste = value; }
       }



       public string NomPigiste
       {
           get { return _nomPigiste; }
           set { _nomPigiste = value; }
       }



       public string PrenomPigiste
       {
           get { return _prenomPigiste; }
           set { _prenomPigiste = value; }
       }


       public string AdressePigiste
       {
           get { return _adressePigiste; }
           set { _adressePigiste = value; }
       }

       public string VillePigiste
       {
           get { return _villePigiste; }
           set { _villePigiste = value; }
       }

       public string EmailPigiste
       {
           get { return _mailPigiste; }
           set { _mailPigiste = value; }
       }

       public string CpPigiste
       {
           get { return _cpPigiste; }
           set { _cpPigiste = value; }
       }

       public string NumSecuPigiste
       {
           get { return _numSecuPigiste; }
           set { _numSecuPigiste = value; }
       }

       public string ContratCadrePigiste
       {
           get { return _contratCadrePigiste; }
           set { _contratCadrePigiste = value; }
       }
       #endregion

       #region Constructeur

       public Pigiste(int num, string nomp, string prenp, string adr, string codep, string ville, string email, string numsecu, string ccp)
       {
            _numPigiste = num;
            _nomPigiste = nomp;
            _prenomPigiste = prenp;
            _adressePigiste = adr;
            _villePigiste = ville;
            _mailPigiste = email;
            _cpPigiste = codep;
            _numSecuPigiste = numsecu;
            _contratCadrePigiste = ccp;
       }
       #endregion

       #region Methode

       public override string ToString()
       {
           return _nomPigiste +" "+_prenomPigiste;
       }
       #endregion
   }
}
