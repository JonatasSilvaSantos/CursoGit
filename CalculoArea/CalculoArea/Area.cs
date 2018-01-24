using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    public abstract class Area
    {
        public double parametro { get; set; }

        public abstract double calculo(double valor);

    }
}
