using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public enum typesexe { male, femelle, autre };
    public class Personnel
    {
        private string fonction;
        private int matricule;
        private string nom;
        private string prenom;
        private typesexe sexe;

        public Personnel(string fonction, int matricule, string nom, string prenom, typesexe sexe)
        {
            this.fonction = fonction;
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
        }
        public void ChangerFonction(string nouvelleFonction)
        {
            this.fonction = nouvelleFonction;
        }
        public override string ToString()
        {
            return Convert.ToString(matricule) + ";" + nom + ";" + prenom + ";" + Convert.ToString(sexe) + ";" + fonction + ";";
        }

        public int Matricule
        {
            get { return matricule; }
        }
        public string Nom
        {
            get { return nom; }
        }
        public string Prenom
        {
            get { return prenom; }
        }
    }
}
