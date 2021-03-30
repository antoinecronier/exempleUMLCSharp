using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AuthentificationAvance : Authentification
    {
        public override bool Auth(Utilisateur utilisateur)
        {
            return true;
        }

        public override bool Auth(ChefDeProjet utilisateur)
        {
            return true;
        }
    }
}
