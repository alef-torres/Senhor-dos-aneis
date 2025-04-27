using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Excecoes
{
    internal class PersonagemNaoEncontradoNoMapaException : Exception
    {
        public PersonagemNaoEncontradoNoMapaException(string message) : base(message) { }  
    }
}
