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
        private static int contadorObjetos = 0;

        public Punto()
        {
            this.x = -1;
            this.y = -1;
            contadorObjetos++;
        }

        public Punto(int x, int y) // No escribirlo así
        {
            this.x = x;
            this.y = y;
            contadorObjetos++;
        }

        public double DistanciaA(Punto otro)
        {
            int xDif = this.x - otro.x;
            int yDif = this.y - otro.y;
            double distancia = Math.Sqrt((xDif * xDif) + (yDif * yDif));
            return distancia;
        }

        public static int ContadorObjetos()
        {
            return contadorObjetos;
        }

    }
}