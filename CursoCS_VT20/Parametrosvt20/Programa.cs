#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parametros
{
    class Programa
    {
        static void hazTrabajo()
        {
             int i = 0;
             Console.WriteLine(i);
             Paso.Valor(ref i);
             Console.WriteLine(i);

            RodeaInt ri = new RodeaInt();
            Console.WriteLine(ri.Numero);
            Paso.Referencia(ri);
            Console.WriteLine(ri.Numero);
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