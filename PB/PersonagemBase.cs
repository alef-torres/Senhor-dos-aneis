using SenhorDosAneis.Simulacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Atributos
{
    public abstract class PersonagemBase
    {
        protected int posicaoDoPersonageNoMapa;
        protected Boolean fazParteDaSociedadeDoAnel;
        protected AtributoForca forca;
        protected AtributoAgilidade agilidade;
        protected AtributoInteligencia inteligencia;
        protected AtributoConstituicao constituicao;

        public PersonagemBase(Boolean sociedadeDoAnel, AtributoForca forca, AtributoAgilidade agilidade, AtributoInteligencia inteligencia, AtributoConstituicao constituicao) 
        {
            this.fazParteDaSociedadeDoAnel = sociedadeDoAnel;
            this.forca = forca;
            this.agilidade = agilidade;
            this.inteligencia = inteligencia;
            this.constituicao = constituicao;
        }
        
        public int PosicaoDoPersonagemNoMapa { get; set; }
        public Boolean FazParteDaSociedadeDoAnel
        {
            get { return this.fazParteDaSociedadeDoAnel; }
        }
        public int Forca { get { return this.forca.Forca; } }
        public int Agilidade { get { return this.agilidade.Agilidade; } }
        public int Inteligencia { get { return this.inteligencia.Inteligencia; } }
        public int Constituicao 
        { 
            get { return this.constituicao.Constituicao; }
            set { this.constituicao.Constituicao = value; }
        }

        public abstract void Atacar(Mapa mapa);
        public abstract void SofrerDano(int dano);
        public abstract void SeMovimentarPeloMapa(Mapa mapa);

    }
}
