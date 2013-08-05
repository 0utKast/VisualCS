#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Clases
{
    class Punto
    {
        private int x, y;

        public Punto()
        {
            this.x = -1;
            this.y = -1;
        }

        public Punto(int x, int y) // No escribirlo así
        {
            this.x = x;
            this.y = y;
        }

        public double DistanciaA(Punto otro)
        {
            int xDif = this.x - otro.x;
            int yDif = this.y - otro.y;
            double distancia = Math.Sqrt((xDif * xDif) + (yDif * yDif));
            return distancia;
        }

    }
}



