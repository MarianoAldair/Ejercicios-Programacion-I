using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password password_uno;

            Console.WriteLine("Ingrese el largo del password:");
            int largo = int.Parse(Console.ReadLine());
            password_uno = new Password(largo);
            Console.WriteLine("La contraseña número uno es: " + password_uno.valor + ".");
            Console.WriteLine("¿Es fuerte? " + password_uno.esFuerte() + ".");
        }
    }
}
