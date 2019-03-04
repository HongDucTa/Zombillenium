using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class Demon : Monstre
    {
        private int force;
        bool peutDisparaitre;

        public Demon(int force, Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, typesexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
            this.force = force;
            this.peutDisparaitre = false;
        }
        public int ObtenirForce()
        {
            return this.force;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + Convert.ToString(force) + ";" + Convert.ToString(peutDisparaitre) + ";";
        }
        public int ObtenirCagnotte()
        {
            return base.GetCagnotte;
        }
        public void Promotion(Administration admin)
        {
            base.Demotion(admin);
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
