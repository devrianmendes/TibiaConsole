using System;
using System.Collections.Generic;
using System.Text;

namespace criaturas
{
    internal abstract class Criatura
    {
        //Propriedades
        public string Nome { get; protected set; }
        public int VidaMaxima { get; protected set; }
        public int VidaAtual { get; protected set; }
        public EstiloCombate EstiloCombate { get; protected set; }
        public decimal Ataque { get; protected set; }
        public decimal Defesa { get; protected set; }
        public int Cura { get; protected set; }


        public override string ToString()
        {
            return $"Nome: {Nome} - Vida total: {VidaAtual} de {VidaMaxima} - Combate: {EstiloCombate} - Ataque: {Ataque}";
        }
        //Métodos
        public void Atacar()
        {

        }

        public abstract void Curar();

    }
}
