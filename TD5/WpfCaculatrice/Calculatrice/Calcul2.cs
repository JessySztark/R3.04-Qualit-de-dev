using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Calcul2
    {
        public Calcul2() { }

        public string Value { get; set; }

        private static Calcul2? _instance;

        private static readonly object _lock = new object();

        public static Calcul2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Calcul2();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
