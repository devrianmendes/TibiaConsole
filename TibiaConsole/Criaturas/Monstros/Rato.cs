
using criaturas;

namespace monstros
{
    internal class Rato : Monstro
    {
        public Rato() : base()
        {
            Nome = "Rato";
            VidaMaxima = 20;
            VidaAtual = 20;
            Ataque = 5;
            Defesa = 2;
            Experiencia = 20;
        }
    }
}
