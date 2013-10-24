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
            // TODO: tomar una carta al azar, eliminarla del pack, y devolverla
            throw new NotImplementedException("DealCardFromPack - TBD");
        }

        private bool EstaPaloVacio(Palo palo)
        {
            // TODO: devolver true si no hay más cartas disponibles en este palo
            throw new NotImplementedException("EstaPaloVacio - TBD");
        }

        private bool CartaYaRepartida(Palo palo, Valor valor)
        {
            // TODO: devolver true si esta carta ya ha sido repartida   
            throw new NotImplementedException("CartaYaRepartida - TBD");
        }
	}
}