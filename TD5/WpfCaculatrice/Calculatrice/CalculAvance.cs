using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class CalculAvance : ICalculAvance
    {

        public string Value { get; set; }

        private static CalculAvance _instance;

        private static readonly object _lock = new object();

        public static CalculAvance Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new CalculAvance();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
