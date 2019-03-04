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
    /// Logique d'interaction pour Retirer.xaml
    /// </summary>
    public partial class Retirer : Page
    {
        Administration admin;
        public Retirer(Administration admin)
        {
            this.admin = admin;
            InitializeComponent();
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
            Sortie.Text = "";
            foreach (Personnel elt in admin.ToutLePersonnel)
            {
                Sortie.Text = Sortie.Text + "\n" + "id : " + elt.Matricule + " " + elt.Nom + " " + elt.Prenom;
            }
        }

        public void AffichageAttraction()
        {
            Sortie.Text = "";
            foreach (Attraction elt in admin.Attractions)
            {
                Sortie.Text = Sortie.Text + "\n" + "id : " + elt.ObtenirIdentifiant() + " " + elt.Nom;
            }
        }

        private void Choix_DropDownClosed(object sender, EventArgs e)
        {
            string choix = (string)Choix.SelectionBoxItem;
            if (choix == "Attraction")
            {
                AffichageAttraction();
            }
            if (choix == "Personnel")
            {
                AffichagePersonnel();
            }
        }

        private void RetireAttraction(string id)
        {
            bool attractionTrouve = false;
            int i = 0;
            while ((i < admin.Attractions.Count) && (attractionTrouve == false))
            {
                if (admin.Attractions[i].ObtenirIdentifiant() == id)
                {
                    admin.Attractions.RemoveAt(i);
                    attractionTrouve = true;
                    MessageBox.Show("Attraction retirée.");
                }
                i++;
            }
            if (attractionTrouve == false)
            {
                MessageBox.Show("Attraction introuvable");
            }
        }

        private void RetirePersonnel(int id)
        {
            bool personnelTrouve = false;
            int i = 0;
            while ((i < admin.ToutLePersonnel.Count) && (personnelTrouve == false))
            {
                if (admin.ToutLePersonnel[i].Matricule == id)
                {
                    admin.ToutLePersonnel.RemoveAt(i);
                    personnelTrouve = true;
                    MessageBox.Show("Personnel retiré.");
                }
                i++;
            }
            if (personnelTrouve == false)
            {
                MessageBox.Show("Personnel introuvable");
            }
        }

        private void Confirmer(object sender, RoutedEventArgs e)
        {
            string choix = (string)Choix.SelectionBoxItem;
            if (choix == "Personnel")
            {
                int id = Convert.ToInt32(EntreeId.Text);
                RetirePersonnel(id);
                AffichagePersonnel();
            }
            if (choix == "Attraction")
            {
                string id = EntreeId.Text;
                RetireAttraction(id);
                AffichageAttraction();
            }
        }
    }
}
