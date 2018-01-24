using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    class Program
    {
        public static void Main(string[] args)
        {

            Radio r = new Radio("toca fita", "FOSTON", 45.90, "Prata", 70);

            r.ligado(true);

            Console.WriteLine("\n\n\n");

            Televisao t = new Televisao("TV OLD SCHOOL", "MAGNAVOX", 19, "AZUL BEBÊ", 15);

            t.ligado(true);


            Console.Write("Insira um numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine(t.teste(n1));
            Console.ReadKey();

            

        }
    }
}
