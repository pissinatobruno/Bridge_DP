using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeEx
{
    public class AbstracaoExtendida : Abstracao
    {
        public override void Operacao()
        {
            //Console.WriteLine("AbstracaoExtendida:Operacao()");
            Ponte.OperacaoImplementada();
        }
    }
}
