using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Excecoes
{
    public class PersonagemJaEstaNoMapaException : Exception
    {
        public PersonagemJaEstaNoMapaException(string message) : base(message) { }
    }
}
