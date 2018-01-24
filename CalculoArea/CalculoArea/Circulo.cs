using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    public class Circulo : Area
    {
        public override double calculo(double raio)
        {
            return 3.14 * (raio * raio);
        }
    }
}
