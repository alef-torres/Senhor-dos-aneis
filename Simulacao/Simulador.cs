using SenhorDosAneis.Atributos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Simulacao
{
    public class Simulador
    {
        private List<PersonagemBase> ExercitoSauron = new List<PersonagemBase>();
        private List<PersonagemBase> SociedadeDoAnel = new List<PersonagemBase>();
        public Simulador(Mapa mapa) 
        {
            Mapa = mapa;           
        }

        public Mapa Mapa { get; }

        private void SeparadorTimes() 
        {
            foreach(PersonagemBase p in Mapa.Campo) 
            {
                if(p != null) 
                {
                    if(p.FazParteDaSociedadeDoAnel) 
                    {
                        SociedadeDoAnel.Add(p);
                    }
                    if(!p.FazParteDaSociedadeDoAnel) 
                    {
                        ExercitoSauron.Add(p);
                    }
                }
            }
        }

        private void TurnoSociedade() 
        {
            foreach(PersonagemBase p in SociedadeDoAnel) 
            {
                p.Atacar(Mapa);
                p.SeMovimentarPeloMapa(Mapa);
            }
        }
        private void TurnoExercito() 
        {
            foreach(PersonagemBase p in  ExercitoSauron) 
            {
                p.Atacar(Mapa);
                p.SeMovimentarPeloMapa(Mapa);
            }   
        }

        private Boolean VerificarVitoriaSociedade() 
        {
            return SociedadeDoAnel.Any(p => p.PosicaoDoPersonagemNoMapa == 9); ;
        }

        private Boolean VerificarVitoriaExercito() 
        {
            return ExercitoSauron.All(p => p.Constituicao <= 0);
        }

        public void Simular() 
        {
            SeparadorTimes();
            while (true) 
            {
                TurnoSociedade();
                TurnoExercito();
                Mapa.RemovedorDePersonagensMortosNoCampo();
                if (VerificarVitoriaSociedade()) 
                {
                    break;
                }
                if (VerificarVitoriaExercito()) 
                {
                    break;
                }

            }
        }
    }
}
