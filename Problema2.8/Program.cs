using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            double[] precios = new double[5];
            int[] cantidades = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del producto número " + (i + 1) + ".");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el precio unitario del producto número " + (i + 1) + ".");
                precios[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad comprada del producto número " + (i + 1) + ".");
                cantidades[i] = int.Parse(Console.ReadLine());
            }

            double totalInvertido = 0;
            double[] totales = new double[5];
            for(int j = 0; j < 5; j++)
            {
                totales[j] = precios[j] * cantidades[j];
                totalInvertido += totales[j];
                Console.WriteLine("Por el producto número " + (j + 1) + ", cuyo nombre es '" + nombres[j] + "', usted invirtió $" + totales[j].ToString("0.00") + " al comprar " + cantidades[j] + " unidades a un precio unitario de $" + precios[j].ToString("0.00") + " cada uno.");
            }

            Console.WriteLine("El total invertido fue de $" + totalInvertido.ToString("0.00") + ".");
            Console.ReadKey();
        }
    }
}
