using SenhorDosAneis.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Classes
{
    internal class Mago : PersonagemBase
    {
        protected Mago(Boolean sociedadeDoAnel, AtributoForca forca, AtributoAgilidade agilidade, AtributoInteligencia inteligencia, AtributoConstituicao constituicao) : base(sociedadeDoAnel, forca, agilidade, inteligencia, constituicao)
        { }
        public override void Atacar()
        {
            throw new NotImplementedException();
        }

        public override void SofrerDano(int dano)
        {
            throw new NotImplementedException();
        }
    }
}
