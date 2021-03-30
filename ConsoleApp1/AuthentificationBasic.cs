using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AuthentificationBasic : Authentification
    {
        public override bool Auth(Utilisateur utilisateur)
        {
            bool result = false;
            if (utilisateur.Nom.Equals("cronier") && utilisateur.Prenom.Equals("antoine"))
            {
                result = true;
            }

            return result;
        }
        public override bool Auth(ChefDeProjet utilisateur)
        {
            bool result = false;
            if (utilisateur.Nom.Equals("cronier") && utilisateur.Prenom.Equals("antoine"))
            {
                result = true;
            }

            return result;
        }
    }
}
