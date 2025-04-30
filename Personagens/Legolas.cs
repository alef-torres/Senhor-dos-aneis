using SenhorDosAneis.Atributos;
using SenhorDosAneis.Classes;
using SenhorDosAneis.Racas;
using SenhorDosAneis.Simulacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Personagens
{
    public class Legolas : Arqueiro, Elfo
    {
        public Legolas(bool sociedadeDoAnel = true, int forca = 5, int agilidade = 10, int inteligencia = 6, int constituicao = 80) : base(sociedadeDoAnel, new AtributoForca(forca), new AtributoAgilidade(agilidade), new AtributoInteligencia(inteligencia), new AtributoConstituicao(constituicao))
        {
        }
        public void FalarElfico()
        {
            Console.WriteLine("I amar prestar aen, han mathon ne nem, han mathon ne chae, a han noston ned.");
        }

        public void Falar() 
        {
            Console.WriteLine("They're taking the Hobbits to Isengard!");
        }

        public override String ToString()
        {
            return "L";
        }
    }
}
