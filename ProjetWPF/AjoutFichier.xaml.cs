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
using System.Windows.Forms;
using System.IO;

namespace ProjetWPF
{
    /// <summary>
    /// Logique d'interaction pour AjoutFichier.xaml
    /// </summary>
    public partial class AjoutFichier : Page
    {
        Administration admin;
        public AjoutFichier(Administration admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        static public Attraction RechercheAttractionParIdentifiant(string identifiant, List<Attraction> ListeAttractions)
        {
            Attraction resultat = new Attraction();
            bool continuer = true;
            int indice = 0;
            int indiceMax = ListeAttractions.Count() - 1;
            while (continuer)
            {
                if (identifiant == ListeAttractions[indice].ObtenirIdentifiant())
                {
                    resultat = ListeAttractions[indice];
                    continuer = false;

                }

                indice++;
                if (indice > indiceMax)
                {
                    continuer = false;
                }
            }
            return resultat;
        }

        static public void LireFichierAttraction(StreamReader fichier, Administration admin,TextBlock text)
        {
            string ligne = fichier.ReadLine();
            while (ligne != null)
            {
                string[] temp = ligne.Split(';');
                if (temp[0] == "Boutique")
                {
                    try
                    {
                        string test = temp[6];
                        string identifiantBoutique = temp[1];
                        string nomBoutique = temp[2];
                        int nbMinMonstreBoutique = 0;
                        try
                        {
                            nbMinMonstreBoutique = Convert.ToInt32(temp[3]);
                        }
                        catch (Exception ex)
                        {

                        }
                        bool besoinSpecifiqueBoutique = false;
                        try
                        {
                            besoinSpecifiqueBoutique = Convert.ToBoolean(temp[4]);
                        }
                        catch (Exception ex)
                        {

                        }
                        string typeDeBesoinBoutique = temp[5];
                        TypeBoutique type = TypeBoutique.souvenir;
                        if (temp[6] == "barbeAPapa")
                        {
                            type = TypeBoutique.barbeAPapa;
                        }
                        if (temp[6] == "nourriture")
                        {
                            type = TypeBoutique.nourriture;
                        }
                        List<Monstre> EquipeBoutique = new List<Monstre>();
                        TimeSpan dureeMaintenanceBoutique = new TimeSpan(0, 0, 0, 0);
                        bool maintenanceBoutique = false;
                        string natureMaintenanceBoutique = "";
                        bool ouvertBoutique = true;
                        Boutique boutique = new Boutique(type, besoinSpecifiqueBoutique, dureeMaintenanceBoutique, EquipeBoutique, identifiantBoutique, maintenanceBoutique, natureMaintenanceBoutique, nbMinMonstreBoutique, nomBoutique, ouvertBoutique, typeDeBesoinBoutique);
                        admin.AjouterBoutique(boutique);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }

                }
                if (temp[0] == "DarkRide")
                {
                    try
                    {
                        string test = temp[7];
                        string identifiantDarkRide = temp[1];
                        string nomDarkRide = temp[2];
                        int nbMinMonstreDarkRide = 0;
                        try
                        {
                            nbMinMonstreDarkRide = Convert.ToInt32(temp[3]);
                        }
                        catch (Exception ex)
                        {

                        }
                        bool besoinSpecifiqueDarkRide = false;
                        try
                        {
                            besoinSpecifiqueDarkRide = Convert.ToBoolean(temp[4]);
                        }
                        catch (Exception ex)
                        {

                        }
                        string typeDeBesoinDarkRide = temp[5];
                        TimeSpan dureeDarkRide = new TimeSpan(0, 0, Convert.ToInt32(temp[6]), 0);
                        bool vehiculeDarkRide = false;
                        try
                        {
                            vehiculeDarkRide = Convert.ToBoolean(temp[7]);
                        }
                        catch (Exception ex)
                        {

                        }
                        List<Monstre> EquipeDarkRide = new List<Monstre>();
                        TimeSpan dureeMaintenanceDarkRide = new TimeSpan(0, 0, 0, 0);
                        bool maintenanceDarkRide = false;
                        string natureMaintenanceDarkRide = "";
                        bool ouvertDarkRide = true;
                        DarkRide darkRide = new DarkRide(dureeDarkRide, vehiculeDarkRide, besoinSpecifiqueDarkRide, dureeMaintenanceDarkRide, EquipeDarkRide, identifiantDarkRide, maintenanceDarkRide, natureMaintenanceDarkRide, nbMinMonstreDarkRide, nomDarkRide, ouvertDarkRide, typeDeBesoinDarkRide);
                        admin.AjouterDarkRide(darkRide);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }

                }
                if (temp[0] == "RollerCoaster")
                {
                    try
                    {
                        string test = temp[8];
                        string identifiantRollerCoaster = temp[1];
                        string nomRollerCoaster = temp[2];
                        int nbMinMonstreRollerCoaster = 0;
                        try
                        {
                            nbMinMonstreRollerCoaster = Convert.ToInt32(temp[3]);
                        }
                        catch (Exception ex)
                        {
                        }
                        bool besoinSpecifiqueRollerCoaster = false;
                        try
                        {
                            besoinSpecifiqueRollerCoaster = Convert.ToBoolean(temp[4]);
                        }
                        catch (Exception ex)
                        {

                        }
                        string typeDeBesoinRollerCoaster = temp[5];
                        TypeCategorie categorieRollerCoaster = TypeCategorie.assise;
                        if (temp[6] == "bobsleigh")
                        {
                            categorieRollerCoaster = TypeCategorie.bobsleigh;
                        }
                        if (temp[6] == "inversee")
                        {
                            categorieRollerCoaster = TypeCategorie.inversee;
                        }
                        int ageMinimumRollerCoaster = 0;
                        try
                        {
                            ageMinimumRollerCoaster = Convert.ToInt32(temp[7]);
                        }
                        catch (Exception ex)
                        {

                        }
                        double tailleMinimumRollerCoaster = 0;
                        try
                        {
                            tailleMinimumRollerCoaster = Convert.ToDouble(temp[8]);
                        }
                        catch (Exception ex)
                        {

                        }
                        List<Monstre> EquipeRollerCoaster = new List<Monstre>();
                        TimeSpan dureeMaintenanceRollerCoaster = new TimeSpan(0, 0, 0, 0);
                        bool maintenanceRollerCoaster = false;
                        string natureMaintenanceRollerCoaster = "";
                        bool ouvertRollerCoaster = true;
                        RollerCoaster rollerCoaster = new RollerCoaster(ageMinimumRollerCoaster, categorieRollerCoaster, tailleMinimumRollerCoaster, besoinSpecifiqueRollerCoaster, dureeMaintenanceRollerCoaster, EquipeRollerCoaster, identifiantRollerCoaster, maintenanceRollerCoaster, natureMaintenanceRollerCoaster, nbMinMonstreRollerCoaster, nomRollerCoaster, ouvertRollerCoaster, typeDeBesoinRollerCoaster);
                        admin.AjouterRollerCoaster(rollerCoaster);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                if (temp[0] == "Spectacle")
                {
                    try
                    {
                        string test = temp[8];
                        string identifiantSpectacle = temp[1];
                        string nomSpectacle = temp[2];
                        int nbMinMonstreSpectacle = 0;
                        try
                        {
                            nbMinMonstreSpectacle = Convert.ToInt32(temp[3]);
                        }
                        catch (Exception ex)
                        {

                        }
                        bool besoinSpecifiqueSpectacle = false;
                        try
                        {
                            besoinSpecifiqueSpectacle = Convert.ToBoolean(temp[4]);
                        }
                        catch (Exception ex)
                        {

                        }
                        string typeDeBesoinSpectacle = temp[5];
                        string nomSalleSpectacle = temp[6];
                        int nbPlaceSpectacle = 0;
                        try
                        {
                            nbPlaceSpectacle = Convert.ToInt32(temp[7]);
                        }
                        catch (Exception ex)
                        {

                        }
                        List<DateTime> horaireSpectacle = new List<DateTime>();
                        string[] tempDate = temp[8].Split(' ');
                        foreach (string elt in tempDate)
                        {
                            horaireSpectacle.Add(Convert.ToDateTime(elt));
                        }
                        List<Monstre> EquipeSpectacle = new List<Monstre>();
                        TimeSpan dureeMaintenanceSpectacle = new TimeSpan(0, 0, 0, 0);
                        bool maintenanceSpectacle = false;
                        string natureMaintenanceSpectacle = "";
                        bool ouvertSpectacle = true;
                        Spectacles spectacle = new Spectacles(horaireSpectacle, nbPlaceSpectacle, nomSalleSpectacle, besoinSpecifiqueSpectacle, dureeMaintenanceSpectacle, EquipeSpectacle, identifiantSpectacle, maintenanceSpectacle, natureMaintenanceSpectacle, nbMinMonstreSpectacle, nomSpectacle, ouvertSpectacle, typeDeBesoinSpectacle);
                        admin.AjouterSpectacle(spectacle);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }

                }
                ligne = fichier.ReadLine();

            }
            fichier.Close();
        }




        static public void LireFichierPersonnel(StreamReader fichier, Administration admin,TextBlock text)
        {
            string ligne = fichier.ReadLine();
            while (ligne != null)
            {
                string[] temp = ligne.Split(';');
                if (temp[0] == "Sorcier")
                {
                    try
                    {
                        string test = temp[7];
                        int matriculeSorcier = Convert.ToInt32(temp[1]);
                        string nomSorcier = temp[2];
                        string prenomSorcier = temp[3];
                        typesexe sexeSorcier = typesexe.autre;
                        if (temp[4] == "femelle")
                        {
                            sexeSorcier = typesexe.femelle;
                        }
                        if (temp[4] == "male")
                        {
                            sexeSorcier = typesexe.male;
                        }
                        string fonctionSorcier = temp[5];
                        Grade tatouageSorcier = Grade.novice;
                        if (temp[6] == "mega")
                        {
                            tatouageSorcier = Grade.mega;
                        }
                        if (temp[6] == "giga")
                        {
                            tatouageSorcier = Grade.giga;
                        }
                        if (temp[6] == "strata")
                        {
                            tatouageSorcier = Grade.strata;
                        }
                        string test1 = "";
                        List<String> pouvoirsSorcier = new List<String>();
                        foreach (char elt in temp[7])
                        {
                            if (elt != '-')
                            {

                                test1 = test1 + elt;
                            }
                            else
                            {
                                pouvoirsSorcier.Add(test1);
                                test1 = "";
                            }

                        }
                        pouvoirsSorcier.Add(test1);

                        Sorcier sorcier = new Sorcier(pouvoirsSorcier, tatouageSorcier, fonctionSorcier, matriculeSorcier, nomSorcier, prenomSorcier, sexeSorcier);
                        admin.AjouterSorcier(sorcier);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }
                }

                if (temp[0] == "Monstre")
                {
                    try
                    {
                        string test = temp[7];
                        int matriculeMonstre = Convert.ToInt32(temp[1]);
                        string nomMonstre = temp[2];
                        string prenomMonstre = temp[3];
                        typesexe sexeMonstre = typesexe.autre;
                        if (temp[4] == "femelle")
                        {
                            sexeMonstre = typesexe.femelle;
                        }
                        if (temp[4] == "male")
                        {
                            sexeMonstre = typesexe.male;
                        }
                        string fonctionMonstre = temp[5];
                        int cagnotteMonstre = Convert.ToInt32(temp[6]);
                        Attraction affectationMonstre = RechercheAttractionParIdentifiant(temp[7], admin.Attractions);
                        Monstre monstre = new Monstre(affectationMonstre, cagnotteMonstre, fonctionMonstre, matriculeMonstre, nomMonstre, prenomMonstre, sexeMonstre);
                        admin.AjouterMonstre(monstre);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }
                }


                if (temp[0] == "Demon")
                {
                    try
                    {
                        string test = temp[8];
                        int matriculeDemon = Convert.ToInt32(temp[1]);
                        string nomDemon = temp[2];
                        string prenomDemon = temp[3];
                        typesexe sexeDemon = typesexe.autre;
                        if (temp[4] == "femelle")
                        {
                            sexeDemon = typesexe.femelle;
                        }
                        if (temp[4] == "male")
                        {
                            sexeDemon = typesexe.male;
                        }
                        string fonctionDemon = temp[5];
                        int cagnotteDemon = Convert.ToInt32(temp[6]);
                        Attraction affectationDemon = RechercheAttractionParIdentifiant(temp[7], admin.Attractions);
                        int forceDemon = Convert.ToInt32(temp[8]);
                        Demon demon = new Demon(forceDemon, affectationDemon, cagnotteDemon, fonctionDemon, matriculeDemon, nomDemon, prenomDemon, sexeDemon);
                        admin.AjouterDemon(demon);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }
                }


                if (temp[0] == "Fantome")
                {
                    try
                    {
                        string test = temp[7];
                        int matriculeFantome = Convert.ToInt32(temp[1]);
                        string nomFantome = temp[2];
                        string prenomFantome = temp[3];
                        typesexe sexeFantome = typesexe.autre;
                        if (temp[4] == "femelle")
                        {
                            sexeFantome = typesexe.femelle;
                        }
                        if (temp[4] == "male")
                        {
                            sexeFantome = typesexe.male;
                        }
                        string fonctionFantome = temp[5];
                        int cagnotteFantome = Convert.ToInt32(temp[6]);
                        Attraction affectationFantome = RechercheAttractionParIdentifiant(temp[7], admin.Attractions);
                        Fantome fantome = new Fantome(affectationFantome, cagnotteFantome, fonctionFantome, matriculeFantome, nomFantome, prenomFantome, sexeFantome);
                        admin.AjouterFantome(fantome);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }

                }
                if (temp[0] == "LoupGarou")
                {
                    try
                    {
                        string test = temp[8];
                        int matriculeLoupGarou = Convert.ToInt32(temp[1]);
                        string nomLoupGarou = temp[2];
                        string prenomLoupGarou = temp[3];
                        typesexe sexeLoupGarou = typesexe.autre;
                        if (temp[4] == "femelle")
                        {
                            sexeLoupGarou = typesexe.femelle;
                        }
                        if (temp[4] == "male")
                        {
                            sexeLoupGarou = typesexe.male;
                        }
                        string fonctionLoupGarou = temp[5];
                        int cagnotteLoupGarou = Convert.ToInt32(temp[6]);
                        Attraction affectationLoupGarou = RechercheAttractionParIdentifiant(temp[7], admin.Attractions);
                        double indiceCruauteLoupGarou = Convert.ToDouble(temp[8]);
                        LoupGarou loupgarou = new LoupGarou(indiceCruauteLoupGarou, affectationLoupGarou, cagnotteLoupGarou, fonctionLoupGarou, matriculeLoupGarou, nomLoupGarou, prenomLoupGarou, sexeLoupGarou);
                        admin.AjouterLoupGarou(loupgarou);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                if (temp[0] == "Vampire")
                {
                    try
                    {
                        string test = temp[8];
                        int matriculeVampire = Convert.ToInt32(temp[1]);
                        string nomVampire = temp[2];
                        string prenomVampire = temp[3];
                        typesexe sexeVampire = typesexe.autre;
                        if (temp[4] == "femelle")
                        {
                            sexeVampire = typesexe.femelle;
                        }
                        if (temp[4] == "male")
                        {
                            sexeVampire = typesexe.male;
                        }
                        string fonctionVampire = temp[5];
                        int cagnotteVampire = Convert.ToInt32(temp[6]);
                        Attraction affectationVampire = RechercheAttractionParIdentifiant(temp[7], admin.Attractions);
                        double indiceLuminositeVampire = Convert.ToDouble(temp[8]);
                        Vampire vampire = new Vampire(indiceLuminositeVampire, affectationVampire, cagnotteVampire, fonctionVampire, matriculeVampire, nomVampire, prenomVampire, sexeVampire);
                        admin.AjouterVampire(vampire);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                if (temp[0] == "Zombie")
                {
                    try
                    {
                        string test = temp[9];
                        int matriculeZombie = Convert.ToInt32(temp[1]);
                        string nomZombie = temp[2];
                        string prenomZombie = temp[3];
                        typesexe sexeZombie = typesexe.autre;
                        if (temp[4] == "femelle")
                        {
                            sexeZombie = typesexe.femelle;
                        }
                        if (temp[4] == "male")
                        {
                            sexeZombie = typesexe.male;
                        }
                        string fonctionZombie = temp[5];
                        int cagnotteZombie = Convert.ToInt32(temp[6]);
                        Attraction affectationZombie = RechercheAttractionParIdentifiant(temp[7], admin.Attractions);
                        CouleurZ teintZombie = CouleurZ.bleuatre;
                        if (temp[8] == "grisatre")
                        {
                            teintZombie = CouleurZ.grisatre;
                        }
                        int degreDecompositionZombie = Convert.ToInt32(temp[9]);
                        Zombie zombie = new Zombie(degreDecompositionZombie, teintZombie, affectationZombie, cagnotteZombie, fonctionZombie, matriculeZombie, nomZombie, prenomZombie, sexeZombie);
                        admin.AjouterZombie(zombie);
                        text.Text = text.Text + "\n" + ligne;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                ligne = fichier.ReadLine();
            }
            fichier.Close();
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

        private void Parcourir(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Select a CSV File";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                StreamReader fichierAttraction = new StreamReader(openFileDialog.OpenFile());
                StreamReader fichierPersonnel = new StreamReader(openFileDialog.OpenFile());
                LireFichierAttraction(fichierAttraction, admin,TextTraitement);
                LireFichierPersonnel(fichierPersonnel, admin,TextTraitement);
                System.Windows.MessageBox.Show("Ajout effectué !");
            }
        }
    }
}
