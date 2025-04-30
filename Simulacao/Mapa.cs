using SenhorDosAneis.Atributos;
using SenhorDosAneis.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Simulacao
{
    public class Mapa
    {

        private List<PersonagemBase> campo = new List<PersonagemBase>(10);

        public Mapa() 
        {
            PrenchedorDoMapa();
        }

        public List<PersonagemBase> Campo { get { return campo; } }

        private void PrenchedorDoMapa() 
        {
            int tamanhoMaximoMapa = 10;

            while (campo.Count < tamanhoMaximoMapa)
            {
                campo.Add(null);
            }
        }

        public void RemovedorDePersonagensMortosNoCampo() 
        {
            for (int i = 0; i < campo.Count; i++) 
            {
                if (campo[i] != null && campo[i].Constituicao <= 0) 
                {
                    campo[i] = null; 
                }
            }
        }

        public String ExibirMapa() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('|');
            for (int i = 0; i < campo.Capacity; i++)
            {
                if (campo[i] == null)
                {
                    sb.Append(' ');  
                }
                else
                {
                    sb.Append(campo[i].ToString());  
                }

                if (i < campo.Capacity - 1)
                {
                    sb.Append('|');
                }
            }
            sb.Append('|');  

            return sb.ToString();

        }

        public void InserirPersonagensNoMapa(int posicao, PersonagemBase personagem)
        {
            int posicaoRealNaLista = posicao;

            if(posicaoRealNaLista < 0 || posicaoRealNaLista > 9) 
            {
                throw new ArgumentOutOfRangeException("Posição inválida. Deve ser entre 1 e 10.");
            }
            
            foreach (PersonagemBase p in campo)
            {
                if (p == personagem)
                {
                    throw new PersonagemJaEstaNoMapaException("");
                }
            }
    
            if (campo[posicaoRealNaLista] == null)
            {
                campo[posicaoRealNaLista] = personagem;
                personagem.PosicaoDoPersonagemNoMapa = posicaoRealNaLista;
            } else 
            {
                throw new PosicaoOcupadaException("");
            }

        }

        public Boolean BuscarPosicaoNoMapa(int posicao) 
        {
            int posicaoRealNaLista = posicao - 1;

            if (posicaoRealNaLista < 0 || posicaoRealNaLista > 9)
            {
                throw new ArgumentOutOfRangeException("Posição inválida. Deve ser entre 1 e 10.");
            }
          
            if (campo[posicaoRealNaLista] != null)
                {
                    return true;
                }                                        
            return false;
        }

        public void MovimentarPersonagensNoCampo(int quantidadeMovimentos, PersonagemBase personagem) 
        {
            if (!personagem.FazParteDaSociedadeDoAnel)
            {
                quantidadeMovimentos = - quantidadeMovimentos;
            }

            int posicaoAtual = personagem.PosicaoDoPersonagemNoMapa;
            int novaPosicao = posicaoAtual + quantidadeMovimentos;

            if (novaPosicao >= campo.Count || novaPosicao < 0)
            {
                return;
            }

            if (campo[novaPosicao] != null) 
            {
                return;
            }

            campo[posicaoAtual] = null;

            personagem.PosicaoDoPersonagemNoMapa = novaPosicao;

            campo[novaPosicao] = personagem;

        }
    } 
}
