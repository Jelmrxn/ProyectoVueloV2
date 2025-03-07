using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVueloV2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void VuelosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<Vuelo> listaVuelos = new List<Vuelo>(); // Lista de vuelos disponible



        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoVuelo.Text;
            string origen = txtOrigen.Text;
            string destino = txtDestino.Text;
            DateTime fechaSalida = dtpFechaSalida.Value;
            int asientos;

            // Validar si la cantidad de asientos es válida (mayor que 0)
            if (int.TryParse(txtAsientosDisponibles.Text, out asientos) && asientos > 0)
            {
                // Crear un nuevo vuelo con los datos proporcionados
                Vuelo nuevoVuelo = new Vuelo(codigo, origen, destino, fechaSalida, asientos);

                // Usar el gestor de vuelos para agregarlo
                listaVuelos.Add(nuevoVuelo);
                MostrarVuelos();

                MessageBox.Show("Vuelo agregado correctamente.");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de asientos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnReservarVuelo_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoReserva.Text;
            int cantidadReservas;

            // Validar si la cantidad de reservas es un número válido y mayor que 0
            if (int.TryParse(txtCantidadReservas.Text, out cantidadReservas) && cantidadReservas > 0)
            {
                // Buscar el vuelo usando el código proporcionado
                GestorVuelos gestor = new GestorVuelos();
                Vuelo vuelo = gestor.BuscarVuelo(codigo);

                if (vuelo != null)
                {
                    // Verificar si la cantidad de reservas no excede los asientos disponibles
                    if (cantidadReservas <= vuelo.AsientosDisponibles)
                    {
                        // Realizar la reserva
                        if (vuelo.ReservarAsientos(cantidadReservas))
                        {
                            MostrarVuelos();
                            MessageBox.Show("Reserva realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudieron realizar los cambios en la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // Si no hay suficientes asientos disponibles
                        MessageBox.Show("No hay suficientes asientos disponibles para la cantidad solicitada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vuelo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de asientos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarVuelos()
        {
            VuelosDisponibles.Items.Clear(); // Limpia el ListBox antes de actualizar

            foreach (var vuelo in listaVuelos)
            {
                VuelosDisponibles.Items.Add($"{vuelo.Codigo} - {vuelo.Origen} a {vuelo.Destino} ({vuelo.FechaSalida.ToShortDateString()}), Asientos: {vuelo.AsientosDisponibles}");
            }
        }

    }
}
