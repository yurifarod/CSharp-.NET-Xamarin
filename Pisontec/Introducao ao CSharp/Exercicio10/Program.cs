using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, i = 1;
            do
            {
                soma += 1;
                i++;
            } while (i <= 10);
            
            Console.WriteLine(soma);

            Console.ReadKey();
        }


    }
}
