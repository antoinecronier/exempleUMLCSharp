using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Utilisateur.SEPAROTOR);

            Utilisateur utilisateur1 = new Utilisateur();
            utilisateur1.Nom = "toto";
            Console.WriteLine(utilisateur1.Nom);
            utilisateur1.Prenom = "titi";

            Utilisateur utilisateur2 = new Utilisateur();
            utilisateur2.Nom = "cronier";
            utilisateur2.Prenom = "antoine";

            Administrateur admin1 = new Administrateur();
            admin1.Nom = "nom1";
            admin1.Prenom = "prenom1";
            admin1.NEmploye = "56465498";

            Utilisateur admin2 = new Administrateur();
            admin2.Nom = "cronier";
            admin2.Prenom = "antoine";
            (admin2 as Administrateur).NEmploye = "aze456546sd4f";

            //Administrateur admin3 = new Utilisateur();
            //(utilisateur2 as Administrateur).NEmploye = "+95+5";

            Authentification auth = new AuthentificationAvance();
            //Authentification auth1 = new Authentification();

            if (auth.Auth(admin2))
            {
                Console.WriteLine("connected");
            }
            else
            {
                Console.WriteLine("cannot connect");
            }

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

        }
    }
}
