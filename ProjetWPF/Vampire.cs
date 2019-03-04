using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class Vampire : Monstre
    {
        private double indiceLuminosite;

        public Vampire(double indiceLuminosite, Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, typesexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
            this.indiceLuminosite = indiceLuminosite;
        }
        public override string ToString()
        {
            return base.ToString() + Convert.ToString(indiceLuminosite) + ";";
        }
        public double ObtenirIndiceLuminosite()
        {
            return this.indiceLuminosite;
        }
        public int ObtenirCagnotte()
        {
            return base.GetCagnotte;
        }
    }
}
