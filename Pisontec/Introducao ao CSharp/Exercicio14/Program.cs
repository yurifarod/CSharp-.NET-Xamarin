using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[4];
            for (int i = 4, j = 0; i > 0; i--, j++)
            {
                vet[j] = i;
            }
            Array.Sort(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.ReadKey();
        }
    }
}
