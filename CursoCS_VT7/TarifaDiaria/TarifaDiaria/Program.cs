using System;

namespace TarifaDiaria
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            //double tarifa = calcularTarifa();
            //double tarifa = calcularTarifa(435.23);
            //double tarifa = calcularTarifa(435.23, 5);
            //double tarifa = calcularTarifa(laTarifaDiaria: 312.2);
            //double tarifa = calcularTarifa(numDeDias: 5);
            double tarifa = calcularTarifa(tarifaDiaria: 312.2);
                      
            Console.WriteLine("Tarifa es {0}", tarifa);
        }

        /*private double calcularTarifa(double laTarifaDiaria = 500.0, int numDeDias = 1)
        {
            Console.WriteLine("calcular tarifa usando dos parámetros opcionales");
            return laTarifaDiaria * numDeDias;
        }*/

        private double calcularTarifa(double tarifaDiaria = 500.0, int numDeDias = 1)
        {
            Console.WriteLine("calcular tarifa usando dos parámetros opcionales");
            return tarifaDiaria * numDeDias;
        }

        private double calcularTarifa(double laTarifaDiaria = 500.0)
        {
            Console.WriteLine("calcular tarifa usando un parámetro opcional");
            int numDiasPorDefecto = 1;
            return laTarifaDiaria * numDiasPorDefecto;
        }

        private double calcularTarifa()
        {
            Console.WriteLine("calcular Tarifa usando valores de código duro");
            double tarifaDiariaPorDefecto = 400.0;
            int numDiasPorDefecto = 1;
            return tarifaDiariaPorDefecto * numDiasPorDefecto;
        }



    }
}
