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
        public string Conducir(float kilometros)
        {
            string respuesta = "No es posible recorrer los kilómeotros ingresados. El tanque no dispone del combustible necesario.";
            float combustibleNecesario = kilometros / 11;
            /*if (combustibleNecesario <= tanque.capacidadTotal)
            {
                if (tanque.combustible == 0) tanque.reserva -= combustibleNecesario;
                else tanque.combustible -= combustibleNecesario;
                return "Los kilómetros pueden ser recorridos. Usted dispone de " + tanque.combustible.ToString("0.00") + " litros de combustible.";
            }
            else return "No es posible recorrer los kilómetros ingresados. El tanque no dispone del combustible necesario.";*/
            if (combustibleNecesario < CapacidadTotal)
            {
                if (combustibleNecesario < Combustible)
                {
                    Combustible -= combustibleNecesario;
                    respuesta = "Los kilómetros pueden ser recorridos. Usted dispone de " + Combustible.ToString("0.00") + " litros de combustible y una reserva de " + Reserva.ToString("0.00") + " litros.";
                }
                else if (combustibleNecesario < Combustible + Reserva)
                {
                    while (Combustible > 0.00F)
                    {
                        combustibleNecesario -= 0.01F;
                        Combustible -= 0.01F;
                    }
                    //tanque.combustible += 0.01F; 

                    while (combustibleNecesario > 0)
                    {
                        combustibleNecesario -= 0.01F;
                        Reserva -= 0.01F;
                    }
                    respuesta = "Los kilómetros pueden ser recorridos. Usted dispone de " + Combustible.ToString("0.00") + " litros de combustible y una reserva de " + Reserva.ToString("0.00") + " litros.";
                }
            }
            return respuesta;
        }

        public string CargarCombustible(double litros)
        {
            double litrosDerramados = 0;
            /*while (litros > 0.00 && tanque.combustible < tanque.capacidad)
            {
                while (litros > 0.00 && tanque.combustible < tanque.capacidad)
                {
                    litros -= 0.01F;
                    tanque.combustible += 0.01F;
                }
            }*/
            /*
            Este es un pequeño parche porque estuve mucho tiempo tratando de arreglar un pequeño problema.
            Invito a la persona que corrija este método, que borre las líneas xx y xx de código para que vea en consola
            el problema que intenté arreglar con el parche.
            Entiendo que mi ciclo while de la línea 51 está ingresando una vez más de lo que necesito,
            pero no supe cómo solucionarlo después de muchos intentos.
            */
            //litros += 0.01F;
            //tanque.combustible -= 0.01F;
            //Arriba de este comentario está el parche mencionado anteriormente.

            if (Reserva < 5)
            {
                while (Reserva < 5)
                {
                    litros -= 0.01F;
                    Reserva += 0.01F;
                }

                while (Combustible < 49 && litros > 0)
                {
                    litros -= 0.01F;
                    Combustible += 0.01F;
                }

            }
            else
            {
                while (Combustible < 49 && litros > 0)
                {
                    litros -= 0.01F;
                    Combustible += 0.01F;
                }
            }

            //Mismo parche
            litros += 0.01F;
            Combustible -= 0.01F;

            litrosDerramados = litros;
            return "Combustible recargado. En la recarga se derramaron " + litrosDerramados.ToString("0.00") + " litros. Ahora usted dispone de " + Combustible.ToString("0.00") + " litros en su tanque y una reserva de " + Reserva.ToString("0.00") + " litros.";
        }

        public string ChequearNivelCombustible()
        {
            string alerta = "Tanque ocupado sobre el 75%";
            double porcentajeActual = (Combustible * 100) / 49;
            if (Combustible + Reserva == CapacidadTotal) alerta = "Tanque al 100%";
            else if (Combustible < 0.01) alerta = "¡ALERTA! Usted no tiene combustible, está conduciendo en reserva. Cargue combustible lo antes posible.";
            else if (porcentajeActual <= 25) alerta = "Usted posee el 25% o menos del tanque lleno.";
            else if (porcentajeActual <= 50) alerta = "Usted posee el 50% o menos del tanque lleno.";
            else if (porcentajeActual <= 75) alerta = "Usted posee el 75% o menos del tanque lleno.";
            return alerta;

            /*
            Esta es una propuesta que muestra el porcentaje exacto de combustible que el tanque posee:
            string alerta = "Tanque ocupado sobre el 75%";
            double porcentajeActual = (tanque.combustible * 100) / 49;
            if (tanque.combustible + tanque.reserva == tanque.capacidadTotal) alerta = "Tanque al 100%";
            else if (tanque.combustible < 0.01) alerta = "¡ALERTA! Usted no tiene combustible, está conduciendo en reserva. Cargue combustible lo antes posible";
            else if (porcentajeActual <= 25) alerta = porcentajeActual.ToString("0.00") + "% del tanque lleno.";
            else if (porcentajeActual <= 50) alerta = porcentajeActual.ToString("0.00") + "% del tanque lleno.";
            else if (porcentajeActual <= 75) alerta = porcentajeActual.ToString("0.00") + "% del tanque lleno.";
            return alerta;
            */
        }

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
