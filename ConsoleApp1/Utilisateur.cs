using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Utilisateur
    {
        public const String SEPAROTOR = ".";

        protected String nom;

        public virtual String Nom
        {
            get { return nom; }
            set {
                if (value.Length <= 2)
                {
                    throw new Exception();
                }
                nom = value; 
            }
        }

        //public void SetNom(String nom)
        //{
        //    this.nom = nom;
        //}

        //public String GetNom()
        //{
        //    return this.nom;
        //}

        public String Prenom { get; set; }

        public String Fullname()
        {
            return this.Nom + SEPAROTOR + this.Prenom;
        }
    }
}
