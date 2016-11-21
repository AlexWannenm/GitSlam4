using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DigitalFishing
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Magazine> cMagazine = new List<Magazine>();
        List<Pigiste> cPigiste = new List<Pigiste>();
        List<Contrat> cContrat = new List<Contrat>();
        string La;

        public MainWindow()
        {
            InitializeComponent();
            bdd.Initialize();

            cMagazine = bdd.SelectMagazine();
            dtgMagazine.DataContext = cMagazine;

            cPigiste = bdd.SelectPigiste();
            dtgPigiste.DataContext = cPigiste;

            cContrat = bdd.SelectContrat();
            dtgContrat.DataContext = cContrat;

            dtgMagazine.ItemsSource = cMagazine;
            dtgPigiste.ItemsSource = cPigiste;
            dtgContrat.ItemsSource = cContrat;
            cboPigiste.ItemsSource = cPigiste;
            cboMagazine.ItemsSource = cMagazine;

           

        }

        #region Magazine

        #region Ajouter Magazine
        private void btnAjouterMagazine_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                Magazine unMagazine = new Magazine(cMagazine.Count + 1, dtpBouclageMagazine.Text, dtpParutionMagazine.Text,dtpPaiementMagazine.Text, Convert.ToInt32(txtBudgetMagazine.Text));
                cMagazine.Add(unMagazine);

                cMagazine.Clear();
                cMagazine = bdd.SelectMagazine();
                dtgMagazine.ItemsSource = cMagazine;

            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de saisi");
            }

        }
        #endregion

        #region Supprimer Magazine
        private void btnSupprimerMagazine_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Magazine SupprMag = dtgMagazine.SelectedItem as Magazine;
                cMagazine.Remove(SupprMag);

                cMagazine.Clear();
                cMagazine = bdd.SelectMagazine();
                dtgMagazine.ItemsSource = cMagazine;
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur dans la suppréssion");
            }
        }
        #endregion

        #region Modifier Magazine
        private void btnModifierMagazine_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                 int index;
            index = dtgMagazine.SelectedIndex;

            cMagazine[index].BudgetMagazine = Convert.ToInt32(txtBudgetMagazine.Text);
            cMagazine[index].DateBouclageMagazine = dtpBouclageMagazine.Text;
            cMagazine[index].DateParutionMagazine = dtpParutionMagazine.Text;
            cMagazine[index].DatePaiementMagazine = dtpPaiementMagazine.Text;

            cMagazine.Clear();
            cMagazine = bdd.SelectMagazine();
            dtgMagazine.ItemsSource = cMagazine;
            }
            catch (Exception)
            {
                
            }
        }
        #endregion

        #region Selection Magazine
        private void dtgMagazine_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
            if (dtgMagazine.SelectedIndex == -1)
            {
                dtgMagazine.SelectedIndex = 0; 
            }


            Magazine selectedMagzine = dtgMagazine.SelectedItem as Magazine;

            txtBudgetMagazine.Text = Convert.ToString(selectedMagzine.BudgetMagazine);
            txtNumMagazine.Text = Convert.ToString(selectedMagzine.NumMagzine);
            dtpBouclageMagazine.Text = Convert.ToString(selectedMagzine.DateBouclageMagazine);
            dtpParutionMagazine.Text = Convert.ToString(selectedMagzine.DateParutionMagazine);
            dtpPaiementMagazine.Text = Convert.ToString(selectedMagzine.DatePaiementMagazine);

        }
        #endregion

        #endregion

        #region Contrat

        #region Ajout Contrat
        private void btnAjouterContrat_Click(object sender, RoutedEventArgs e)
        { Pigiste LePigiste = cboPigiste.SelectedItem as Pigiste;
            if (txtLettreAccordContrat.Text == "")
            {
                La = "la-";
                La = La + Convert.ToString(txtNumContrat.Text) +"-"+ LePigiste.NumPigiste;
                Contrat unContrat = new Contrat
                (
                cContrat.Count + 1,
                La,
                Convert.ToDouble(txtMontantBrutContrat.Text),
                Convert.ToDouble(txtMontantNetContrat.Text),
                Convert.ToBoolean(chkAgessa.IsChecked),
                Convert.ToBoolean(chkFacture.IsChecked),
                cboEtatContrat.SelectedIndex,
                (Pigiste)cboPigiste.SelectedItem,
                (Magazine)cboMagazine.SelectedItem,
                dtpPaiment.Text
                );
                bdd.InsertContrat(La,
                    Convert.ToDouble(txtMontantBrutContrat.Text),
                    Convert.ToDouble(txtMontantNetContrat.Text),
                    cboEtatContrat.SelectedIndex,
                    Convert.ToBoolean(chkFacture.IsChecked),
                    Convert.ToBoolean(chkAgessa.IsChecked),
                    (Pigiste)cboPigiste.SelectedItem,
                    (Magazine)cboMagazine.SelectedItem);
                cContrat.Add(unContrat);
                cContrat.Clear();
                cContrat = bdd.SelectContrat();
                dtgContrat.ItemsSource = cContrat;
               
            }
            else
            {
                Contrat unContrat = new Contrat
                (
                cContrat.Count + 1,
                txtLettreAccordContrat.Text,
                Convert.ToDouble(txtMontantBrutContrat.Text),
                Convert.ToDouble(txtMontantNetContrat.Text),
                Convert.ToBoolean(chkAgessa.IsChecked),
                Convert.ToBoolean(chkFacture.IsChecked),
                cboEtatContrat.SelectedIndex,
                (Pigiste)cboPigiste.SelectedItem,
                (Magazine)cboMagazine.SelectedItem,
                dtpPaiment.Text
                );
                bdd.InsertContrat(La,
                   Convert.ToDouble(txtMontantBrutContrat.Text),
                   Convert.ToDouble(txtMontantNetContrat.Text),
                   cboEtatContrat.SelectedIndex,
                   Convert.ToBoolean(chkFacture.IsChecked),
                   Convert.ToBoolean(chkAgessa.IsChecked),
                   (Pigiste)cboPigiste.SelectedItem,
                   (Magazine)cboMagazine.SelectedItem);
                cContrat.Add(unContrat);
                cContrat.Clear();
                cContrat = bdd.SelectContrat();
                dtgContrat.ItemsSource = cContrat;
            }
        }
        #endregion

        #region Modifier Contrat
        private void btnModifierContrat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index;
                bool facture;
                bool decla;

                index = dtgContrat.SelectedIndex;

                if (chkFacture.IsChecked == true)
                {
                    facture = true;
                }
                else
                {
                    facture = false;
                }

                if(chkAgessa.IsChecked == true)
                {
                    decla = true;
                }
                else
                {
                    decla = false;
                }

              /*  cContrat[index].NumContrat = Convert.ToInt32(txtNumContrat.Text);
                cContrat[index].DatePaiment = dtpPaiment.Text;
                cContrat[index].MontantBrutContrat = Convert.ToInt32(txtMontantBrutContrat.Text);
                cContrat[index].MontantNetContrat = Convert.ToInt32(txtMontantNetContrat.Text);
                cContrat[index].PigisteContrat = cboPigiste.SelectedValue;
                cContrat[index].MagazineContrat = cboMagazine.Text;
                cContrat[index].LettreAccordContrat = txtLettreAccordContrat.Text;
                cContrat[index].EtatContrat = cboEtatContrat.SelectedIndex;
                cContrat[index].FactureContrat = facture;
                cContrat[index].DeclarationAgessaContrat = decla;*/

                bdd.UpdateContrat(Convert.ToInt32(txtNumContrat.Text),
                    txtLettreAccordContrat.Text,
                    Convert.ToInt32(txtMontantBrutContrat.Text),
                    Convert.ToInt32(txtMontantNetContrat.Text),
                    Convert.ToInt32(cboEtatContrat.SelectedValue),
                    facture,
                    decla,
                    cboPigiste.SelectedIndex,
                    Convert.ToInt32(cboMagazine.SelectedValue));
                cContrat.Clear();
                cContrat = bdd.SelectContrat();
                dtgContrat.ItemsSource = cContrat;
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Supprimer Contrat
        private void btnSupprimerContrat_Click(object sender, RoutedEventArgs e)
        {
            Contrat SupprCont = dtgContrat.SelectedItem as Contrat;
            cContrat.Remove(SupprCont);

            cContrat.Clear();
            cContrat = bdd.SelectContrat();
            dtgContrat.ItemsSource = cContrat;
        }

        #endregion

        #region Selection Contrat
        private void dtgContrat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgContrat.SelectedIndex == -1)
            {
                dtgContrat.SelectedIndex = 0;
            }
            Contrat selectedContrat = dtgContrat.SelectedItem as Contrat;
            txtNumContrat.Text = Convert.ToString(selectedContrat.NumContrat);
            txtLettreAccordContrat.Text = Convert.ToString(selectedContrat.LettreAccordContrat);
            txtMontantBrutContrat.Text = Convert.ToString(selectedContrat.MontantBrutContrat);
            txtMontantNetContrat.Text = Convert.ToString(selectedContrat.MontantNetContrat);
            chkFacture.IsChecked = Convert.ToBoolean(selectedContrat.FactureContrat);
            chkAgessa.IsChecked = Convert.ToBoolean(selectedContrat.DeclarationAgessaContrat);
            cboEtatContrat.SelectedIndex = Convert.ToInt32(selectedContrat.EtatContrat);
            cboPigiste.SelectedItem = selectedContrat.PigisteContrat;
            cboMagazine.SelectedItem = selectedContrat.MagazineContrat;
            dtpPaiment.Text = Convert.ToString(selectedContrat.DatePaiment);
        }
        #endregion

        #region Calcul Montant net
        private void txtMontantBrutContrat_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                txtMontantNetContrat.Text = Convert.ToString(Convert.ToDouble(txtMontantBrutContrat.Text) * 0.9);
            }
            catch (Exception)
            {
                txtMontantNetContrat.Text = " ";
                Console.WriteLine("Erreur sur calcul txtMontantNet");
            }

        }
        #endregion

        #endregion

        #region Pigiste

        #region Ajouter Pigiste
        private void btnAjouterPigiste_Click(object sender, RoutedEventArgs e)
        {
            Pigiste unPigiste = new Pigiste(cPigiste.Count + 1, txtNomPigiste.Text, txtPrenomPigiste.Text, txtAdressePigiste.Text, txtCPPigiste.Text, txtVillePigiste.Text,txtEmail.Text, txtNumSecuPigiste.Text, txtContratCadre.Text);
            cPigiste.Add(unPigiste);

            cPigiste.Clear();
            cPigiste = bdd.SelectPigiste();
            dtgPigiste.ItemsSource = cPigiste;
        }
        #endregion

        #region Supprimer Pigiste
        private void btnSupprimerPigiste_Click(object sender, RoutedEventArgs e)
        {
            Pigiste SupprPigiste = dtgPigiste.SelectedItem as Pigiste;
            cPigiste.Remove(SupprPigiste);

            cPigiste.Clear();
            cPigiste = bdd.SelectPigiste();
            dtgPigiste.ItemsSource = cPigiste;
        }
        #endregion

        #region Modifier Pigiste
        private void btnModifierPigiste_Click(object sender, RoutedEventArgs e)
        {
            int index;
            index = dtgPigiste.SelectedIndex;

            cPigiste[index].NomPigiste = txtNomPigiste.Text;
            cPigiste[index].PrenomPigiste = txtPrenomPigiste.Text;
            cPigiste[index].AdressePigiste = txtAdressePigiste.Text;
            cPigiste[index].CpPigiste = txtCPPigiste.Text;
            cPigiste[index].VillePigiste = txtVillePigiste.Text;
            cPigiste[index].NumSecuPigiste = txtNumSecuPigiste.Text;

            cPigiste.Clear();
            cPigiste = bdd.SelectPigiste();
            dtgPigiste.ItemsSource = cPigiste;
        }

        #endregion

        #region Selection Pigiste
        private void dtgPigiste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (dtgPigiste.SelectedIndex == -1)
            {
                dtgPigiste.SelectedIndex = 0;
            }


            Pigiste selectedPigiste = dtgPigiste.SelectedItem as Pigiste;

            txtNumPigiste.Text = Convert.ToString(selectedPigiste.NumPigiste);
            txtNomPigiste.Text = Convert.ToString(selectedPigiste.NomPigiste);
            txtPrenomPigiste.Text = Convert.ToString(selectedPigiste.PrenomPigiste);
            txtAdressePigiste.Text = Convert.ToString(selectedPigiste.AdressePigiste);
            txtCPPigiste.Text = Convert.ToString(selectedPigiste.CpPigiste);
            txtVillePigiste.Text = Convert.ToString(selectedPigiste.VillePigiste);
            txtNumSecuPigiste.Text = Convert.ToString(selectedPigiste.NumSecuPigiste);

        }

        #endregion

        #endregion





    }
}