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
    internal class Urukhai : Guerreiro, Humano, Monstro
    {
        public Urukhai(bool sociedadeDoAnel = false, int forca = 8, int agilidade = 6, int inteligencia = 3, int constituicao = 45) : base(sociedadeDoAnel, new AtributoForca(forca), new AtributoAgilidade(agilidade), new AtributoInteligencia(inteligencia), new AtributoConstituicao(constituicao))
        {
        }
        public void Envelhecer()
        {
            this.Constituicao -= 1;
        }

        public void Falar()
        {
            Console.WriteLine("Looks like meat's back on the menu boys!");
        }

        public void Grunir()
        {
            Console.WriteLine("Uuurrrrrr");
        }
    }
}
