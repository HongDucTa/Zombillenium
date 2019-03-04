using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public enum TypeBoutique { souvenir, barbeAPapa, nourriture };
    public class Boutique : Attraction
    {
        private TypeBoutique type;

        public Boutique(TypeBoutique type, bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, string identifiant, bool maintenance, string natureMaintenance, int nbMinMonsttre, string nom, bool ouvert, string typeDeBesoin) : base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonsttre, nom, ouvert, typeDeBesoin)
        {
            this.type = type;
        }
        public TypeBoutique Type
        {
            get { return type; }
        }
        public override string ToString()
        {
            return base.ToString() + Convert.ToString(type) + ";";
        }
    }
}
