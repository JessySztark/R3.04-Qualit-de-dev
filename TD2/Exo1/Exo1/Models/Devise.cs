using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1.Models
{
    public class Devise
    {
        private String nomDevise;
        private float taux;

        public Devise(string nomDevise, float taux)
        {
            this.NomDevise = nomDevise;
            this.Taux = taux;
        }

        public string NomDevise
        {
            get
            {
                return this.nomDevise;
            }

            set
            {
                this.nomDevise = value;
            }
        }

        public float Taux
        {
            get
            {
                return this.taux;
            }

            set
            {
                this.taux = value;
            }
        }
    }
}
