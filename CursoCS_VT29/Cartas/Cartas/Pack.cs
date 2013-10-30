using System;

namespace Cartas
{	
	class Pack
	{
        public const int NumPalos = 4;
        public const int CartasPorPalo = 10;
        private Carta[,] packCarta;
        private Random selectorCartaRandom = new Random();

		public Pack()
		{
            this.packCarta = new Carta[NumPalos, CartasPorPalo];

            for (Palo palo = Palo.Oros; palo <= Palo.Bastos; palo++)
            {
                for (Valor valor = Valor.Dos; valor <= Valor.As; valor++)
                {
                    this.packCarta[(int)palo, (int)valor] = new Carta(palo, valor);
                }
            }
		}

        public Carta RepartirCartaDePack()
        {
            Palo palo = (Palo)selectorCartaRandom.Next(NumPalos);

            while (this.EstaPaloVacio(palo))
            {
                palo = (Palo)selectorCartaRandom.Next(NumPalos);
            }

            Valor valor = (Valor)selectorCartaRandom.Next(CartasPorPalo);
            while (this.EsCartaYaRepartida(palo, valor))
            {
                valor = (Valor)selectorCartaRandom.Next(CartasPorPalo);
            }

            Carta card = this.packCarta[(int)palo, (int)valor];
            this.packCarta[(int)palo, (int)valor] = null;
            return card;
        }

        private bool EstaPaloVacio(Palo palo)
        {
            bool result = true;
            for (Valor value = Valor.Dos; value <= Valor.As; value++)
            {
                if (!EsCartaYaRepartida(palo, value))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private bool EsCartaYaRepartida(Palo palo, Valor valor)
        {
            return (this.packCarta[(int)palo, (int)valor] == null);
        }
	}
}