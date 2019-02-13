using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    class RH
    {
        public List<Personnel> grh;

        
        public RH()
        {
            grh = new List<Personnel>();
        }

        public void Affiche_ensegnants()
        {
            foreach(Personnel p in grh){
                if(p is Enseignant) Console.WriteLine(p);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
