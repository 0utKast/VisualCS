using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoTasa
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double tasaDiaria = leerDouble("Escribe tu tasa diaria: ");
            int numDeDias = leerInt("Escribe el número de días: ");
            escribirTarifa(calcularTarifa(tasaDiaria, numDeDias));

        }

        private void escribirTarifa(double p)
        {
            Console.WriteLine("La tarifa del consultor es: {0}", p * 1.1);
        }

        private double calcularTarifa(double tasaDiaria, int numDeDias)
        {
            return tasaDiaria * numDeDias;
        }

        private int leerInt(string p)
        {
            Console.Write(p);
            string linea = Console.ReadLine();
            return int.Parse(linea);
        }

        private double leerDouble(string p)
        {
            Console.Write(p);
            string linea = Console.ReadLine();
            return double.Parse(linea);
        }
    }
}
