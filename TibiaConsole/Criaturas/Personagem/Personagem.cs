using criaturas;

namespace personagens
{
    internal abstract class Personagem : Criatura
    {
        public int ExperienciaAtual { get; set; } = 0;
        public int ExperienciaMaxima { get; set; } = 100;
        public int Nivel { get; set; }
        public int Mana { get; protected set; }
        public decimal Magia { get; protected set; }


        protected void SubirNivel()
        {

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
        protected void SubirMagia()
        {

        }
    }
}
