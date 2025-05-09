﻿using SenhorDosAneis.Atributos;
using SenhorDosAneis.Simulacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorDosAneis.Classes
{
    public class Mago : PersonagemBase
    {
        protected Mago(Boolean sociedadeDoAnel, AtributoForca forca, AtributoAgilidade agilidade, AtributoInteligencia inteligencia, AtributoConstituicao constituicao) : base(sociedadeDoAnel, forca, agilidade, inteligencia, constituicao)
        { }

        public override void SeMovimentarPeloMapa(Mapa mapa)
        {
            foreach (PersonagemBase p in mapa.Campo) 
            {
                if (p != null && p != this) 
                {
                  return;  
                }
            }
            mapa.MovimentarPersonagensNoCampo(1, this);
        }

        public override void Atacar(Mapa mapa)
        {
            int danoDoMago = this.Inteligencia;
            for (int i = 0; i < mapa.Campo.Count; i++) 
            {
                if (mapa.Campo[i] != null && mapa.Campo[i].FazParteDaSociedadeDoAnel != this.FazParteDaSociedadeDoAnel) 
                {
                    mapa.Campo[i].SofrerDano(danoDoMago);
                }
            }
        }

        public override void SofrerDano(int dano)
        {
            this.Constituicao = Constituicao - dano;
        }
    }
}
