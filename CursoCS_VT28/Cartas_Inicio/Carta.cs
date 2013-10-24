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
            string result = string.Format("{0} of {1}", this.valor, this.palo);
			return result;
		}

        public Palo PaloBaraja()
        {
            return this.palo;
        }

        public Valor ValorBaraja()
        {
            return this.valor;
        }
	}
}