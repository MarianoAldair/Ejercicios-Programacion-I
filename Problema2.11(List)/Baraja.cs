using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._11
{
    internal class Baraja
    {
        #region Atributos
        private List<Carta> Cartas;
        private int CantidadCartas;
        private List<Carta> MontonContenido;
        private int CantidadMontonContenido;
        private List<Carta> MontonDado;
        private int CantidadMontonDado;
        #endregion

        #region Métodos propios
        public string Barajar()
        {
            List<Carta> cartasParaBarajar = new List<Carta>();
            for (int i = 0; i < Cartas.Count; i++)
            {
                cartasParaBarajar.Add(Cartas[i]);
                //Console.WriteLine(cartasParaBarajar[i].valor);
            }

            List<Carta> cartasMezcladas = new List<Carta>();
            Random r = new Random();
            cartasMezcladas = cartasParaBarajar.OrderBy(_ => r.Next(0, Cartas.Count)).ToList();

            /*for (int i = 0;i < Cartas.Length;i++)
            {
                int RN = r.Next(0, cartasParaBarajar.Count - 1);
                Carta cartaSeleccionada = cartasParaBarajar[RN];
                if (cartasParaBarajar.Contains(cartaSeleccionada) && !cartasMezcladas.Contains(cartaSeleccionada))
                {
                    cartasMezcladas[i] = cartaSeleccionada;
                    cartasParaBarajar.Remove(cartaSeleccionada);
                } else
                {
                    
                }
            }*/

            Cartas = cartasMezcladas;
            return "Baraja mezclada.";
        }

        public string SiguienteCarta()
        {
            /*List<Carta> barajaRestante = new List<Carta>();
            for (int i = 0; i < Cartas.Length; i++)
            {
                barajaRestante.Add(Cartas[i]);
            }

            Carta ultimaCarta = barajaRestante[barajaRestante.Count - 1];
            CantidadCartas--;
            barajaRestante.RemoveAt(barajaRestante.Count - 1);
            return ultimaCarta.valor;*/

            if (cantidadCartas == 0) return "No hay más cartas.";
            Carta ultimaCarta = Cartas[CantidadCartas - 1];
            CantidadCartas--;
            Cartas.Remove(ultimaCarta);
            //MontonDado.Add(ultimaCarta);
            return ultimaCarta.valor;
        }

        public string CartasDisponibles()
        {
            return "La baraja dispone de " + CantidadCartas + " cartas.";
        }

        public string DarCartas(int n)
        {
            if (n > cantidadCartas) return "La baraja no posee tantas cartas";
            
            string[] cartasADevolver = new string[n];

            Random r = new Random();
            Carta cartaSeleccionada;
            for (int i = 0; i < n; i++)
            {
                cartaSeleccionada = Cartas[r.Next(0, Cartas.Count)];
                if(Cartas.Contains(cartaSeleccionada) && !cartasADevolver.Contains(cartaSeleccionada.valor))
                {
                    cartasADevolver[i] = cartaSeleccionada.valor;
                    CantidadCartas--;
                    Cartas.Remove(cartaSeleccionada);
                    MontonDado.Add(cartaSeleccionada);
                }
            }
            string cadenaADevolver = "";

            for(int j = 0; j <= cartasADevolver.Length; j++)
            {
                cadenaADevolver = String.Join(", ", cartasADevolver);
            }

            return cadenaADevolver;
        }

        public string CartasMonton()
        {
            if (montonDado.Count() == 0) return "Aún no se han dado cartas.";
            string[] cartasDadas = new string[MontonDado.Count];

            for(int i = 0; i < cartasDadas.Length; i++)
            {
                cartasDadas[i] = MontonDado[i].valor;
            }
            string dev;

            dev = String.Join(", ", cartasDadas);
            return dev;
        }

        public string MostrarBaraja()
        {
            string[] barajaRestante = new string[Cartas.Count];

            for (int i = 0; i < barajaRestante.Length; i++)
            {
                barajaRestante[i] = Cartas[i].valor;
            }

            string dev;

            dev = String.Join(", ", barajaRestante);
            return dev;
        }
        #endregion

        #region Método constructor
        public Baraja()
        {
            CantidadCartas = 40;
            MontonContenido = new List<Carta>();
            CantidadMontonContenido = MontonContenido.Count();
            MontonDado = new List<Carta>();
            CantidadMontonDado = MontonDado.Count();
    }

        public Baraja(List<Carta> carta)
        {
            List<Carta> Cartas = carta;
            CantidadCartas = carta.Count;
            MontonContenido = new List<Carta>();
            CantidadMontonContenido = MontonContenido.Count();
            MontonDado = new List<Carta>();
            CantidadMontonDado = MontonDado.Count();
        }
        #endregion

        #region Properties
        public List<Carta> cartas { get => Cartas; set => Cartas = value; }
        public int cantidadCartas { get => CantidadCartas; }
        public List<Carta> montonContenido { get => MontonContenido; }
        public int cantidadMontonContenido { get => CantidadMontonContenido; set => CantidadMontonContenido = value; }
        public List<Carta> montonDado { get => MontonDado; }
        public int cantidadMontonDado { get => CantidadMontonDado; set => CantidadMontonDado = value; }
        #endregion
    }
}
