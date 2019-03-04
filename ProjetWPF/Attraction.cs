using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class Attraction
    {
        private bool besoinSpecifique;
        private TimeSpan dureeMaintenance;
        private List<Monstre> equipe;
        private string identifiant;
        private bool maintenance;
        private string natureMaintenance;
        private int nbMinMonsttre;
        private string nom;
        private bool ouvert;
        private string typeDeBesoin;

        private string StringEquipe()
        {
            string resultat = "";
            if (this.equipe != null)
            {
                foreach (Monstre elt in this.equipe)
                {
                    resultat = resultat + elt.ToString() + " | ";
                }
            }
            return resultat;
        }

        public override string ToString()
        {
            return Convert.ToString(besoinSpecifique) + ";" + Convert.ToString(dureeMaintenance) + ";" + StringEquipe() + ";" + Convert.ToString(identifiant) + ";" + Convert.ToString(maintenance) + ";" + natureMaintenance + ";" + Convert.ToString(nbMinMonsttre) + ";" + nom + ";" + Convert.ToString(ouvert) + ";" + typeDeBesoin + ";";
        }

        public Attraction(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, string identifiant, bool maintenance, string natureMaintenance, int nbMinMonsttre, string nom, bool ouvert, string typeDeBesoin)
        {
            this.besoinSpecifique = besoinSpecifique;
            this.dureeMaintenance = dureeMaintenance;
            this.equipe = equipe;
            this.identifiant = identifiant;
            this.maintenance = maintenance;
            this.natureMaintenance = natureMaintenance;
            this.nbMinMonsttre = nbMinMonsttre;
            this.nom = nom;
            this.ouvert = ouvert;
            this.typeDeBesoin = typeDeBesoin;

        }
        public Attraction()
        {
            this.nom = "";
            this.identifiant = "";
        }
        public void ChangerMaintenance(TimeSpan nouvelleDureeMaintenance, bool nouvelleMaintenance, string nouvelleNatureMaintenance)
        {
            this.dureeMaintenance = nouvelleDureeMaintenance;
            this.maintenance = nouvelleMaintenance;
            this.natureMaintenance = nouvelleNatureMaintenance;
        }
        public string ObtenirIdentifiant()
        {
            return this.identifiant;
        }
        public bool Maintenance
        {
            get { return maintenance; }
        }
        public string Nom
        {
            get { return nom; }
        }
        public List<Monstre> Equipe
        {
            get { return equipe; }
        }
    }
}
