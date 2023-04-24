using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._4
{
    //Clase Persona:
    public class Persona
    {
        #region Propiedades
        public string nombre { get => Nombre; set => Nombre = value; }
        public int edad { get => Edad; set => Edad = value; }
        public char sexo { get => Sexo; set => Sexo = value; }
        public float peso { get => Peso; set => Peso = value; }
        public double altura { get => Altura; set => Altura = value; }

        #endregion

        #region Atributos
        private string Nombre;
        private int Edad;
        private char Sexo;
        private float Peso;
        private double Altura;
        #endregion

        #region Constructor
        public Persona(string nombre, int edad, char sexo, float peso, double altura)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
        }
        #endregion

        #region Métodos
        public int calcularIMC()
        {
            double IMC = Peso / (Altura * Altura);
            int aux;
            if (IMC > 25) aux = 1;
            else if (IMC > 19) aux = 0;
            else aux = -1;
            return aux;
        }

        public bool esMayorDeEdad()
        {
            if (Edad > 21)
            return true;
            else return false;
        }
        #endregion
    }

    //Clase Program:
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Mariano = new Persona("Mariano", 24, 'M', 35, 1.75);
            //Pruebas en consola:
            Console.WriteLine("Probando la consola");
            Console.WriteLine("IMC de Mariano: " + Mariano.calcularIMC() + ".");
            Console.WriteLine("Mariano, ¿es mayor de edad? " + Mariano.esMayorDeEdad() + ".");
            Console.WriteLine("El sexo de Mariano es: " + Mariano.sexo + ".");
            Console.WriteLine("Mariano tiene " + Mariano.edad + " años.");
            Console.WriteLine("Mariano pesa " + Mariano.peso + " kilogramos.");
            //Creando otra instancia de la clase Persona y haciendo nuevas pruebas en consola:
            Persona Benjamin = new Persona("Benjamin", 15, 'M', 90, 1.78);
            Console.WriteLine("Probando la consola");
            Console.WriteLine("IMC de Benjamin: " + Benjamin.calcularIMC() + ".");
            Console.WriteLine("Benjamin, ¿es mayor de edad? " + Benjamin.esMayorDeEdad() + ".");
            Console.WriteLine("El sexo de Benjamin es: " + Benjamin.sexo + ".");
            Console.WriteLine("Benjamin tiene " + Benjamin.edad + " años.");
            Console.WriteLine("Benjamin pesa " + Benjamin.peso + " kilogramos.");
            //Creando otra instancia de la clase Persona y haciendo nuevas pruebas en consola:
            Persona Oriana = new Persona("Oriana", 23, 'F', 55, 1.60);
            Console.WriteLine("Probando la consola");
            Console.WriteLine("IMC de Oriana: " + Oriana.calcularIMC() + ".");
            Console.WriteLine("Oriana, ¿es mayor de edad? " + Oriana.esMayorDeEdad() + ".");
            Console.WriteLine("El sexo de Oriana es: " + Oriana.sexo + ".");
            Console.WriteLine("Oriana tiene " + Oriana.edad + " años.");
            Console.WriteLine("Oriana pesa " + Oriana.peso + " kilogramos.");
        }
    }
}
