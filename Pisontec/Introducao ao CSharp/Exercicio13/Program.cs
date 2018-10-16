using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            for (int i = 0; i < 10; i++)
            {
                vet[i] = i;
            }
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.ReadKey();

        }
    }
}
