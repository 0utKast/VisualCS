#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Clases
{
    class Programa
    {
        static void hazTrabajo()
        {
            Punto origen = new Punto();
            Punto abajoDerecha = new Punto(1024, 768);
            double distancia = origen.DistanciaA(abajoDerecha);
            Console.WriteLine("Distancia es: {0}", distancia);

        }

        static void Main(string[] args)
        {
            try
            {
                hazTrabajo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

