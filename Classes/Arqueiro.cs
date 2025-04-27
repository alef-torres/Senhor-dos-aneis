using SenhorDosAneis.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Classes
{
    public abstract class Arqueiro : PersonagemBase
    {
        protected Arqueiro(Boolean sociedadeDoAnel, AtributoForca forca, AtributoAgilidade agilidade, AtributoInteligencia inteligencia, AtributoConstituicao constituicao) : base(sociedadeDoAnel, forca, agilidade, inteligencia, constituicao)
        {
        }

        public override void Atacar()
        {
            
        }

        public override void SofrerDano(int dano)
        {
            
        }
    }
}
