using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetWPF
{
    public class Administration
    {
        private List<Attraction> attractions;
        private List<Personnel> toutLePersonnel;
        private List<Spectacles> listeSpectacles;
        private List<Boutique> listeBoutiques;
        private List<DarkRide> listeDarkRide;
        private List<RollerCoaster> listeRollerCoasters;
        private List<Vampire> equipeVampire;
        private List<Demon> equipeDemon;
        private List<Fantome> equipeFantome;
        private List<Zombie> equipeZombie;
        private List<LoupGarou> equipeLoupGarou;
        private List<Sorcier> equipeSorcier;
        private List<Monstre> equipeMonstre;

        public Administration(List<Attraction> attractions, List<Personnel> toutLePersonnel, List<Spectacles> listeSpectacles, List<Boutique> listeBoutiques, List<DarkRide> listeDarkRide, List<RollerCoaster> listeRollerCoasters, List<Vampire> equipeVampire, List<Demon> equipeDemon, List<Fantome> equipeFantome, List<Zombie> equipeZombie, List<LoupGarou> equipeLoupGarou, List<Sorcier> equipeSorcier, List<Monstre> equipeMonstre)
        {
            this.attractions = attractions;
            this.toutLePersonnel = toutLePersonnel;
            this.listeSpectacles = listeSpectacles;
            this.listeBoutiques = listeBoutiques;
            this.listeDarkRide = listeDarkRide;
            this.listeRollerCoasters = listeRollerCoasters;
            this.equipeVampire = equipeVampire;
            this.equipeDemon = equipeDemon;
            this.equipeFantome = equipeFantome;
            this.equipeZombie = equipeZombie;
            this.equipeLoupGarou = equipeLoupGarou;
            this.equipeSorcier = equipeSorcier;
            this.equipeMonstre = equipeMonstre;
        }

        public void AjouterAttraction(Attraction attraction)
        {
            this.attractions.Add(attraction);
        }
        public void AjouterPersonnel(Personnel personnel)
        {
            this.toutLePersonnel.Add(personnel);
        }
        public void AjouterVampire(Vampire vampire)
        {
            this.equipeVampire.Add(vampire);
            this.toutLePersonnel.Add(vampire);
            this.equipeMonstre.Add(vampire);
        }
        public void AjouterDemon(Demon demon)
        {
            this.equipeDemon.Add(demon);
            this.toutLePersonnel.Add(demon);
            this.equipeMonstre.Add(demon);
        }
        public void AjouterFantome(Fantome fantome)
        {
            this.equipeFantome.Add(fantome);
            this.toutLePersonnel.Add(fantome);
            this.equipeMonstre.Add(fantome);
        }
        public void AjouterZombie(Zombie zombie)
        {
            this.equipeZombie.Add(zombie);
            this.toutLePersonnel.Add(zombie);
            this.equipeMonstre.Add(zombie);
        }
        public void AjouterLoupGarou(LoupGarou loupgarou)
        {
            this.equipeLoupGarou.Add(loupgarou);
            this.toutLePersonnel.Add(loupgarou);
            this.equipeMonstre.Add(loupgarou);
        }
        public void AjouterSorcier(Sorcier sorcier)
        {
            this.equipeSorcier.Add(sorcier);
            this.toutLePersonnel.Add(sorcier);
        }
        public void AjouterMonstre(Monstre monstre)
        {
            this.equipeMonstre.Add(monstre);
            this.toutLePersonnel.Add(monstre);
        }
        public void AjouterSpectacle(Spectacles spectacle)
        {
            this.listeSpectacles.Add(spectacle);
            this.attractions.Add(spectacle);
        }
        public void AjouterBoutique(Boutique boutique)
        {
            this.listeBoutiques.Add(boutique);
            this.attractions.Add(boutique);
        }
        public void AjouterDarkRide(DarkRide darkride)
        {
            this.listeDarkRide.Add(darkride);
            this.attractions.Add(darkride);
        }
        public void AjouterRollerCoaster(RollerCoaster rollercoaster)
        {
            this.listeRollerCoasters.Add(rollercoaster);
            this.attractions.Add(rollercoaster);
        }
        public List<Vampire> EquipeVampire
        {
            get { return equipeVampire; }
        }
        public List<Demon> EquipeDemon
        {
            get { return equipeDemon; }
        }
        public List<Fantome> EquipeFantome
        {
            get { return equipeFantome; }
        }
        public List<Zombie> EquipeZombie
        {
            get { return equipeZombie; }
        }
        public List<LoupGarou> EquipeLoupGarou
        {
            get { return equipeLoupGarou; }
        }
        public List<Sorcier> EquipeSorcier
        {
            get { return equipeSorcier; }
        }
        public List<Monstre> EquipeMonstre
        {
            get { return equipeMonstre; }
        }
        public List<Spectacles> ListeSpectacles
        {
            get { return listeSpectacles; }
        }
        public List<Boutique> ListeBoutiques
        {
            get { return listeBoutiques; }
        }
        public List<DarkRide> ListeDarkRide
        {
            get { return listeDarkRide; }
        }
        public List<RollerCoaster> ListeRollerCoaster
        {
            get { return listeRollerCoasters; }
        }
        public List<Personnel> ToutLePersonnel
        {
            get { return toutLePersonnel; }
        }
        public List<Attraction> Attractions
        {
            get { return attractions; }
        }

        public void AfficherStockerVampire(string nomFichier)
        {
            StreamWriter fichier = new StreamWriter(nomFichier, false);
            foreach (Vampire elt in equipeVampire)
            {
                fichier.WriteLine(elt.ToString());
                Console.WriteLine(elt.ToString());
            }
            fichier.Close();
        }
        public void AfficherStockerAttractionMaintenance(string nomFichier)
        {
            StreamWriter fichier = new StreamWriter(nomFichier, false);
            foreach (Attraction elt in attractions)
            {
                if (elt.Maintenance)
                {
                    fichier.WriteLine(elt.ToString());
                    Console.WriteLine(elt.ToString());
                }
            }
            fichier.Close();
        }
        public void TriZombieSelonCagnotte()
        {
            Zombie_SortByCagnotte critere = new Zombie_SortByCagnotte();
            this.equipeZombie.Sort(critere);
        }
        public void TriDemonSelonForce()
        {
            Demon_SortByForce critere = new Demon_SortByForce();
            this.equipeDemon.Sort(critere);
        }
    }
}
