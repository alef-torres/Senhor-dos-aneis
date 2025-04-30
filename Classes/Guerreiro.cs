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

        public override void Atacar(Mapa mapa) 
        {
            int posGuerreiro = this.PosicaoDoPersonagemNoMapa;
            int danoDoGuerreiro = this.Forca * 2;
            int posicaoInimigo;
            if (mapa.Campo[posGuerreiro + 1] != null) 
            {
                if (mapa.Campo[posGuerreiro + 1].FazParteDaSociedadeDoAnel != this.FazParteDaSociedadeDoAnel) 
                {
                    posicaoInimigo = posGuerreiro + 1;
                    mapa.Campo[posicaoInimigo].SofrerDano(danoDoGuerreiro);
                }
            }
            if (mapa.Campo[posGuerreiro - 1] != null)
            {
                if (mapa.Campo[posGuerreiro - 1].FazParteDaSociedadeDoAnel != this.FazParteDaSociedadeDoAnel)
                {
                    posicaoInimigo = posGuerreiro - 1;
                    mapa.Campo[posicaoInimigo].SofrerDano(danoDoGuerreiro);
                }
            }

        }

        public override void SofrerDano(int dano) 
        {
            this.Constituicao = Constituicao - dano;
        }
    }
}
