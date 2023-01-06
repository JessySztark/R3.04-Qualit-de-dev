using System;

namespace Calculatrice
{
    public class Calcul : ICalcul
    {
        public Calcul() {}

        public string Value { get; set; }

        private static Calcul? _instance;

        private static readonly object _lock = new object();

        public static Calcul Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Calcul();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
