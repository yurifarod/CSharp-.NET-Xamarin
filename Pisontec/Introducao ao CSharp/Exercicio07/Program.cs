using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gilmar Mendes";
            string sobrenome = nome.Substring(7, 6);
            string segundonome = "Bruno";

            Console.WriteLine(nome.Contains("Gilmar"));

            Console.WriteLine(nome.Length);

            Console.WriteLine(sobrenome);

            Console.WriteLine(string.Concat(segundonome, " Leite"));

            string nomeTrim = "Cesar          ";
            Console.WriteLine(nomeTrim.TrimEnd());

            string exSplit = "C# C++ Python";
            string[] vet = exSplit.Split(' ');

            for(int i = 0; i < vet.Length; i++){
                Console.WriteLine(vet[i]);
            }

            string exSplitJoin = "C# C++ Python";
            string[] vetJoin = exSplitJoin.Split(' ');
            Console.WriteLine(String.Join(", ", vetJoin));

            Console.ReadKey();
        }
    }
}
