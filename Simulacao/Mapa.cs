using SenhorDosAneis.Atributos;
using SenhorDosAneis.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Simulacao
{
    public class Mapa
    {

        protected List<PersonagemBase> personages = new List<PersonagemBase>(10);

        private void PrenchedorDoMapa() 
        {
            int tamanhoMaximoMapa = 10;

            while (personages.Count < tamanhoMaximoMapa)
            {
                personages.Add(null);
            }
        }

        public String ExibirMapa() 
        {
            PrenchedorDoMapa();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < personages.Capacity; i++)
            {
                if (personages[i] == null)
                {
                    sb.Append(' ');  
                }
                else
                {
                    sb.Append(personages[i].ToString());  
                }

                if (i < personages.Capacity - 1)
                {
                    sb.Append('|');
                }
            }

            sb.Append('|');  

            return sb.ToString();

        }

        public void Inserir(int posicao, PersonagemBase personagem) 
        {
            int posicaoRealNaLista = posicao - 1;

            PrenchedorDoMapa();

            foreach (PersonagemBase p in  personages) 
            {
                if (p == personagem) 
                {
                    throw new PersonagemJaEstaNoMapaException("");
                }
            }

            try
            {
                if (personages[posicaoRealNaLista] == null)
                {
                    personages[posicaoRealNaLista] = personagem;
                    personagem.PosicaoDoPersonagemNoMapa = posicaoRealNaLista;
                }
            }
            catch (PersonagemNaoEncontradoNoMapaException ex) 
            {
                Console.WriteLine("Posição já ocupada {0}", ex);
            }
        }

    }
}
