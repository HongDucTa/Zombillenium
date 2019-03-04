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
using System.IO;
using System.Windows.Forms;

namespace ProjetWPF
{
    /// <summary>
    /// Logique d'interaction pour MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Page
    {
        Administration admin;
        public MenuPrincipal()
        {
            this.admin = new Administration(new List<Attraction>(), new List<Personnel>(), new List<Spectacles>(), new List<Boutique>(), new List<DarkRide>(), new List<RollerCoaster>(), new List<Vampire>(), new List<Demon>(), new List<Fantome>(), new List<Zombie>(), new List<LoupGarou>(), new List<Sorcier>(), new List<Monstre>());
            InitializeComponent();
        }

        private void BoutonInformation_Click(object sender, RoutedEventArgs e)
        {
            Information pageInformation = new Information();
            this.NavigationService.Navigate(pageInformation);
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader fichier = new StreamReader(openFileDialog.OpenFile());
                System.Windows.MessageBox.Show("Ajout effectué !");
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
    }
}
