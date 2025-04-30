using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Excecoes
{
    public class PosicaoOcupadaException : Exception
    {
        public PosicaoOcupadaException(string message) : base(message) { }
    }
}
