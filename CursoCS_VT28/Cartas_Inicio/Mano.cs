using System;

namespace Cartas
{	
	class Mano
	{
        public const int TamMano = 10;
        private Carta[] cartas = new Carta[TamMano];
        private int contadorCartas = 0;

		public void AdCartaAMano(Carta repartirCarta)
		{
            // TODO: añadir la carta especificada a la mano
		}

		public override string ToString()
		{
			string resultado = "";
			foreach (Carta carta in this.cartas)
			{
				resultado += carta.ToString() + "\n";
			}

			return resultado;
		}
	}
}