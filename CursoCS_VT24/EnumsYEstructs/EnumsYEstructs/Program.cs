using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsYEstructs
{
    class Program
    {
        static void hacerTrabajo()
        {
            /*Mes primero = Mes.Diciembre;
            Console.WriteLine(primero);
            primero++;
            Console.WriteLine(primero);*/
            Fecha fechaDefecto = new Fecha();
            Console.WriteLine(fechaDefecto);
            Fecha fechaRecordar = new Fecha(2014, Mes.Septiembre,11);
            Console.WriteLine(fechaRecordar);


         
        }

        static void Main()
        {
            try
            {
                hacerTrabajo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}