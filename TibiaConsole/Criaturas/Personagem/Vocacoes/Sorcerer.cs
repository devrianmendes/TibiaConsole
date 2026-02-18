using criaturas;
using System;
using System.Collections.Generic;
using System.Text;

namespace criaturas
{
    internal class Sorcerer : Personagem
    {
        public Sorcerer(string nome) : base() {
            Nome = nome;
            VidaMaxima = 180;
            Mana = 90;
            EstiloCombate = EstiloCombate.Ranged;
            Ataque = 12;
            Magia = 6;
            Defesa = 8;
            Nivel = 1;
            Experiencia = 0;
        }

        public override void SubirNivel()
        {
            VidaMaxima += 5;
            Mana += 30;
            Ataque += 5m;
            Defesa += 0.5m;
        }

        public override void Curar()
        {
            CuraBasica(Magia);
        }
    }
}
