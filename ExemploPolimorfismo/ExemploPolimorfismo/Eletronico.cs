using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    public abstract class Eletronico
    {
        public string nomeEletronico { get; set; }
        public string marcaEletronico { get; set; }
        public double precoEletronico { get; set; }
        public string corEletronico { get; set; }

        public Eletronico(string nomeEletronico, string marcaEletronico, double precoEletronico, string corEletronico)
        {
            this.nomeEletronico = nomeEletronico;
            this.marcaEletronico = marcaEletronico;
            this.precoEletronico = precoEletronico;
            this.corEletronico = corEletronico;
        }


        public abstract bool ligado(bool valor);



    }
}
