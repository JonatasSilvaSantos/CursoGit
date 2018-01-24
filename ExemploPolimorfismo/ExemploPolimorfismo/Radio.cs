using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    public class Radio : Eletronico
    {
        public int watts { get; set; }

        public Radio(string nomeEletronico, string marcaEletronico, double precoEletronico, string corEletronico, int watts)
            :base(nomeEletronico, marcaEletronico, precoEletronico, corEletronico)
        {
            this.watts = watts;
        }
        
        public override bool ligado(bool valor)
        {
            if (valor == true)
                Console.WriteLine("Rádio ligado pelo botão");
            else
                Console.WriteLine("Rádio desligado");

            return valor;
        }


    }
}
