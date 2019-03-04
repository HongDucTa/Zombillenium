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

namespace ProjetWPF
{
    /// <summary>
    /// Logique d'interaction pour AccesListe.xaml
    /// </summary>
    public partial class AccesListe : Page
    {
        Administration admin;
        public AccesListe(Administration admin)
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

        private void BoutonConfirmer(object sender, RoutedEventArgs e)
        {
            Sortie.Text = "";
            string choix = (string)Choix.SelectionBoxItem;
            string filtre = (string)Filtre.SelectionBoxItem;
            StreamWriter fichier;
            if (CocheFichier.IsChecked == true)
            {
                string nomFichier = NomFichier.Text + ".csv";
                fichier = new StreamWriter(nomFichier, false);
            }
            else
            {
                fichier = new StreamWriter("temp.csv", false);
            }
            if (choix=="Vampire")
            {
                foreach(Vampire elt in admin.EquipeVampire)
                {
                    Sortie.Text = Sortie.Text + "\n" + elt.ToString();
                    if (CocheFichier.IsChecked == true)
                    {
                        fichier.WriteLine(elt.ToString());
                    }
                }
            }
            if (choix=="Attraction")
            {
                if (filtre=="En maintenance")
                {
                    foreach(Attraction elt in admin.Attractions)
                    {
                        if (elt.Maintenance == true)
                        {
                            Sortie.Text = Sortie.Text + "\n" + elt.ToString();
                            if (CocheFichier.IsChecked == true)
                            {
                                fichier.WriteLine(elt.ToString());
                            }
                        }
                    }
                }
                else
                {
                    foreach(Attraction elt in admin.Attractions)
                    {
                        Sortie.Text = Sortie.Text + "\n" + elt.ToString();
                        if (CocheFichier.IsChecked == true)
                        {
                            fichier.WriteLine(elt.ToString());
                        }
                    }
                }
            }
            fichier.Close();
        }

        private void CocheFichier_Click(object sender, RoutedEventArgs e)
        {
            if (CocheFichier.IsChecked == true)
            {
                EmplacementFichier.IsEnabled = true;
                EmplacementFichier.Visibility = Visibility.Visible;
            }
            else
            {
                EmplacementFichier.IsEnabled = false;
                EmplacementFichier.Visibility = Visibility.Hidden;
            }
        }

        private void Choix_DropDownClosed(object sender, EventArgs e)
        {
            string choix = (string)Choix.SelectionBoxItem;
            if (choix == "Attraction")
            {
                filtreMaintenance.Visibility = Visibility.Visible;
            }
            else
            {
                filtreMaintenance.Visibility = Visibility.Hidden;
                Filtre.SelectedIndex = 0;
            }
        }
    }
}
