using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Authentification
    {
        public abstract bool Auth(Utilisateur utilisateur);
        public abstract bool Auth(ChefDeProjet utilisateur);
    }
}
