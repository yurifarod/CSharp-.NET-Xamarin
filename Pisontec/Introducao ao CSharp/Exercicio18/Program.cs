using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class Program
    {
        public struct Carro
        {
            public string nome;
            public int ano;

        }

        static void Main(string[] args)
        {
            Soma soma = new Soma();
            Subtacao sub = new Subtacao();

            Console.WriteLine(soma.calcular(2, 3));
            Console.WriteLine(sub.calcular(2, 3));

            Entidade pessoa = new Pessoa();
            pessoa.setNome("Diga lá, Tino!");
            Console.WriteLine(pessoa.getNome());

            Carro c = new Carro();
            c.nome = "Ferrari";
            c.ano = 1985;

            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(31);
            lista.Add(141);
            
            foreach(int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
