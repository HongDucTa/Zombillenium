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

namespace ProjetWPF
{
    /// <summary>
    /// Logique d'interaction pour ChangerAffectation.xaml
    /// </summary>
    public partial class ChangerAffectation : Page
    {
        Administration admin;
        public ChangerAffectation(Administration admin)
        {
            this.admin = admin;
            InitializeComponent();
            AffichagePersonnel();
            AffichageAttraction();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ajouter nav = new Ajouter(admin);
            this.NavigationService.Navigate(nav);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Trier navi = new Trier(admin);
            this.NavigationService.Navigate(navi);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Retirer nav = new Retirer(admin);
            this.NavigationService.Navigate(nav);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ChangerAffectation nav = new ChangerAffectation(admin);
            this.NavigationService.Navigate(nav);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ChangerCagnotte nav = new ChangerCagnotte(admin);
            this.NavigationService.Navigate(nav);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AccesListe nav = new AccesListe(admin);
            this.NavigationService.Navigate(nav);
        }

        public void AffichagePersonnel()
        {
            SortieMonstre.Text = "";
            foreach (Monstre elt in admin.EquipeMonstre)
            {
                SortieMonstre.Text = SortieMonstre.Text + "\n" + "id : " + elt.Matricule + " " + elt.Nom + " " + elt.Prenom + " Affectation : " + elt.Affectation.Nom;
            }
        }

        public void AffichageAttraction()
        {
            SortieAttraction.Text = "";
            foreach (Attraction elt in admin.Attractions)
            {
                SortieAttraction.Text = SortieAttraction.Text + "\n" + "id : " + elt.ObtenirIdentifiant() + " " + elt.Nom;
            }
        }

        private int IndexAttraction(string id)
        {
            int res = -1;
            bool attractionTrouve = false;
            int i = 0;
            while ((i < admin.Attractions.Count) && (attractionTrouve == false))
            {
                if (admin.Attractions[i].ObtenirIdentifiant() == id)
                {
                    attractionTrouve = true;
                    res = i;
                }
                i++;
            }
            return res;
        }

        private int IndexMonstre(int id)
        {
            int res = -1;
            bool monstreTrouve = false;
            int i = 0;
            while ((i < admin.EquipeMonstre.Count) && (monstreTrouve == false))
            {
                if (admin.EquipeMonstre[i].Matricule == id)
                {
                    monstreTrouve = true;
                    res = i;
                }
                i++;
            }
            return res;
        }

        private void Confirmer(object sender, RoutedEventArgs e)
        {
            int idMonstre = Convert.ToInt32(EntreePersonnel.Text);
            string idAttraction = EntreeAttraction.Text;
            int indexMonstre = IndexMonstre(idMonstre);
            int indexAttraction = IndexAttraction(idAttraction);
            if ((indexMonstre == -1) || (indexAttraction == -1))
            {
                MessageBox.Show("Monstre ou Attraction introuvable.");
            }
            else
            {
                admin.EquipeMonstre[indexMonstre].ChangerAffectation(admin.Attractions[indexAttraction]);
                MessageBox.Show("Changement d'affectation effectué.");
            }
            AffichageAttraction();
            AffichagePersonnel();
        }
    }
}
