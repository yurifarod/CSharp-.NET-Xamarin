using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void MostrarDados(string nome, int idade)
        {
            Console.WriteLine("Nome: {0} | Idade {1}", nome, idade);
        }

        static void MostrarNome(string nome = "Sem Nome")
        {
            Console.WriteLine(nome);
        }

        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Jose", 25);
            
            MostrarDados(pessoa.Nome, pessoa.Idade);

            MostrarNome();

            Carro carro = new Ferrari(4321);
            Console.WriteLine(carro.Placa);
            carro.ShowMsg();

            Console.ReadKey();

        }
    }
}
