using SenhorDosAneis.Atributos;
using SenhorDosAneis.Racas;
using SenhorDosAneis.Simulacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Classes
{
    public abstract class Guerreiro : PersonagemBase
    {
        protected Guerreiro(Boolean sociedadeDoAnel, AtributoForca forca, AtributoAgilidade agilidade, AtributoInteligencia inteligencia, AtributoConstituicao constituicao) : base(sociedadeDoAnel, forca, agilidade, inteligencia, constituicao)
        { }

        public override void SeMovimentarPeloMapa(Mapa mapa) 
        {
            mapa.MovimentarPersonagensNoCampo(1, this);
        }

        public override void Atacar() 
        { }

        public override void SofrerDano(int dano) 
        { }
    }
}
