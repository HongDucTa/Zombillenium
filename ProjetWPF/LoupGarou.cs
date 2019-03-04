using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class LoupGarou : Monstre
    {
        private double indiceCruaute;

        public LoupGarou(double indiceCruaute, Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, typesexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
            this.indiceCruaute = indiceCruaute;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + Convert.ToString(indiceCruaute) + ";";
        }

        public double ObtenirIndiceCruaute()
        {
            return this.indiceCruaute;
        }
        public int ObtenirCagnotte()
        {
            return base.GetCagnotte;
        }
    }
}
