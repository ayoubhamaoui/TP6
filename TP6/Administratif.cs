using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP6
{
    public class Administratif : Personnel
    {
        public Administratif()
        {
            throw new System.NotImplementedException();
        }

        public override float calculerSalaire()
        {
            return salaire + prime;
        }
    }
}