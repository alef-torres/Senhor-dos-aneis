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
    internal class Saruman : Mago, Maia
    {
        public Saruman(bool sociedadeDoAnel = false, int forca = 2, int agilidade = 2, int inteligencia = 9, int constituicao = 70) : base(sociedadeDoAnel, new AtributoForca(forca), new AtributoAgilidade(agilidade), new AtributoInteligencia(inteligencia), new AtributoConstituicao(constituicao))
        {
        }
        public Maia Recucitar()
        {
            throw new NotImplementedException();
        }

        public void Falar() 
        {
            Console.WriteLine("Against the power of Mordor there can be no victory.");
        }

        public override String ToString()
        {
            return "S";
        }
    }
}
