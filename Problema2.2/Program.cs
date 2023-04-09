using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Silo silo_uno = new Silo();
            silo_uno.altura = 250;
            silo_uno.radio = 74;
            Console.WriteLine("La altura del silo uno es de: " +  silo_uno.altura + " centímetros.");
            Console.WriteLine(silo_uno.calcularVolumenMáximo());
            Silo silo_dos = new Silo(325, 140);
            Console.WriteLine("El radio del silo dos es: " + silo_dos.radio + " centímetros.");
            Console.WriteLine(silo_dos.calcularVolumenMáximo());
        }
    }
}
