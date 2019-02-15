using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP6
{
    public class Enseignant : Personnel
    {
        private int grade;
        private Dictionary<string, List<Etudiant>> grp;

       

        public Enseignant(string nom, string prenom,float prime,float salaire,int bureau,int grade){
            this.grade = grade;
            this.nom = nom;
            this.prenom = prenom;
            this.salaire = salaire;
            this.prime = prime;
            this.bureau = bureau;
            this.code = Personnel.GCode++;
            this.grp = new Dictionary<string, List<Etudiant>>();
        }
        
        public int Grade { get => grade; set => grade = value; }
        
        public override float calculerSalaire() => prime + salaire;



    }
}
