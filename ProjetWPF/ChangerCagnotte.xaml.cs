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
    /// Logique d'interaction pour ChangerCagnotte.xaml
    /// </summary>
    public partial class ChangerCagnotte : Page
    {
        Administration admin;
        public ChangerCagnotte(Administration admin)
        {
            this.admin = admin;
            InitializeComponent();
            AffichagePersonnel();
        }
        public void AffichagePersonnel()
        {
            Sortie.Text = "";
            foreach (Monstre elt in admin.EquipeMonstre)
            {
                Sortie.Text = Sortie.Text + "\n" + "id : " + elt.Matricule + " " + elt.Nom + " " + elt.Prenom + " Cagnotte : " + elt.GetCagnotte;
            }
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

        private void Confirmer(object sender, RoutedEventArgs e)
        {
            int mat = Convert.ToInt32(EntreeId.Text);
            int ptCagnotte = Convert.ToInt32(EntreeCagnotte.Text);
            bool personnelTrouve = false;
            int i = 0;
            while ((i < admin.EquipeMonstre.Count) && (personnelTrouve == false))
            {
                if (mat == admin.EquipeMonstre[i].Matricule)
                {
                    personnelTrouve = true;
                    admin.EquipeMonstre[i].ChangerCagnotte(ptCagnotte);
                    MessageBox.Show("Mofification effectuée. Nouvelle cagnotte : " + admin.EquipeMonstre[i].GetCagnotte);
                }
                i++;
            }
            if (personnelTrouve == false)
            {
                MessageBox.Show("Personnel non trouvé. Veuillez vérifier que l'Id existe.");
            }
            AffichagePersonnel();
        }
    }
}
