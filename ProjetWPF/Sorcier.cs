using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public enum Grade { novice, mega, giga, strata };
    public class Sorcier : Personnel
    {
        private List<string> pouvoirs;
        private Grade tatouage;

        public Sorcier(List<string> pouvoirs, Grade tatouage, string fonction, int matricule, string nom, string prenom, typesexe sexe) : base(fonction, matricule, nom, prenom, sexe)
        {
            this.pouvoirs = pouvoirs;
            this.tatouage = tatouage;
        }
        private string StringPouvoirs()
        {
            string resultat = "";
            foreach (string elt in this.pouvoirs)
            {
                resultat = resultat + "|" + elt;
            }
            return resultat;
        }
        public override string ToString()
        {
            return base.ToString() + StringPouvoirs() + ";" + Convert.ToString(tatouage) + ";";
        }
    }
}
