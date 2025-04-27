using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Atributos
{
    public class AtributoForca
    {
        private int forca;

        public AtributoForca(int forca) 
        {           
            if (!(forca < 0))
            {
                this.forca = forca;
            }
        } 

        public int Forca 
        { get { return forca; } }

    }
}
