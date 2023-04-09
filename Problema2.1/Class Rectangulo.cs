using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._1
{
    internal class Rectangulo
    {
        #region Atributos
        private int Base;
        private int Alto;
        #endregion

        #region Métodos
        public string calcularPerimetro()
        {
            int perimetro = (Base * 2) + (Alto * 2);
            return "El perímetro del rectángulo es: " + perimetro + " centímetros.";
        }

        public string calcularSuperficie()
        {
            int superficie = Base * Alto;
            return "La superficie del rectángulo es: " + superficie + "cm².";
        }
        #endregion

        #region Properties
        public int ladoBase { get => Base; set => Base = value; }
        public int alto { get => Alto ; set => Alto = value; }   
        #endregion

        #region Constructora sin parámetros
        public Rectangulo() { }
        #endregion

        #region Constructora con parámetros
        public Rectangulo(int ladoBase, int alto)
        {
            Base = ladoBase;
            Alto = alto;
        }
        #endregion

    }
}
