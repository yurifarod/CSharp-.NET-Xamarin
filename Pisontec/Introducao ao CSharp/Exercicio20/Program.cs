using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    class Program
    {
        static void ExpressaoLambda()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 7, 9, 8, 10 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine(oddNumbers);
        }

        static void ExpressaoLambdaPratica()
        {
            var SelecoesMundiais = new ArrayList(new string[] { "USA", "Africa do Sul", "Mexico", "Brasil", "Uruguai" });

            var MelhorSelecao = from string p in SelecoesMundiais where p == "Brasil" select p;
            
            Console.WriteLine(MelhorSelecao);
        }
       
        static void Main(string[] args)
        {
            ExpressaoLambda();

            ExpressaoLambdaPratica();

            Console.ReadKey();
        }
    }
}
