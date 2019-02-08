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



        public abstract float calculerSalaire();
    }
}