using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Atributos
{
    public class AtributoConstituicao
    {
        private int constituicao;

        public AtributoConstituicao(int constituicao) 
        {
            if (!(constituicao < 0)) 
            {
                this.constituicao = constituicao;
            }
            
        }

        public int Constituicao 
        {
            get { return constituicao; }

            set
            {
                constituicao -= value;
                if (constituicao < 0)
                {
                    constituicao = 0;
                }
            }
        }
    }
}
