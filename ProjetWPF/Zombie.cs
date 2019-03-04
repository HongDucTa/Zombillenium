using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public enum CouleurZ { bleuatre, grisatre };
    public class Zombie : Monstre
    {
        private int degreDecomposition;
        private CouleurZ teint;
        private bool peutDisparaitre;

        public override string ToString()
        {
            return base.ToString() + Convert.ToString(degreDecomposition) + ";" + Convert.ToString(teint) + ";" + Convert.ToString(peutDisparaitre) + ";";
        }

        public Zombie(int degreDecomposition, CouleurZ teint, Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, typesexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
            this.degreDecomposition = degreDecomposition;
            this.teint = teint;
            this.peutDisparaitre = false;
        }

        public int ObtenirCagnotte()
        {
            return base.GetCagnotte;
        }
        public int ObtenirDegreDecomposition()
        {
            return this.degreDecomposition;
        }
        public void Promotion(Administration admin)
        {
            Demotion(admin);
            if (base.GetCagnotte > 500)
            {
                this.peutDisparaitre = true;
            }
            else
            {
                this.peutDisparaitre = false;
            }
        }
    }
}
