using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Carro
    {
        public int Placa { get; set; }

        public virtual void ShowMsg()
        {
            Console.WriteLine("Vrum");
        }
        
    }
}
