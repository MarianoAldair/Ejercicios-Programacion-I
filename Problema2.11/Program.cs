using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creación de cartas.
            List<Carta> naipesEspañoles = new List<Carta>();
            naipesEspañoles.Add(new Carta(1, "Espadas"));
            naipesEspañoles.Add(new Carta(2, "Espadas"));
            naipesEspañoles.Add(new Carta(3, "Espadas"));
            naipesEspañoles.Add(new Carta(4, "Espadas"));
            naipesEspañoles.Add(new Carta(5, "Espadas"));
            naipesEspañoles.Add(new Carta(6, "Espadas"));
            naipesEspañoles.Add(new Carta(7, "Espadas"));
            naipesEspañoles.Add(new Carta(10, "Espadas"));
            naipesEspañoles.Add(new Carta(11, "Espadas"));
            naipesEspañoles.Add(new Carta(12, "Espadas"));
            naipesEspañoles.Add(new Carta(1, "Basto"));
            naipesEspañoles.Add(new Carta(2, "Basto"));
            naipesEspañoles.Add(new Carta(3, "Basto"));
            naipesEspañoles.Add(new Carta(4, "Basto"));
            naipesEspañoles.Add(new Carta(5, "Basto"));
            naipesEspañoles.Add(new Carta(6, "Basto"));
            naipesEspañoles.Add(new Carta(7, "Basto"));
            naipesEspañoles.Add(new Carta(10, "Basto"));
            naipesEspañoles.Add(new Carta(11, "Basto"));
            naipesEspañoles.Add(new Carta(12, "Basto"));
            naipesEspañoles.Add(new Carta(1, "Copas"));
            naipesEspañoles.Add(new Carta(2, "Copas"));
            naipesEspañoles.Add(new Carta(3, "Copas"));
            naipesEspañoles.Add(new Carta(4, "Copas"));
            naipesEspañoles.Add(new Carta(5, "Copas"));
            naipesEspañoles.Add(new Carta(6, "Copas"));
            naipesEspañoles.Add(new Carta(7, "Copas"));
            naipesEspañoles.Add(new Carta(10, "Copas"));
            naipesEspañoles.Add(new Carta(11, "Copas"));
            naipesEspañoles.Add(new Carta(12, "Copas"));
            naipesEspañoles.Add(new Carta(1, "Oro"));
            naipesEspañoles.Add(new Carta(2, "Oro"));
            naipesEspañoles.Add(new Carta(3, "Oro"));
            naipesEspañoles.Add(new Carta(4, "Oro"));
            naipesEspañoles.Add(new Carta(5, "Oro"));
            naipesEspañoles.Add(new Carta(6, "Oro"));
            naipesEspañoles.Add(new Carta(7, "Oro"));
            naipesEspañoles.Add(new Carta(10, "Oro"));
            naipesEspañoles.Add(new Carta(11, "Oro"));
            naipesEspañoles.Add(new Carta(12, "Oro"));
            #endregion

            #region Creo una baraja y le asigno las cartas creadas.
            Baraja barajaEspañola = new Baraja();
            barajaEspañola.cartas = naipesEspañoles;
            #endregion
            
            #region Muestro las cartas, barajo y vuelvo a mostrarlas.
            #region Ciclo for para mostrar todas las cartas y barajar.
            /*for (int i = 0; i < barajaEspañola.cantidadCartas; i++)
            {
                Console.WriteLine(barajaEspañola.cartas[i].valor);
            }
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.Barajar());
            Console.WriteLine("");*/
            #endregion
            #region Ciclo for para mostrar todas las cartas en su nuevo orden.
            /*for (int i = 0; i < barajaEspañola.cantidadCartas; i++)
            {
                Console.WriteLine(barajaEspañola.cartas[i].valor);
            }*/
            #endregion
            #endregion

            #region Pido y muestro todas.

            //Pido todas las cartas a través del método siguienteCarta()
            //y muestro la cantidad de cartas disponibles con el método cantidadCartas()
            /*Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            //Acá pido aunque no haya más cartas
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine(barajaEspañola.CartasDisponibles());*/

            #endregion

            #region Pido una cantidad específica de cartas y muestro la cantidad restante.

            /*Console.WriteLine(barajaEspañola.CartasMonton());
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.DarCartas(42));
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.DarCartas(3));
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.DarCartas(8));
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.DarCartas(11));
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.DarCartas(8));
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine(barajaEspañola.DarCartas(10));
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine("");*/

            #endregion

            #region Pido algunas cartas y muestro las cartas dadas.
            
            /*Console.WriteLine(barajaEspañola.CartasMonton());
            Console.WriteLine(barajaEspañola.DarCartas(10));
            Console.WriteLine(barajaEspañola.CartasMonton());
            Console.WriteLine(barajaEspañola.DarCartas(5));
            Console.WriteLine(barajaEspañola.CartasMonton());*/

            #endregion

            #region Muestro la baraja restante.
            //Console.WriteLine(barajaEspañola.MostrarBaraja());
            #endregion

            #region Prueba general de todos los métodos.

            /*for (int i = 0; i < barajaEspañola.cartas.Count; i++)
            {
                Console.WriteLine(barajaEspañola.cartas[i].valor);
            }

            Console.WriteLine("");

            Console.WriteLine(barajaEspañola.Barajar());

            Console.WriteLine("");

            for (int j = 0; j < barajaEspañola.cartas.Count; j++)
            {
                Console.WriteLine(barajaEspañola.cartas[j].valor);
            }

            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.SiguienteCarta());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.DarCartas(5));
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.DarCartas(5));
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.DarCartas(10));
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.CartasMonton());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.CartasDisponibles());
            Console.WriteLine("");
            Console.WriteLine(barajaEspañola.MostrarBaraja());
            Console.WriteLine("");*/
           
            #endregion

            Console.ReadKey();
        }
    }
}
