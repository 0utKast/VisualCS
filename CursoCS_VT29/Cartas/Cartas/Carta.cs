namespace Cartas
{
	class Carta
	{
        private readonly Palo palo;
        private readonly Valor valor;

		public Carta(Palo p, Valor v)
		{
			this.palo = p;
			this.valor = v;
		}

        public override string ToString()
		{
            string resultado = string.Format("{0} de {1}", this.valor, this.palo);
			return resultado;
		}

        public Palo PaloCarta()
        {
            return this.palo;
        }

        public Valor ValorCarta()
        {
            return this.valor;
        }
	}
}