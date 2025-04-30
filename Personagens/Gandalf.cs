using SenhorDosAneis.Atributos;
using SenhorDosAneis.Classes;
using SenhorDosAneis.Racas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Personagens
{
    public class Gandalf : Mago, Maia
    {
        public Gandalf(bool sociedadeDoAnel = true, int forca = 2, int agilidade = 3, int inteligencia = 10, int constituicao = 80) : base(sociedadeDoAnel, new AtributoForca(forca), new AtributoAgilidade(agilidade), new AtributoInteligencia(inteligencia), new AtributoConstituicao(constituicao))
        {
        }
        public Maia Recucitar()
        {
            if (this.Constituicao == 0)
            {
                return new Gandalf();
            }
            return null;
        }

        public void Falar() 
        {
            Console.WriteLine("A Wizard is never late, nor is he early. He arrives precisely when he means to.");
        }
        
        public override String ToString()
        {
            return "G";
        }
    }
}
