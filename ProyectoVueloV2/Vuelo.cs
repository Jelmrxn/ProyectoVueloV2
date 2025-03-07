using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVueloV2
{
    public class Vuelo
    {
        public string Codigo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public int AsientosDisponibles { get; set; }

        public Vuelo(string codigo, string origen, string destino, DateTime fechaSalida, int asientosDisponibles)
        {
            Codigo = codigo;
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            AsientosDisponibles = asientosDisponibles;
        }

        public bool ReservarAsientos(int cantidad)
        {
            if (cantidad > AsientosDisponibles) return false;

            AsientosDisponibles -= cantidad;
            return true;  // Cambié esto de 'false' a 'true' para indicar que la reserva fue exitosa
        }
    }

    public class GestorVuelos
    {
        public List<Vuelo> ListaVuelos { get; private set; }

        public GestorVuelos()
        {
            ListaVuelos = new List<Vuelo>();
            CargarVuelosEjemplo();
        }


        //Vuelos ya predefinidos para que el usuario los pueda elegir
        private void CargarVuelosEjemplo()
        {
            ListaVuelos.Add(new Vuelo("V001", "Bogota", "Medellin", DateTime.Now.AddDays(1), 10));
            ListaVuelos.Add(new Vuelo("V002", "Medellin", "Cartagena", DateTime.Now.AddDays(2), 20));
            ListaVuelos.Add(new Vuelo("V003", "Cali", "Barranquilla", DateTime.Now.AddDays(3), 10));
        }


        //Agregar vuelo segun elección del usuario
        public void AgregarVuelo(Vuelo vuelo)
        {
            ListaVuelos.Add(vuelo);
        }

        public Vuelo BuscarVuelo(string codigo)
        {
            return ListaVuelos.FirstOrDefault(v => v.Codigo == codigo);
        }
    }
}
