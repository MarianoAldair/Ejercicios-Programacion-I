using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto punto_uno = new Punto();
            punto_uno.x = 3;
            punto_uno.y = 4;
            Console.WriteLine("El valor de X para el punto uno es: " + punto_uno.x + ".");
            Console.WriteLine(punto_uno.mostrarPunto());
            Punto punto_dos = new Punto(5, 2);
            Console.WriteLine("El valor de Y para el punto dos es: " + punto_dos.y + ".");
            Console.WriteLine(punto_dos.mostrarPunto());
        }
    }
}
