using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._2
{
    internal class Silo
    {
        #region Atributos
        private int Altura;
        private int Radio;
        #endregion

        #region Métodos
        public string calcularVolumenMáximo()
        {
            double pi = 3.14;
            double volumen = pi * (Radio * Radio) * Altura;
            return "El volumen máximo del silo es de: " + volumen + " cm²";
        }
        #endregion

        #region Properties
        public int altura { get => Altura; set => Altura = value; }
        public int radio { get => Radio; set => Radio = value; }
        #endregion

        #region Constructora sin parámetros
        public Silo() { }
        #endregion

        #region Constructora con parámetros
        public Silo(int altura, int radio)
        {
            Altura = altura;
            Radio = radio;
        }
        #endregion


    }
}
