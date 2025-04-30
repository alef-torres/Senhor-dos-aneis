using SenhorDosAneis.Atributos;
using SenhorDosAneis.Simulacao;
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
        public override void SeMovimentarPeloMapa(Mapa mapa)
        {
            mapa.MovimentarPersonagensNoCampo(1, this);
            mapa.MovimentarPersonagensNoCampo(1, this);
        }

        public override void Atacar(Mapa mapa)
        {
            int danoDoArqueiro = this.Agilidade;
            int posicaoDoInimigoMaisLonge;
            int aux = 0;
            
            if(this.FazParteDaSociedadeDoAnel) 
            {
                for (int i = 0; i < mapa.Campo.Count; i++) 
                {
                    if(mapa.Campo[i] != null) 
                    {
                        if (!mapa.Campo[i].FazParteDaSociedadeDoAnel)
                        {
                            posicaoDoInimigoMaisLonge = mapa.Campo[i].PosicaoDoPersonagemNoMapa;
                            if (aux < posicaoDoInimigoMaisLonge)
                            {
                                aux = posicaoDoInimigoMaisLonge;

                            }
                        }
                    }
                    
                }
                mapa.Campo[aux].SofrerDano(danoDoArqueiro);
            }

            if (!this.FazParteDaSociedadeDoAnel)
            {
                for (int i = mapa.Campo.Count; i > 0; i--)
                {
                    if (mapa.Campo[i] != null)
                    {
                        if (mapa.Campo[i].FazParteDaSociedadeDoAnel)
                        {
                            posicaoDoInimigoMaisLonge = mapa.Campo[i].PosicaoDoPersonagemNoMapa;
                            if (aux < posicaoDoInimigoMaisLonge)
                            {
                                aux = posicaoDoInimigoMaisLonge;

                            }
                        }
                    }

                }
                mapa.Campo[aux].SofrerDano(danoDoArqueiro);
            }
        }

        public override void SofrerDano(int dano)
        {
            this.Constituicao = Constituicao - dano;
        }
    }
}
