using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo raio1 = new Circulo();

            Console.Write("Insira o raio: ");
            raio1.parametro = double.Parse(Console.ReadLine());

            if (raio1.parametro < 0)
                Console.WriteLine("Impossível calcular valor negativo");
            else
                Console.WriteLine($"A área do Círculo é: {raio1.calculo(raio1.parametro)}");


            Console.WriteLine("\n");

            Quadrado lado1 = new Quadrado();

            Console.Write("Insira o valor do lado: ");
            lado1.parametro = double.Parse(Console.ReadLine());
            if (raio1.parametro < 0)
                Console.WriteLine("Impossível calcular valor negativo");
            else
                Console.WriteLine($"A área do Quadrado é: {lado1.calculo(lado1.parametro)}");

            Console.ReadKey();
        }
    }
}
