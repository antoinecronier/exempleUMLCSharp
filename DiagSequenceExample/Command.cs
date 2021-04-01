using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagSequenceExample
{
    public class Command
    {
        public Client Client { get; set; }

        public decimal CalculerPrix()
        {
            int quantite = this.LigneCommand.Quantite;
            Produit produit = this.LigneCommand.Produit;
            decimal detailTarification = produit.DetailTarification;
            decimal prixBase = this.CalculerPrixBase(quantite, detailTarification);
            decimal remise = this.InfoRemise();

            return prixBase * remise;
        }

        private decimal InfoRemise()
        {
            return this.Client.Remise;
        }

        private decimal CalculerPrixBase(int quantite, decimal detailTarification)
        {
            return quantite * detailTarification;
        }

        public LigneCommand LigneCommand { get; set; }
    }
}
