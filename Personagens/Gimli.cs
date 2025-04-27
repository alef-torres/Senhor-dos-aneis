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
    internal class Gimli : Guerreiro, Anao
    {
        private int quantidadeDeBebidas = 0;
        public Gimli(bool sociedadeDoAnel = true, int forca = 9, int agilidade = 2, int inteligencia = 4, int constituicao = 60) : base(sociedadeDoAnel, new AtributoForca(forca), new AtributoAgilidade(agilidade), new AtributoInteligencia(inteligencia), new AtributoConstituicao(constituicao))
        {
        }
        public void Beber()
        {
            if (this.quantidadeDeBebidas >= 3)
            {
                Console.WriteLine("What did I say? He can't hold his liquor!");
            }
            else
            {
                this.quantidadeDeBebidas++;
                Falar();
            }
        }

        public void Falar()
        {
            Console.WriteLine("Let them come. There is one Dwarf yet in Moria who still draws breath.");
        }

        public override String ToString()
        {
            return "I";
        }
    }
}
