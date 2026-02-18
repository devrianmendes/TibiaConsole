using criaturas;

namespace monstros
{
    internal class Monstro : Criatura
    {
        public int Experiencia { get; protected set; }

        public override void ReceberDano(int dano)
        {
            VidaAtual -= dano;
            if (!EstaVivo())
            {
                
            }
        }


    }

}
