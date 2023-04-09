using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._5
{
    public class Password
    {
        #region Atributos
        private int Longitud;
        private string Valor;
        #endregion

        #region Métodos
        public bool esFuerte()
        {
            int contadoraMay = 0, contadoraMin = 0, contadoraNum = 0;
            for (int i = 0; i < Valor.Length; i++)
            {
                if (char.IsUpper(Valor[i])) contadoraMay++;
                else if (char.IsLower(Valor[i])) contadoraMin++;
                else if (char.IsNumber(Valor[i])) contadoraNum++;
            }

            if (contadoraMay > 2 && contadoraMin > 1 && contadoraNum > 5) return true;
            else return false;
        }

        private string generarPassword()
        {
            //Resolución que no funciona:
            /*string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string cadena = "";
            for (int i = 0; i < Longitud; i++)
            {
                Random rand = new Random();
                int aux = rand.Next(62);
                cadena += caracteres[aux];
            }
            return cadena;*/

            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder cadena = new StringBuilder();
            Random random = new Random();
            for(int i = 0; i < Longitud; i++)
            {
                int index = random.Next(caracteres.Length);
                cadena.Append(caracteres[index]);
            }
            return cadena.ToString();
        }
        #endregion

        #region Properties
        public int longitud { get => Longitud; set => Longitud = value; }
        public string valor { get => Valor; }
        #endregion

        #region Constructora sin parámetros
        public Password() 
        {
            Longitud = 8;
            Valor = generarPassword();
        }
        #endregion

        #region Constructora con parámetros
        public Password(int longitud)
        {
            Longitud = longitud;
            Valor = generarPassword();
        }
        #endregion
    }
}
