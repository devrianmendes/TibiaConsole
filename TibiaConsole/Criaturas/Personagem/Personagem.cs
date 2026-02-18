using criaturas;

namespace personagens
{
    internal abstract class Personagem : Criatura
    {
        public int ExperienciaAtual { get; set; } = 0;
        public int ExperienciaMaxima { get; set; } = 100;
        public int Nivel { get; set; }
        public int ManaAtual { get; protected set; }
        public int ManaMaxima { get; protected set; }


        protected abstract void BeneficiosNivelClasse();
        public void SubirNivel()
        {
            Nivel++;
            BeneficiosNivelClasse();
            Console.WriteLine($"Parabéns, seu novo nível é {Nivel}.");
            VidaAtual = VidaMaxima;
            ManaAtual = ManaMaxima;

        }
        protected void PerdeNivel()
        {

        }
        protected void PerdeVida()
        {

        }
        protected void GastaMana()
        {

        }
    }
}
