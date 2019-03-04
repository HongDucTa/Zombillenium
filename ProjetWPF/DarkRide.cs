using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class DarkRide : Attraction
    {
        private TimeSpan duree;
        private bool vehicule;

        public DarkRide(TimeSpan duree, bool vehicule, bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, string identifiant, bool maintenance, string natureMaintenance, int nbMinMonsttre, string nom, bool ouvert, string typeDeBesoin) : base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonsttre, nom, ouvert, typeDeBesoin)
        {
            this.duree = duree;
            this.vehicule = vehicule;
        }
        public override string ToString()
        {
            return base.ToString() + Convert.ToString(duree) + ";" + Convert.ToString(vehicule) + ";";
        }
    }
}
