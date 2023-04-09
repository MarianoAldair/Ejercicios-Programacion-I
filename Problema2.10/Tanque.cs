using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._10
{
    internal class Tanque
    {
        #region Atributos
        private string Nombre;
        private string PaisOrigen;
        private double Combustible;
        private double Capacidad;
        private double Reserva;
        private double CapacidadTotal;
        #endregion

        #region Método Constructor
        public Tanque() { }
        
        public Tanque(string nombre, string paisOrigen, double combustible, double capacidad, double reserva)
        {
            Nombre = nombre;
            PaisOrigen = paisOrigen;
            Combustible = combustible;
            Capacidad = capacidad;
            Reserva = reserva;
            CapacidadTotal = Capacidad + Reserva;
        }
        #endregion

        #region Métodos Propios
        #endregion

        #region Properties
        public string nombre { get => Nombre; }
        public string paisOrigen { get  => PaisOrigen; }
        public double combustible { get => Combustible; set => Combustible = value; }
        public double capacidad { get => Capacidad; }
        public double reserva { get => Reserva; set => Reserva = value; }
        public double capacidadTotal { get => CapacidadTotal; }
        #endregion
    }
}
