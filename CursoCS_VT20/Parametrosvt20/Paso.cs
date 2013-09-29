using System;

namespace Parametros
{
    class Paso
    {
        public static void Valor(ref int param)
        {
            param = 57;
        }

        public static void Referencia(RodeaInt param)
        {
            param.Numero = 57;
        }
    }
}