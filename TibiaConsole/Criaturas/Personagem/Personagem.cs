using System;

namespace criaturas
{
    internal abstract class Personagem : Criatura
    {
        //public Vocacoes vocacao { get; private set; }
        public int Experiencia { get; set; }
        public int Nivel { get; set; }
        public int Mana { get; protected set; }

        public decimal Magia { get; protected set; }


        public abstract void SubirNivel();
    }
}
