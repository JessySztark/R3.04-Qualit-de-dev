using System;

namespace Calculatrice
{
    public static class Calcul
    {
        public static Double Addition(Double a, Double b)
        {
            return a + b;
        }

        public static Double Soustraction(Double a, Double b)
        {
            return a - b;
        }

        public static Double Multiplication(Double a, Double b)
        {
            return a * b;
        }

        public static Double Division(Double a, Double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Erreur de division par zéro.");
            else
                return a / b;
        }

        public static Double Factorielle(double number)
        {
            int nb=(int)number;
            if (number<0)
                throw new ArgumentException("Le nombre doit être positif.");
            if (number!=nb)
                throw new ArgumentException("Le nombre doit être un entier.");

            int factorielle=1;

            for (int counter = 1; counter <= nb; counter++)
            {
                factorielle *= counter;
            }
            return factorielle;
        }
    }
}
