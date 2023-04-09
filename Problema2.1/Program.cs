using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo_uno = new Rectangulo();
            rectangulo_uno.ladoBase = 6;
            rectangulo_uno.alto = 11;
            Console.WriteLine(rectangulo_uno.calcularPerimetro());
            Console.WriteLine(rectangulo_uno.calcularSuperficie());
            Rectangulo rectangulo_dos = new Rectangulo(7, 13);
            Console.WriteLine(rectangulo_dos.calcularPerimetro());
            Console.WriteLine(rectangulo_dos.calcularSuperficie());
        }
    }
}
