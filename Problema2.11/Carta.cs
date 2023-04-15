using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._11
{
    internal class Carta
    {
        #region Atributos
        private int Numero;
        private string Palo;
        private string Valor;
        #endregion

        #region Métodos propios
        #endregion

        #region Método constructor
        public Carta() { }
        public Carta(int numero, string palo)
        {
            Numero = numero;
            Palo = palo;
            Valor = Numero + " de " + Palo;
        }
        #endregion

        #region Properties
        public int numero { get => Numero; }
        public string palo { get => Palo; }
        public string valor { get => Valor; }
        #endregion
    }
}
