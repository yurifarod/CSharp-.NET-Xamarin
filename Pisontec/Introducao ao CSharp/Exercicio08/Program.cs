using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static int somar(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            const int n = 2019;
            Console.WriteLine(n);

            Console.WriteLine(somar(3, 5));


            Console.ReadKey();
        }
    }
}
