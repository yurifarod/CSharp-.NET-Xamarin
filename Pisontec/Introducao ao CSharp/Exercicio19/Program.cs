using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    class Program
    {
        static void BoxingUnbonxig()
        {
            int i = 123;
            object obj = i;

            obj = 123;
            i = (int)obj;

            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            BoxingUnbonxig();

            Console.ReadKey();
        }
    }
}
