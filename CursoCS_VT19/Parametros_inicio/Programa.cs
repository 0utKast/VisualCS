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
            // TODO:
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
