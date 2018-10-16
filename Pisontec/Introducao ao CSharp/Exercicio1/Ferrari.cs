using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Ferrari : Carro
    {
        public Ferrari(int placa)
        {
            this.Placa = placa;
        }

        public override void ShowMsg()
        {
            Console.WriteLine("vrum vrum vrum, mais rapido");
        }

        /*public override void ShowMsg()
        {
            base.ShowMsg();
        }*/
    }
}
