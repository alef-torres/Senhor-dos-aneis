using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Atributos
{
    public class AtributoInteligencia
    {
        private int inteligencia;

        public AtributoInteligencia(int inteligencia)
        {
            if (!(inteligencia < 0)) 
            {
                this.inteligencia = inteligencia;
            }
        }

        public int Inteligencia 
        {
            get { return inteligencia; }
        }
    }
}
