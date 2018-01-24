using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public string Sexo { get; set; }

        public Pessoa(string nome, int idade, string cidade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Cidade = cidade;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return "Nome:" + Nome + "  Idade:" + Idade + " Cidade:" + Cidade + " Sexo:" + Sexo;
        }
    }

    class LPessoa : List<Pessoa>
    {
        public LPessoa()
        {
            this.Add(new Pessoa("JOSÉ SILVA", 21, "PIRACICABA", "M"));
            this.Add(new Pessoa("ADRIANA GOMES", 18, "CURITIBA","F"));
            this.Add(new Pessoa("JOSÉ TAVARES", 17, "CAMPINAS", "M"));
            this.Add(new Pessoa("ANDRÉ NEVES", 59, "PIRACICABA", "M"));
            this.Add(new Pessoa("IVANILDA RIBEIRO", 45, "RIO DE JANEIRO", "F"));
            this.Add(new Pessoa("ADELINO SILVA", 23, "SÃO PAULO", "M"));
            this.Add(new Pessoa("CLÉBER PINTO", 32, "CURITIBA", "M"));
            this.Add(new Pessoa("GUILHERME SOARES", 35, "JOÃO PESSOA", "M"));
            this.Add(new Pessoa("DOUGLAS COSTA", 25, "PRAIA GRANDE", "M"));

        }
    }
}
