using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Atributos
{
    public class AtributoAgilidade
    {
        private int agilidade;

        public AtributoAgilidade(int agilidade) 
        {
            if (!(agilidade < 0)) 
            {
                this.agilidade = agilidade;
            }
        }
        public int Agilidade 
        { 
            get { return agilidade; }             
        }
    }
}
