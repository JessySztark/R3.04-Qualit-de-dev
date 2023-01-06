using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public interface ICalcul
    {
        /*private static ICalcul? _instance;
        private static readonly object _lock = new object();
        */
        public Double Addition(Double a, Double b)
        {
            return a + b;
        }

        public Double Soustraction(Double a, Double b)
        {
            return a - b;
        }

        public Double Multiplication(Double a, Double b)
        {
            return a * b;
        }

        public Double Division(Double a, Double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Erreur de division par zéro.");
            else
                return a / b;
        }

        public Double Factorielle(double number)
        {
            int nb = (int)number;
            if (number < 0)
                throw new ArgumentException("Le nombre doit être positif.");
            if (number != nb)
                throw new ArgumentException("Le nombre doit être un entier.");

            int factorielle = 1;

            for (int counter = 1; counter <= nb; counter++)
            {
                factorielle *= counter;
            }
            return factorielle;
        }

        /*public static ICalcul Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ICalcul();
                        }
                    }
                }
                return _instance;
            }
        }*/
    }
}
