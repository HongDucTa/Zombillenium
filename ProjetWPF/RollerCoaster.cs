using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public enum TypeCategorie { assise, inversee, bobsleigh };
    public class RollerCoaster : Attraction
    {
        private int ageMinimum;
        private TypeCategorie categorie;
        private double tailleMinimum;

        public RollerCoaster(int ageMinimum, TypeCategorie categorie, double tailleMinimum, bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, string identifiant, bool maintenance, string natureMaintenance, int nbMinMonsttre, string nom, bool ouvert, string typeDeBesoin) : base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonsttre, nom, ouvert, typeDeBesoin)
        {
            this.ageMinimum = ageMinimum;
            this.categorie = categorie;
            this.tailleMinimum = tailleMinimum;
        }
        public override string ToString()
        {
            return base.ToString() + Convert.ToString(ageMinimum) + ";" + Convert.ToString(categorie) + ";" + Convert.ToString(tailleMinimum) + ";";
        }
    }
}
