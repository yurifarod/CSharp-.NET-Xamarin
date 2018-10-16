using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    public enum mes { zero, janeiro, fevereiro, marco, abril, maio, junho, julho, agosto, setembro, outubro, novembro, dezembro }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)mes.janeiro);
            Console.ReadKey();
        }
    }
}
