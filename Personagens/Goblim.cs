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
    internal class Goblim : Arqueiro, Monstro
    {
        public Goblim(bool sociedadeDoAnel = false, int forca = 3, int agilidade = 6, int inteligencia = 1, int constituicao = 20) : base(sociedadeDoAnel, new AtributoForca(forca), new AtributoAgilidade(agilidade), new AtributoInteligencia(inteligencia), new AtributoConstituicao(constituicao))
        {
        }
        public void Grunir()
        {
            Console.WriteLine("Iiisshhhh");
        }

        public override String ToString()
        {
            return "M";
        }
    }
}
