using System;

namespace Calculatrice
{
    public static class Calcul
    {
        public static void Addition(Double nb1, Double nb2, out Double res)
        {
            res = nb1 + nb2;
        }
        public static void Soustraction(Double nb1, Double nb2, out Double res)
        {
            res = nb1 - nb2;
        }
        public static void Division(Double nb1, Double nb2, out Double res)
        {
            res = nb1 / nb2;
            if (nb2 == 0)
                throw new DivideByZeroException("Le diviseur ne peut pas être zéro.");
        }
        public static void Multiplication(Double nb1, Double nb2, out Double res)
        {
            res = nb1 * nb2;
        }
        public static void Factorielle(Double nb1, out Double res)
        {
            res = 0;
            if (nb1 < 0)
                throw new ArgumentException("Le nombre ne peut pas être inférieur à zéro.");
            for (int i = 0;i < nb1; i++)
            {
                res *= i;
            }
        }
    }
}
