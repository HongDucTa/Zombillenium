using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class Monstre : Personnel
    {
        private Attraction affectation;
        private int cagnotte;

        public override string ToString()
        {
            return base.ToString() + affectation.ToString() + ";" + Convert.ToString(cagnotte) + ";";
        }

        public Monstre(Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, typesexe sexe) : base(fonction, matricule, nom, prenom, sexe)
        {
            this.affectation = affectation;
            this.cagnotte = cagnotte;
        }
        public void ChangerAffectation(Attraction nouvelleAffectation)
        {
            this.affectation = nouvelleAffectation;
            nouvelleAffectation.Equipe.Add(this);
        }
        public void ChangerCagnotte(int nombre)
        {
            this.cagnotte = this.cagnotte + nombre;
        }
        private Attraction RechercherBarbeAPapa(List<Boutique> listeBoutique)
        {
            Attraction resultat = new Attraction();
            bool continuer = true;
            int indice = 0;
            while (continuer && (indice < listeBoutique.Count()))
            {
                if (listeBoutique[indice].Type == TypeBoutique.barbeAPapa)
                {
                    continuer = false;
                    resultat = listeBoutique[indice];
                }
                indice++;
            }
            return resultat;
        }
        public void AffecterBarbeAPapa(List<Boutique> listeBoutique)
        {
            this.affectation = RechercherBarbeAPapa(listeBoutique);
        }
        public void Demotion(Administration admin)
        {
            if (this.cagnotte < 50)
            {
                AffecterBarbeAPapa(admin.ListeBoutiques);
            }
        }
        public int GetCagnotte
        {
            get { return this.cagnotte; }
        }
        public Attraction Affectation
        {
            get { return affectation; }
        }
    }
}
