using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP6
{
    public class Etudiant : Personne
    {
        private string niveau;
        private float moy;

        public string Niveau
        {
            get => niveau;
            set => niveau = value;
        }

        public float Moy
        {
            get => moy;
            set => moy = value;
        }

        public Etudiant(int code, string prenom, string nom, string niveau, float moyenneAnnuele) : base(code, prenom, nom)
        {
            this.niveau = niveau;
            moy = moyenneAnnuele;
        }

        public int CompareTo(Etudiant other)
        {
            if (moy < other.Moy)
                return -1;
            return 1;

        }

        public override string ToString()
        {
            return base.ToString() + "  niveau " + niveau + "moyenne annuele : " + moy;
        }
    }
}