using System;
using System.Collections.Generic;
using System.Text;

namespace criaturas.monstros
{
    internal class BlackKnight : Criatura
    {
        public BlackKnight() : base()
        {
            Nome = "Black Knight";
            Vida = 500;
            Mana = 200;
            EstiloCombate = EstiloCombate.Melee;
            Ataque = 15;
            Defesa = 12;
        }
    }
}
