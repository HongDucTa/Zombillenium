using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class Spectacles : Attraction
    {
        private List<DateTime> horaire;
        private int nombrePlace;
        private string nomSalle;

        public Spectacles(List<DateTime> horaire, int nombrePlace, string nomSalle, bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, string identifiant, bool maintenance, string natureMaintenance, int nbMinMonsttre, string nom, bool ouvert, string typeDeBesoin) : base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonsttre, nom, ouvert, typeDeBesoin)
        {
            this.horaire = horaire;
            this.nombrePlace = nombrePlace;
            this.nomSalle = nomSalle;
        }
        private string StringHoraire()
        {
            string resultat = "";
            foreach (DateTime elt in this.horaire)
            {
                resultat = resultat + " " + Convert.ToString(elt);
            }
            return resultat;
        }
        public override string ToString()
        {
            return base.ToString() + StringHoraire() + ";" + Convert.ToString(nombrePlace) + ";" + nomSalle + ";";
        }
    }
}
