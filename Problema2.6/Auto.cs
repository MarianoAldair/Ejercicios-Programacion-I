using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._6
{
    internal class Auto
    {
        #region Atributos
        private string Marca;
        private string Modelo;
        private int Anio;
        private double Motor;
        private int CantidadPuertas;
        private double Combustible;
        private double Capacidad;
        private double Reserva;
        #endregion

        #region Properties
        public string marca { get => Marca; }
        public string modelo { get => Modelo; }
        public int anio { get => Anio; }
        public double motor { get => Motor; }
        public int cantidadPuertas { get => CantidadPuertas; }
        public double combustible { get => Combustible; set => Combustible = value; }
        public double capacidad { get => Capacidad; }
        public double reserva { get => Reserva; set => Reserva = value; }
        #endregion

        #region Métodos
        public string conducir(float kilometros)
        {
            float combustibleNecesario = kilometros / 11;
            if (combustibleNecesario <= Combustible + Reserva)
            {
                if (Combustible == 0) Reserva -= combustibleNecesario;
                else Combustible -= combustibleNecesario;
                return "Los kilómetros pueden ser recorridos. Usted aún dispone de " + Combustible.ToString("0.00") + " litros de combustible.";
            }
            else return "No es posible recorrer los kilómetros ingresados. El auto no dispone del combustible necesario.";
        }

        public string cargarCombustible(double litros)
        {
            double litrosDerramados = 0;
            while (litros > 0.00 && Combustible < Capacidad)
            {
                while (litros > 0.00 && Combustible < Capacidad)
                {
                    litros -= 0.01F;
                    Combustible += 0.01F;
                }
            }
            /*
            Este es un pequeño parche porque estuve mucho tiempo tratando de arreglar un pequeño problema.
            Invito a la persona que corrija este método, que borre las líneas xx y xx de código para que vea en consola
            el problema que intenté arreglar con el parche.
            Entiendo que mi ciclo while de la línea 51 está ingresando una vez más de lo que necesito,
            pero no supe cómo solucionarlo después de muchos intentos.
            */
            litros += 0.01F;
            Combustible -= 0.01F; 
            //Arriba de este comentario está el parche mencionado anteriormente.

            litrosDerramados = litros;
            return "Combustible recargado. En la recarga se derramaron " + litrosDerramados.ToString("0.00") + " litros. Ahora usted dispone de " + combustible.ToString("0.00") + " litros en su tanque y una reserva de " + reserva + " litros.";
        }
        #endregion

        #region Constructora
        public Auto(string marca, string modelo, int anio, double motor, int cantidadPuertas, double combustible)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Motor = motor;
            CantidadPuertas = cantidadPuertas;
            Combustible = combustible;
            Capacidad = 49;
            Reserva = 5;
        }
        #endregion

    }
}
