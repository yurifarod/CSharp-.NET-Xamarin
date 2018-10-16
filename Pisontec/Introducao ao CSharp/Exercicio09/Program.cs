using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 200;
            int n2 = 100;
            if (n1 > n2)
            {
                Console.WriteLine("N1 maior");
            }
            else
            {
                Console.WriteLine("N2 maior");
            }

            int n3 = 3;
            switch (n3)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Valor não encontrado");
                    break;
            }

            string nome = "Flexa";
            switch (nome)
            {
                case "Gilmar":
                    Console.WriteLine("Gilmar Nunes");
                    break;
                case "Flexa":
                    Console.WriteLine("Rui Flexa");
                    break;
            }

            Console.ReadKey();
        }
    }
}
