using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._10
{
    internal class Auto
    {
        #region Atributos
        private string Marca;
        private string Modelo;
        private int Anio;
        private double Motor;
        private int CantidadPuertas;
        private Tanque Tanque;
        #endregion

        #region Properties
        public string marca { get => Marca; }
        public string modelo { get => Modelo; }
        public int anio { get => Anio; }
        public double motor { get => Motor; }
        public int cantidadPuertas { get => CantidadPuertas; }
        public Tanque tanque { get => Tanque; }
        #endregion

        #region Métodos

        public string Conducir(float kilometros)
        {
            return Tanque.Conducir(kilometros);
        }

        public string CargarCombustible(double litros)
        {
            return Tanque.CargarCombustible(litros);
        }

        public string ChequearNivelCombustible()
        {
            return Tanque.ChequearNivelCombustible();
        }
        #endregion

        #region Constructora
        public Auto(string marca, string modelo, int anio, double motor, int cantidadPuertas, Tanque tanque)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Motor = motor;
            CantidadPuertas = cantidadPuertas;
            Tanque = tanque;
        }
        #endregion

    }
}
