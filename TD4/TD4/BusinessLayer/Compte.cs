using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Compte
    {
        private int idCompte;
        private double solde;

        public Compte()
        {

        }

        public Compte(int idCompte, double solde)
        {
            this.idCompte = idCompte;
            this.solde = solde;
        }

        public int IdCompte
        {
            get
            {
                return this.idCompte;
            }

            set
            {
                this.idCompte = value;
            }
        }

        public double Solde
        {
            get
            {
                return this.solde;
            }

            set
            {
                this.solde = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Compte compte &&
                   idCompte == compte.idCompte &&
                   solde == compte.solde;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idCompte, solde);
        }
    }
}
