using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Administrateur : Utilisateur
    {
        public override string Nom 
        { 
            get => base.Nom; 
            set
            {
                if (value.Length < 12)
                {
                    throw new Exception();
                }
                base.nom = value;
            }
        }

        public String NEmploye { get; set; }
        
        //public String[] NEmploye { get; set; } = new string[2];

        public String EmployeFullname()
        {
            return this.Nom + "|" + this.Prenom + "|" + NEmploye;
        }
    }
}
