using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    public class Quadrado : Area
    {
        public override double calculo(double lado)
        {
            return lado * lado;
        }
    }
}
