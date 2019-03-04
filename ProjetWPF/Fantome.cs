using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class Fantome : Monstre
    {
        public Fantome(Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, typesexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public int ObtenirCagnotte()
        {
            return base.GetCagnotte;
        }
    }
}
