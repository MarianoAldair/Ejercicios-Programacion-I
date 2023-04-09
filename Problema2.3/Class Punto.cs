using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._3
{
    internal class Punto
    {
        #region Atributos
        private int X;
        private int Y;
        #endregion

        #region Métodos
        public string distanciaAlEje()
        {
            double distancia = Math.Sqrt((X * X) + (Y * Y));
            return "La distancia del punto con el origen del eje es: " + distancia + ".";
        }

        public string mostrarPunto()
        {
            return "(" + X + ";" + Y + ").";
        }
        #endregion

        #region Properties
        public int x { get => X; set => X = value; } 
        public int y { get => Y; set => Y = value; }
        #endregion

        #region Constructora sin parámetros
        public Punto() { }
        #endregion

        #region Constructora con parámetros
        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion
    }
}
