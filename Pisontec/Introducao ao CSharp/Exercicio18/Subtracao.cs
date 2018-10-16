using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class Subtacao : Operacao
    {
        public override double calcular(double a, double b)
        {
            return a - b;
        }
    }
}
