using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    public class Televisao : Eletronico
    {
        public int polegadas { get; set; }

        public Televisao(string nomeEletronico, string marcaEletronico, double precoEletronico, string corEletronico, int polegadas)
            : base(nomeEletronico, marcaEletronico, precoEletronico, corEletronico)
        {
            this.polegadas = polegadas;
        }

        public override bool ligado(bool valor)
        {
            if (valor == true)
                Console.WriteLine("Televisão ligada pelo controle!");
            else
                Console.WriteLine("Televisão desligada!");

            return valor;
        }

        public double teste(double valor)
        {
            if ((valor * valor) < 10)
                Console.WriteLine("O numero é menor q 10");
            else
                Console.WriteLine("O numero é maior q 10");
            return valor;

             
        }

    }
}
