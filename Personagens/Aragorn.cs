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
    public class Aragorn : Guerreiro, Humano
    {
        public Aragorn(bool sociedadeDoAnel = true, int forca = 10, int agilidade = 6, int inteligencia = 7, int constituicao = 40) : base(sociedadeDoAnel, new AtributoForca(forca), new AtributoAgilidade(agilidade), new AtributoInteligencia(inteligencia), new AtributoConstituicao(constituicao))
        {
        }

        public void Envelhecer()
        {
            this.Constituicao -= 1;
        }

        public void Falar()
        {
            Console.WriteLine("A day may come when the courage of men fails… but it is not THIS day.");
        }

        public override String ToString() 
        {
            return "A";
        }
    }
}
