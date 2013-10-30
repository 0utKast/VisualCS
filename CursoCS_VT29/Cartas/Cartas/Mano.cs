using System;

namespace Cartas
{
	class Mano
	{
        public const int TamMano = 10;
        private Carta[] cartas = new Carta[TamMano];
        private int contadorCartas = 0;

		public void AdcartaAMano(Carta cardDealt)
		{
            if (this.contadorCartas >= TamMano)
            {
                throw new ArgumentException("Demasiadas Cartas");
            }
            this.cartas[this.contadorCartas] = cardDealt;
            this.contadorCartas++;
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