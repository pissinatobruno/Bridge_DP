using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeEx
{
    public abstract class Abstracao
    {
        public Bridge Ponte { get; set; }

        public virtual void Operacao()
        {
            Console.WriteLine("Ponte:Operacao()");
            Ponte.OperacaoImplementada();
        }
    }
}
