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
    public class Orc : Guerreiro, Monstro
    {
        public Orc(bool sociedadeDoAnel = false, int forca = 7, int agilidade = 6, int inteligencia = 1, int constituicao = 20) : base(sociedadeDoAnel, new AtributoForca(forca), new AtributoAgilidade(agilidade), new AtributoInteligencia(inteligencia), new AtributoConstituicao(constituicao))
        {
        }
        public void Grunir()
        {
            Console.WriteLine("Arrrggghhh");
        }

        public override String ToString()
        {
            return "O";
        }
    }
}
