using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public interface ICalculAvance
    {
        public Double Moyenne(ICalcul calcul, Double nb1, Double nb2)
        {
            return calcul.Division(calcul.Addition(nb1, nb2),2);
        }
    }
}
