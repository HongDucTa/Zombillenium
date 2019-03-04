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
    /// Logique d'interaction pour Trier.xaml
    /// </summary>
    public partial class Trier : Page
    {
        Administration admin;
        public Trier(Administration admin)
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

        public void AfficherVampire()
        {
            Sortie.Text = "";
            foreach(Vampire elt in admin.EquipeVampire)
            {
                Sortie.Text = Sortie.Text + "\n" + elt.Matricule + " " + elt.Nom + " " + elt.Prenom + " Cagnotte : " + elt.GetCagnotte + " Indice luminosité : " + elt.ObtenirIndiceLuminosite();
            }
        }
        public void AfficherZombie()
        {
            Sortie.Text = "";
            foreach (Zombie elt in admin.EquipeZombie)
            {
                Sortie.Text = Sortie.Text + "\n" + elt.Matricule + " " + elt.Nom + " " + elt.Prenom + " Cagnotte : " + elt.GetCagnotte + " Degré décomposition : " + elt.ObtenirDegreDecomposition();
            }
        }
        public void AfficherLoupGarou()
        {
            Sortie.Text = "";
            foreach (LoupGarou elt in admin.EquipeLoupGarou)
            {
                Sortie.Text = Sortie.Text + "\n" + elt.Matricule + " " + elt.Nom + " " + elt.Prenom + " Cagnotte : " + elt.GetCagnotte + " Indice cruauté : " + elt.ObtenirIndiceCruaute();
            }
        }
        public void AfficherFantome()
        {
            Sortie.Text = "";
            foreach (Fantome elt in admin.EquipeFantome)
            {
                Sortie.Text = Sortie.Text + "\n" + elt.Matricule + " " + elt.Nom + " " + elt.Prenom + " Cagnotte : " + elt.GetCagnotte;
            }
        }
        public void AfficherDemon()
        {
            Sortie.Text = "";
            foreach (Demon elt in admin.EquipeDemon)
            {
                Sortie.Text = Sortie.Text + "\n" + elt.Matricule + " " + elt.Nom + " " + elt.Prenom + " Cagnotte : " + elt.GetCagnotte + " Force : " + elt.ObtenirForce();
            }
        }

        private void Choix_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem)Choix.SelectedItem;
            string choix = typeItem.Content.ToString();
            if (choix == "Vampire")
            {
                trie1.Content = "Cagnotte";
                trie2.IsEnabled = true;
                trie2.Content = "Indice luminosité";
                AfficherVampire();
            }
            if (choix == "Zombie")
            {
                trie1.Content = "Cagnotte";
                trie2.IsEnabled = true;
                trie2.Content = "Degré de décomposition";
                AfficherZombie();
            }
            if (choix == "Loup Garou")
            {
                trie1.Content = "Cagnotte";
                trie2.IsEnabled = true;
                trie2.Content = "Indice cruauté";
                AfficherLoupGarou();
            }
            if (choix == "Fantôme")
            {
                trie1.Content = "Cagnotte";
                trie2.Content = "";
                trie2.IsEnabled = false;
                AfficherFantome();
            }
            if (choix == "Démon")
            {
                trie1.Content = "Cagnotte";
                trie2.IsEnabled = true;
                trie2.Content = "Force";
                AfficherDemon();
            }
        }

        private void Confirmer(object sender, RoutedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem)Choix.SelectedItem;
            string choix = typeItem.Content.ToString();
            string critere = (string)Trie.SelectionBoxItem;
            if (choix == "Vampire")
            {
                if (critere == "Cagnotte")
                {
                    VampireSortByCagnotte ctr = new VampireSortByCagnotte();
                    admin.EquipeVampire.Sort(ctr);
                    AfficherVampire();
                }
                if (critere == "Indice luminosité")
                {
                    VampireSortByIndiceLuminosite ctr = new VampireSortByIndiceLuminosite();
                    admin.EquipeVampire.Sort(ctr);
                    AfficherVampire();
                }
            }
            if (choix == "Zombie")
            {
                if (critere == "Cagnotte")
                {
                    Zombie_SortByCagnotte ctr = new Zombie_SortByCagnotte();
                    admin.EquipeZombie.Sort(ctr);
                    AfficherZombie();
                }
                if (critere == "Degré de décomposition")
                {
                    ZombieSortByDegreDecomposition ctr = new ZombieSortByDegreDecomposition();
                    admin.EquipeZombie.Sort(ctr);
                    AfficherZombie();
                }
            }
            if (choix == "Loup Garou")
            {
                if (critere == "Cagnotte")
                {
                    LoupGarouSortByCagnotte ctr = new LoupGarouSortByCagnotte();
                    admin.EquipeLoupGarou.Sort(ctr);
                    AfficherLoupGarou();
                }
                if (critere == "Indice cruauté")
                {
                    LoupGarouSortByIndiceCruaute ctr = new LoupGarouSortByIndiceCruaute();
                    admin.EquipeLoupGarou.Sort(ctr);
                    AfficherLoupGarou();
                }
            }
            if (choix == "Fantôme")
            {
                if (critere == "Cagnotte")
                {
                    FantomeSortByCagnotte ctr = new FantomeSortByCagnotte();
                    admin.EquipeFantome.Sort(ctr);
                    AfficherFantome();
                }
            }
            if (choix == "Démon")
            {
                if (critere == "Cagnotte")
                {
                    DemonSortByCagnotte ctr = new DemonSortByCagnotte();
                    admin.EquipeDemon.Sort(ctr);
                    AfficherDemon();
                }
                if (critere == "Force")
                {
                    Demon_SortByForce ctr = new Demon_SortByForce();
                    admin.EquipeDemon.Sort(ctr);
                    AfficherDemon();
                }
            }
            MessageBox.Show("Tri effectué.");

        }
    }
}
