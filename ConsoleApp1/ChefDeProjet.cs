using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ChefDeProjet
    {
        public static int NbInstance { get; set; }

        public String Nom { get; set; }
        public String Prenom { get; set; }

        public ChefDeProjet()
        {
            NbInstance++;
            //this.NbInstance = this.NbInstance + 1;
        }
    }
}
