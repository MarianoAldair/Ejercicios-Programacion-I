using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tanque XCA326 = new Tanque("XCA326", "Alemania", 49, 49, 5);
            Auto ChevroletCruze = new Auto("Chevrolet", "Cruze", 2022, 2.0, 5, XCA326);
            Console.WriteLine(ChevroletCruze.ChequearNivelCombustible());
            Console.WriteLine("Ahora mismo, ¿puede realizar un viaje de 680 kilómetros?");
            Console.WriteLine(ChevroletCruze.Conducir(680));
            Console.WriteLine(ChevroletCruze.ChequearNivelCombustible());
            Console.WriteLine("Ahora mismo, ¿puede realizar un viaje de 200 kilómetros?");
            Console.WriteLine(ChevroletCruze.Conducir(200));
            Console.WriteLine(ChevroletCruze.ChequearNivelCombustible());
            Console.WriteLine("Ahora mismo, ¿puede realizar un viaje de 80 kilómetros?");
            Console.WriteLine(ChevroletCruze.Conducir(80));
            Console.WriteLine(ChevroletCruze.ChequearNivelCombustible());
            Console.WriteLine("Ahora mismo, ¿puede realizar un viaje de 160 kilómetros?");
            Console.WriteLine(ChevroletCruze.Conducir(160));
            Console.WriteLine(ChevroletCruze.ChequearNivelCombustible());
            Console.WriteLine("Ahora mismo, ¿puede realizar un viaje de 100 kilómetros?");
            Console.WriteLine(ChevroletCruze.Conducir(100));
            Console.WriteLine(ChevroletCruze.ChequearNivelCombustible());
            Console.WriteLine("Ahora mismo, ¿puede realizar un viaje de 50 kilómetros?");
            Console.WriteLine(ChevroletCruze.Conducir(50));
            Console.WriteLine(ChevroletCruze.ChequearNivelCombustible());
            Console.WriteLine("Ahora mismo, ¿puede realizar un viaje de 20 kilómetros?");
            Console.WriteLine(ChevroletCruze.Conducir(20));
            Console.WriteLine(ChevroletCruze.ChequearNivelCombustible());
            Console.WriteLine("");
            Console.WriteLine("Hora de cargar combustible.");
            Console.WriteLine("");
            Console.WriteLine(ChevroletCruze.CargarCombustible(20));
            Console.WriteLine(ChevroletCruze.CargarCombustible(15));
            Console.WriteLine(ChevroletCruze.CargarCombustible(20));
            Console.WriteLine(ChevroletCruze.CargarCombustible(5));
            Console.ReadKey();
        }
    }
}
