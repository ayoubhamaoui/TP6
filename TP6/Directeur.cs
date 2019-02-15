using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP6
{
    public class Directeur : Personnel
    {
        private static Boolean isInstancied = false;

        private Directeur(int code, string prenom, string nom, int bureau, int salaire, float primDiplacement) : base(code, prenom, nom, bureau, salaire,primDiplacement)
        {
        }

        public static Directeur instancie(int code, string prenom, string nom, int bureau, int salaire, float primDiplacement)
        {
            if (!isInstancied)
            {
                return new Directeur(code, prenom, nom, bureau, salaire, primDiplacement);
            }
            throw new Exception("already exists");
        }

        public override float calculerSalaire()
        {
            return base.Saliare + this.prime;
        }

        public override string ToString()
        {
            return base.ToString() + "  prime de deplacement : " + this.prime;
        }
    }
}