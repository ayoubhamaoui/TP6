using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP6
{
    public class Directeur : Personnel
    {
        public Directeur(string nom)
        {
            this.nom = nom;
            
        }

        public override float calculerSalaire() => salaire + prime;
    }
}