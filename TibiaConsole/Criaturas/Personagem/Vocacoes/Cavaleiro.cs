using criaturas;

namespace personagens
{
    internal class Cavaleiro : Personagem
    {
        public Cavaleiro(string nome) : base() {
            Nome = nome;
            VidaMaxima = 180;
            VidaAtual = 180;
            ManaMaxima = 5;
            ManaAtual = 5;
            Ataque = 12;
            Defesa = 8;
            Nivel = 1;
        }

        protected override void BeneficiosNivelClasse()
        {
            VidaMaxima += 20;
            ManaMaxima += 10;
            Ataque += 5;
            Defesa += 1;
        }
    }
}
