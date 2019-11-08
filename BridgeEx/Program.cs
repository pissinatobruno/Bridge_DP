using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstracao ab = new AbstracaoExtendida();

            ab.Ponte = new PadraoA();
            ab.Operacao();

            ab.Ponte = new PadraoB();
            ab.Operacao();

            Console.ReadKey();
        }
    }
}
