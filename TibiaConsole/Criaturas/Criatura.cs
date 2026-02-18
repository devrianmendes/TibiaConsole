namespace criaturas
{
    internal abstract class Criatura
    {
        //Propriedades
        public string Nome { get; protected set; }
        public int VidaMaxima { get; protected set; }
        public int VidaAtual { get; protected set; }
        public int Ataque { get; protected set; }
        public int Defesa { get; protected set; }
        public int Cura { get; protected set; }


        public override string ToString()
        {
            return $"Nome: {Nome} - Vida total: {VidaMaxima} - Vida atual: {VidaAtual} - Ataque: {Ataque} - Defesa: {Defesa}";
        }


        //Métodos
        public virtual void CausarDano(Criatura criaturaAlvo)
        {
            criaturaAlvo.ReceberDano(this.Ataque);
        }

        public virtual void ReceberDano(int dano)
        {
            VidaAtual -= dano;
            if(VidaAtual < 1)
            {
                Morrer();
            }
        }

        protected virtual void Morrer()
        {

        }

    }
}
