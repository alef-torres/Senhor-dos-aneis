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
    public class Boromir : Guerreiro, Humano
    {
        public Boromir(bool sociedadeDoAnel = true, int forca = 7, int agilidade = 6, int inteligencia = 3, int constituicao = 40) : base(sociedadeDoAnel, new AtributoForca(forca), new AtributoAgilidade(agilidade), new AtributoInteligencia(inteligencia), new AtributoConstituicao(constituicao))
        {
        }

        public void Envelhecer()
        {
            this.Constituicao -= 1;
        }

        public void Falar()
        {
            Console.WriteLine("One does not simply walk into Mordor.");
        }

        public override String ToString()
        {
            return "B";
        }
    }


}
