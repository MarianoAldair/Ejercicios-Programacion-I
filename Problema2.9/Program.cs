using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] ingresosMensuales = new double[4, 3];

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese los ingresos percibidos en el primer trimestre por la Sucursal número " + (i + 1) + ".");
                for(int j = 0; j < 3; j++)
                {
                    ingresosMensuales[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double[] totalesTrimestrales = new double[4];

            for(int k  = 0; k < 4; k++)
            {
                for (int  l = 0; l < 3; l++)
                {
                    totalesTrimestrales[k] += ingresosMensuales[k, l];
                } 
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("La Sucursal número " + (i + 1) + " recaudó $" + ingresosMensuales[i,j] + " en el mes " + (j + 1) + ".");
                }
            }

            Console.WriteLine("");
            
            for(int m = 0; m < 4; m++)
            {
                Console.WriteLine("La Sucursal número " + (m + 1) + " recaudó $" + totalesTrimestrales[m] + " en su primer trimestre." );
            }

            Console.ReadKey();
        }
    }
}
