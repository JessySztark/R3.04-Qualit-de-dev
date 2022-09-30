using System;

namespace Calculatrice
{
    public static class Calcul
    {
        public static Double Addition(Double nb1, Double nb2)
        {
            Double res = nb1 + nb2;
            return res;
        }
        public static Double Soustraction(Double nb1, Double nb2)
        {
            Double res = nb1 - nb2;
            return res;
        }
        public static Double Division(Double nb1, Double nb2)
        {
            Double res = nb1 / nb2;
            if (nb2 == 0)
                throw new DivideByZeroException("Le diviseur ne peut pas être zéro.");
            else
                return res;
        }
        public static Double Multiplication(Double nb1, Double nb2)
        {
            Double res = nb1 * nb2;
            return res;
        }
        public static Double Factorielle(Double nb1)
        {
            int nb = (int)nb1;
            if (nb1 != nb)
                throw new ArgumentException("Le nombre doit être un entier");
            int factorielle = 1;

            for(int counter = 1; counter <= nb; counter++)
            {
                factorielle *= counter;
            }
            return factorielle;
        }

        static long Factoriel(double n)
        {
            return (long)(n > 1 ? n * Factoriel(n - 1) : 1);
        }
    }
}
