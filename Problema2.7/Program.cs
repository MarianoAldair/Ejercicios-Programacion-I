using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sueldos = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el sueldo del empleado número " + (i + 1) + ".");
                double sueldo = int.Parse(Console.ReadLine());
                sueldos[i] = sueldo;
            }

            double[] sueldosAumentados = new double[5];

            for (int j = 0; j < 5; j++)
            {
                sueldosAumentados[j] = 0;
                sueldosAumentados[j] = sueldos[j] * 1.30;
            }

            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("El sueldo del empleado número " + (k + 1) + " con su aumento del 30% es de: $" + sueldosAumentados[k] + ".");
            }

            Console.ReadKey();
        }
    }
}
