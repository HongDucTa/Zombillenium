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
    /// Logique d'interaction pour AjoutManuel.xaml
    /// </summary>
    public partial class AjoutManuel : Page
    {
        Administration admin;
        public AjoutManuel(Administration admin)
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

        private void Choix_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem) Choix.SelectedItem;
            string choix = typeItem.Content.ToString();
            if (choix == "Sorcier")
            {
                Emplacement1.Text = "Matricule";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Prénom";
                Emplacement8.Text = "Sexe";
                Emplacement4.Text = "Fonction";
                Emplacement9.Text = "Grade";
                Emplacement5.Text = "Liste pouvoirs";
                Texte6.IsEnabled = false;
                Texte7.IsEnabled = false;
                Texte5.IsEnabled = true;
                Liste8.IsEnabled = true;
                Liste9.IsEnabled = true;
                Emplacement6.Text = "";
                Emplacement7.Text = "";
                element1.Content = "male";
                element2.Content = "femelle";
                element3.IsEnabled = true;
                element3.Content = "autre";
                elt3.IsEnabled = true;
                elt4.IsEnabled = true;
                elt1.Content = "novice";
                elt2.Content = "mega";
                elt3.Content = "giga";
                elt4.Content = "strata";
            }
            if (choix == "Monstre")
            {
                Emplacement1.Text = "Matricule";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Prénom";
                Emplacement8.Text = "Sexe";
                Emplacement4.Text = "Fonction";
                Emplacement5.Text = "Cagnotte";
                Emplacement6.Text = "Affectation";
                Texte7.IsEnabled = false;
                Liste9.IsEnabled = false;
                Texte5.IsEnabled = true;
                Texte6.IsEnabled = true;
                Liste8.IsEnabled = true;
                Emplacement6.Text = "";
                Emplacement9.Text = "";
                element1.Content = "male";
                element2.Content = "femelle";
                element3.IsEnabled = true;
                element3.Content = "autre";

            }
            if (choix == "Démon")
            {
                Emplacement1.Text = "Matricule";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Prénom";
                Emplacement8.Text = "Sexe";
                Emplacement4.Text = "Fonction";
                Emplacement5.Text = "Cagnotte";
                Emplacement6.Text = "";
                Emplacement7.Text = "Force";
                Liste9.IsEnabled = false;
                Texte5.IsEnabled = true;
                Texte6.IsEnabled = false;
                Texte7.IsEnabled = true;
                Liste8.IsEnabled = true;
                Emplacement9.Text = "";
                element1.Content = "male";
                element2.Content = "femelle";
                element3.IsEnabled = true;
                element3.Content = "autre";
            }
            if (choix == "Fantôme")
            {
                Emplacement1.Text = "Matricule";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Prénom";
                Emplacement8.Text = "Sexe";
                Emplacement4.Text = "Fonction";
                Emplacement5.Text = "Cagnotte";
                Emplacement6.Text = "";
                Texte7.IsEnabled = false;
                Liste9.IsEnabled = false;
                Texte5.IsEnabled = true;
                Texte6.IsEnabled = false;
                Liste8.IsEnabled = true;
                Emplacement7.Text = "";
                Emplacement9.Text = "";
                element1.Content = "male";
                element2.Content = "femelle";
                element3.IsEnabled = true;
                element3.Content = "autre";

            }
            if (choix == "Loup Garou")
            {
                Emplacement1.Text = "Matricule";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Prénom";
                Emplacement8.Text = "Sexe";
                Emplacement4.Text = "Fonction";
                Emplacement5.Text = "Cagnotte";
                Emplacement6.Text = "";
                Emplacement7.Text = "Indice Cruauté";
                Liste9.IsEnabled = false;
                Texte5.IsEnabled = true;
                Texte6.IsEnabled = false;
                Texte7.IsEnabled = true;
                Liste8.IsEnabled = true;
                Emplacement9.Text = "";
                element1.Content = "male";
                element2.Content = "femelle";
                element3.IsEnabled = true;
                element3.Content = "autre";
            }
            if (choix == "Vampire")
            {
                Emplacement1.Text = "Matricule";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Prénom";
                Emplacement8.Text = "Sexe";
                Emplacement4.Text = "Fonction";
                Emplacement5.Text = "Cagnotte";
                Emplacement6.Text = "Affectation";
                Emplacement7.Text = "Indice Luminosité";
                Liste9.IsEnabled = false;
                Texte5.IsEnabled = true;
                Texte6.IsEnabled = true;
                Texte7.IsEnabled = true;
                Liste8.IsEnabled = true;
                Emplacement9.Text = "";
                element1.Content = "male";
                element2.Content = "femelle";
                element3.IsEnabled = true;
                element3.Content = "autre";
            }
            if (choix == "Zombie")
            {
                Emplacement1.Text = "Matricule";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Prénom";
                Emplacement8.Text = "Sexe";
                Emplacement4.Text = "Fonction";
                Emplacement5.Text = "Cagnotte";
                Emplacement6.Text = "Affectation";
                Emplacement9.Text = "Teint";
                Emplacement7.Text = "Degré Décomposition";
                Texte5.IsEnabled = true;
                Texte6.IsEnabled = true;
                Texte7.IsEnabled = true;
                Liste8.IsEnabled = true;
                Liste9.IsEnabled = true;
                element1.Content = "male";
                element2.Content = "femelle";
                element3.IsEnabled = true;
                element3.Content = "autre";
                elt1.Content = "bleuatre";
                elt2.Content = "grisatre";
                elt3.Content = "";
                elt4.Content = "";
                elt3.IsEnabled = false;
                elt4.IsEnabled = false;
               


            }
            if (choix == "Boutique")
            {
                Emplacement1.Text = "Identifiant";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Nombre min monstre";
                Emplacement8.Text = "Besoin spécifique"; // oui ou non
                Emplacement4.Text = "Type de besoin";
                Emplacement9.Text = "Type Boutique";
                Texte5.IsEnabled = false;
                Texte6.IsEnabled = false;
                Texte7.IsEnabled = false;
                Liste8.IsEnabled = true;
                Liste9.IsEnabled = true;
                Emplacement5.Text = "";
                Emplacement6.Text = "";
                Emplacement7.Text = "";
                element1.Content = "Oui";
                element2.Content = "Non";
                element3.Content = "";
                element3.IsEnabled = false;

                elt1.Content = "Souvenir";
                elt2.Content = "Barbe à papa";
                elt3.IsEnabled = true;
                elt3.Content = "Nourriture";
                elt4.IsEnabled = false;
                elt4.Content = "";
            }
            if (choix == "DarkRide")
            {
                Emplacement1.Text = "Identifiant";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Nombre min monstre";
                Emplacement8.Text = "Besoin spécifique";
                Emplacement4.Text = "Type de besoin";
                Emplacement5.Text = "Durée";
                Emplacement9.Text = "Véhicule";
                Texte5.IsEnabled = true;
                Texte6.IsEnabled = false;
                Texte7.IsEnabled = false;
                Liste8.IsEnabled = true;
                Liste9.IsEnabled = true;
                Emplacement6.Text = "";
                Emplacement7.Text = "";
                element1.Content = "Oui";
                element2.Content = "Non";
                element3.Content = "";
                element3.IsEnabled = false;
                elt1.Content = "Oui";
                elt2.Content = "Non";
                elt3.Content = "";
                elt4.Content = "";
                elt3.IsEnabled = false;
                elt4.IsEnabled = false;
            }
            if (choix == "RollerCoaster")
            {
                Emplacement1.Text = "Identifiant";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Nombre min monstre";
                Emplacement8.Text = "Besoin spécifique";
                Emplacement4.Text = "Type de besoin";
                Emplacement9.Text = "Type Catégorie";
                Emplacement5.Text = "Age minimum";
                Emplacement6.Text = "Taille minimum";
                Texte7.IsEnabled = false;
                Liste8.IsEnabled = true;
                Liste9.IsEnabled = true;
                Texte6.IsEnabled = true;
                Texte5.IsEnabled = true;
                Emplacement7.Text = "";
                element1.Content = "Oui";
                element2.Content = "Non";
                element3.Content = "";
                element3.IsEnabled = false;
                elt1.Content = "Assise";
                elt2.Content = "Inversée";
                elt3.IsEnabled = true;
                elt3.Content = "Bobsleigh";
                elt4.Content = "";
                elt4.IsEnabled = false;

            }
            if (choix == "Spectacle")
            {
                Emplacement1.Text = "Identifiant";
                Emplacement2.Text = "Nom";
                Emplacement3.Text = "Nombre min monstre";
                Emplacement8.Text = "Besoin spécifique";
                Emplacement4.Text = "Type de besoin";
                Emplacement5.Text = "Nom salle";
                Emplacement6.Text = "Nombre de places";
                Emplacement7.Text = "Liste des horaires";
                Liste9.IsEnabled = false;
                Liste8.IsEnabled = true;
                Texte6.IsEnabled = true;
                Texte5.IsEnabled = true;
                Texte7.IsEnabled = true;
                Emplacement9.Text = "";
                element1.Content = "Oui";
                element2.Content = "Non";
                element3.Content = "";
                element3.IsEnabled = false;




            }
        }

        public typesexe RecupererSexe(string selection)
        {
            typesexe sexe = typesexe.autre;
            switch (selection)
            {
                case ("male"):
                    {
                        sexe = typesexe.male;
                        break;
                    }
                case ("femelle"):
                    {
                        sexe = typesexe.femelle;
                        break;
                    }
            }
            return sexe;
        }

        public bool RecupererBool(string selection)
        {
            bool res = false;
            if (selection == "Oui")
            {
                res = true;
            }
            return res;
        }

        private void BoutonConfirme_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem)Choix.SelectedItem;
            string choix = typeItem.Content.ToString();
            if (choix == "Sorcier")
            {
                int mat = Convert.ToInt32(Texte1.Text);
                string nom = Texte2.Text;
                string prenom = Texte3.Text;
                string fonction = Texte4.Text;
                List<string> listePouvoirs = new List<string>();
                string temp = "";
                foreach (char elt in Texte5.Text)
                {
                    if (elt != '-')
                    {

                        temp = temp + elt;
                    }
                    else
                    {
                        listePouvoirs.Add(temp);
                        temp = "";
                    }
                }
                listePouvoirs.Add(temp);
                string sexeSelection = (string)Liste8.SelectionBoxItem;
                typesexe sexe = RecupererSexe(sexeSelection);
                string gradeSelection = (string)Liste9.SelectionBoxItem;
                Grade grade = Grade.novice;
                switch(gradeSelection)
                {
                    case ("Strata"):
                        {
                            grade = Grade.strata;
                            break;
                        }
                    case ("Mega"):
                        {
                            grade = Grade.mega;
                            break;
                        }
                    case ("Giga"):
                        {
                            grade = Grade.giga;
                            break;
                        }
                }
                Sorcier sorcier = new Sorcier(listePouvoirs, grade, fonction, mat, nom, prenom, sexe);
                admin.AjouterSorcier(sorcier);
                MessageBox.Show("Sorcier ajouté.");
            }
            if (choix == "Monstre")
            {
                int mat = Convert.ToInt32(Texte1.Text);
                string nom = Texte2.Text;
                string prenom = Texte3.Text;
                string fonction = Texte4.Text;
                int cagnotte = Convert.ToInt32(Texte5.Text);
                Attraction attraction = new Attraction();
                typesexe sexe = RecupererSexe((string)Liste8.SelectionBoxItem);
                Monstre monstre = new Monstre(attraction, cagnotte, fonction, mat, nom, prenom, sexe);
                admin.AjouterMonstre(monstre);
                MessageBox.Show("Monstre ajouté.");
            }
            if (choix == "Démon")
            {
                int mat = Convert.ToInt32(Texte1.Text);
                string nom = Texte2.Text;
                string prenom = Texte3.Text;
                string fonction = Texte4.Text;
                int cagnotte = Convert.ToInt32(Texte5.Text);
                int force = Convert.ToInt32(Texte7.Text);
                Attraction attraction = new Attraction();
                typesexe sexe = RecupererSexe((string)Liste8.SelectionBoxItem);
                Demon demon = new Demon(force, attraction, cagnotte, fonction, mat, nom, prenom, sexe);
                admin.AjouterDemon(demon);
                MessageBox.Show("Démon ajouté.");
            }
            if (choix == "Fantôme")
            {
                int mat = Convert.ToInt32(Texte1.Text);
                string nom = Texte2.Text;
                string prenom = Texte3.Text;
                string fonction = Texte4.Text;
                int cagnotte = Convert.ToInt32(Texte5.Text);
                Attraction attraction = new Attraction();
                typesexe sexe = RecupererSexe((string)Liste8.SelectionBoxItem);
                Fantome fantome = new Fantome(attraction, cagnotte, fonction, mat, nom, prenom, sexe);
                admin.AjouterFantome(fantome);
                MessageBox.Show("Fantôme ajouté");
            }
            if (choix == "Loup Garou")
            {
                int mat = Convert.ToInt32(Texte1.Text);
                string nom = Texte2.Text;
                string prenom = Texte3.Text;
                string fonction = Texte4.Text;
                int cagnotte = Convert.ToInt32(Texte5.Text);
                double indiceCruaute = Convert.ToDouble(Texte7.Text);
                Attraction attraction = new Attraction();
                typesexe sexe = RecupererSexe((string)Liste8.SelectionBoxItem);
                LoupGarou loupGarou = new LoupGarou(indiceCruaute, attraction, cagnotte, fonction, mat, nom, prenom, sexe);
                admin.AjouterLoupGarou(loupGarou);
                MessageBox.Show("Loup garou ajouté.");
            }
            if (choix == "Vampire")
            {
                int mat = Convert.ToInt32(Texte1.Text);
                string nom = Texte2.Text;
                string prenom = Texte3.Text;
                string fonction = Texte4.Text;
                int cagnotte = Convert.ToInt32(Texte5.Text);
                double indiceLuminosite = Convert.ToDouble(Texte7.Text);
                Attraction attraction = new Attraction();
                typesexe sexe = RecupererSexe((string)Liste8.SelectionBoxItem);
                Vampire vampire = new Vampire(indiceLuminosite, attraction, cagnotte, fonction, mat, nom, prenom, sexe);
                admin.AjouterVampire(vampire);
                MessageBox.Show("Vampire ajouté.");
            }
            if (choix == "Zombie")
            {
                int mat = Convert.ToInt32(Texte1.Text);
                string nom = Texte2.Text;
                string prenom = Texte3.Text;
                string fonction = Texte4.Text;
                int cagnotte = Convert.ToInt32(Texte5.Text);
                int degreDecomposition = Convert.ToInt32(Texte7.Text);
                Attraction attraction = new Attraction();
                typesexe sexe = RecupererSexe((string)Liste8.SelectionBoxItem);
                CouleurZ couleur = CouleurZ.bleuatre;
                if ((string)Liste9.SelectionBoxItem == "grisatre")
                {
                    couleur = CouleurZ.grisatre;
                }
                Zombie zombie = new Zombie(degreDecomposition, couleur, attraction, cagnotte, fonction, mat, nom, prenom, sexe);
                admin.AjouterZombie(zombie);
                MessageBox.Show("Zombie ajouté.");
            }
            if (choix == "Boutique")
            {
                string id = Texte1.Text;
                string nom = Texte2.Text;
                int nbMin = Convert.ToInt32(Texte3.Text);
                string typeBesoin = Texte4.Text;
                bool besoinSpecifique = RecupererBool((string)Liste8.SelectionBoxItem);
                TypeBoutique typeBoutique = TypeBoutique.barbeAPapa;
                switch((string)Liste9.SelectionBoxItem)
                {
                    case ("Souvenir"):
                        {
                            typeBoutique = TypeBoutique.souvenir;
                            break;
                        }
                    case ("Nourriture"):
                        {
                            typeBoutique = TypeBoutique.nourriture;
                            break;
                        }
                }
                List<Monstre> equipe = new List<Monstre>();
                TimeSpan time = new TimeSpan(0);
                Boutique boutique = new Boutique(typeBoutique, besoinSpecifique, time, equipe, id, false, "", nbMin, nom, true, typeBesoin);
                MessageBox.Show("Boutique ajoutée.");
            }
            if (choix == "DarkRide")
            {
                string id = Texte1.Text;
                string nom = Texte2.Text;
                int nbMin = Convert.ToInt32(Texte3.Text);
                string typeBesoin = Texte4.Text;
                TimeSpan time = new TimeSpan(0,Convert.ToInt32(Texte5.Text),0);
                bool besoinSpecifique = RecupererBool((string)Liste8.SelectionBoxItem);
                bool vehicule = RecupererBool((string)Liste9.SelectionBoxItem);
                TimeSpan dureeMaintenance = new TimeSpan(0);
                List<Monstre> equipe = new List<Monstre>();
                DarkRide darkRide = new DarkRide(time, vehicule, besoinSpecifique, dureeMaintenance, equipe, id, false, "", nbMin, nom, true, typeBesoin);
                admin.AjouterDarkRide(darkRide);
                MessageBox.Show("DarkRide ajouté.");
            }
            if (choix == "RollerCoaster")
            {
                string id = Texte1.Text;
                string nom = Texte2.Text;
                int nbMin = Convert.ToInt32(Texte3.Text);
                string typeBesoin = Texte4.Text;
                int ageMin = Convert.ToInt32(Texte5.Text);
                int tailleMin = Convert.ToInt32(Texte6.Text);
                bool besoinSpecifique = RecupererBool((string)Liste8.SelectionBoxItem);
                TypeCategorie typeCategorie = TypeCategorie.assise;
                switch((string)Liste9.SelectionBoxItem)
                {
                    case ("Bobsleigh"):
                        {
                            typeCategorie = TypeCategorie.bobsleigh;
                            break;
                        }
                    case ("Inversée"):
                        {
                            typeCategorie = TypeCategorie.inversee;
                            break;
                        }
                }
                TimeSpan dureeMaintenance = new TimeSpan(0);
                List<Monstre> equipe = new List<Monstre>();
                RollerCoaster roller = new RollerCoaster(ageMin, typeCategorie, tailleMin, besoinSpecifique, dureeMaintenance, equipe, id, false, "", nbMin, nom, true, typeBesoin);
                admin.AjouterRollerCoaster(roller);
                MessageBox.Show("RollerCoaster ajouté.");
            }
            if (choix == "Spectacle")
            {
                string id = Texte1.Text;
                string nom = Texte2.Text;
                int nbMin = Convert.ToInt32(Texte3.Text);
                string typeBesoin = Texte4.Text;
                string nomSalle = Texte5.Text;
                int nbPlaces = Convert.ToInt32(Texte6.Text);
                List<DateTime> listeHoraire = new List<DateTime>();
                string[] lHoraire = Texte7.Text.Split(' ');
                foreach(string elt in lHoraire)
                {
                    listeHoraire.Add(Convert.ToDateTime(elt));
                }
                bool besoinSpecifique = RecupererBool((string)Liste8.SelectionBoxItem);
                TimeSpan dureeMaintenance = new TimeSpan(0);
                List<Monstre> equipe = new List<Monstre>();
                Spectacles spectacles = new Spectacles(listeHoraire, nbPlaces, nomSalle, besoinSpecifique, dureeMaintenance, equipe, id, false, "", nbMin, nom, true, typeBesoin);
                admin.AjouterSpectacle(spectacles);
                MessageBox.Show("Spectacle ajouté.");
            }
        }

        private void Liste8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem)Choix.SelectedItem;
            string choix = typeItem.Content.ToString();
            ComboBoxItem item2 = (ComboBoxItem)Liste8.SelectedItem;
            string liste8 = item2.Content.ToString();
            if (choix == "Boutique")
            {
                if (liste8 == "Non")
                {
                    Texte4.IsEnabled = false;
                }
                else
                {
                    Texte4.IsEnabled = true;
                }
            }
        }
    }
}
