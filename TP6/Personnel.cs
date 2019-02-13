using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP6
{
    public abstract class Personnel : Personne
    {
        public static int GCode = 0;
        protected int bureau;
        protected float salaire;
        protected float prime;

        public int Bureau
        {
            get => bureau;
            set => bureau = value;
        }

        public float Saliare
        {
            get => salaire;
            set => salaire = value;
        }

        public float Prime
        {
            get => prime;
            set => prime = value;
        }


        protected Personnel(int code, string prenom, string nom, int bureau, float salaire, float prime) : base(code, prenom, nom)
        {
            this.bureau = bureau;
            this.salaire = salaire;
            this.prime = prime;
        }

        public abstract float calculerSalaire();

        public override string ToString()
        {
            return base.ToString() + " bureau : " + bureau + "salaire : " + salaire;
        }
    }
}