using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomestikApp.Controlador;
using DomestikApp.Modelo;

namespace DomestikApp.Vista
{
    public partial class GestionarReservasView : Form
    {
        public GestionarReservasView()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(TipoReserva));
            comboBox1.SelectedItem = TipoReserva.Economica;
            UpdateReservaText();
            UpdateReservaTotal();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
      }

       private void  UpdateReservaText()
        {
            if (comboBox1.SelectedItem.Equals(TipoReserva.Economica))
            {
                textBox8.Text = "Reserva No sujeta a cambio";
            }
            else if (comboBox1.SelectedItem.Equals(TipoReserva.Turista))
            {
                textBox8.Text = "Para cambio debe pagar 10% del\r\nvalor base";
            }
            else
            {
                textBox8.Text = "Puede efectuar cambio sin costo";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.Pasajero pasajero = new Modelo.Pasajero();
            string rutPasajero = textBox1.Text;
            pasajero = PasajeroDAO.buscarPasajero(rutPasajero);
            if (pasajero != null)
            {
                textBox2.Text = pasajero.nombre + " " + pasajero.apellido;
                textBox6.Text = pasajero.tipoPasajero.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró al pasajero - Debe existir para registrar una nueva reserva");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelo.Vuelo vuelo = new Modelo.Vuelo();
            string numvlo = textBox3.Text;
            vuelo = VueloDAO.buscarVuelo(numvlo);
            if (vuelo != null)
            {
                textBox4.Text = vuelo.fecha.ToString() + vuelo.hora.ToString();
                textBox5.Text = vuelo.destino;
            }
            else
            {
                MessageBox.Show("No se encontró el Vuelo - Debe existir para registrar una nueva reserva");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int resp = 0;
            Modelo.Pasajero pasajero = new Modelo.Pasajero();
            pasajero.rut = textBox1.Text;
            Modelo.Vuelo vuelo = new Modelo.Vuelo();
            vuelo.numvlo = textBox3.Text;
            Modelo.Reserva reserva = new Modelo.Reserva();
            reserva.codigo = textBox7.Text;
            reserva.pasajero = pasajero;
            reserva.vuelo = vuelo;
            TipoReserva reservaSeleccionada = (TipoReserva)comboBox1.SelectedItem;
            reserva.tipoReserva = reservaSeleccionada;
            reserva.valor = Double.Parse(textBox9.Text);
            resp = ReservaDAO.crearReserva(reserva);
            if (resp > 0)
            {
                MessageBox.Show("Reserva registrada en Base de Datos",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reserva No fue registrada en Base de Datos.",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateReservaText();
            UpdateReservaTotal();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void UpdateReservaTotal()
        {
            Reserva reserva = new Reserva();
            reserva.tipoReserva = (TipoReserva)comboBox1.SelectedItem;
            if (comboBox1.SelectedItem.Equals(TipoReserva.Economica))
            {
                textBox9.Text = Utils.GestionReservas.calcularValorReserva(reserva).ToString();
            }
            else if (comboBox1.SelectedItem.Equals(TipoReserva.Turista))
            {
                textBox9.Text = Utils.GestionReservas.calcularValorReserva(reserva).ToString();
            }
            else
            {
                textBox9.Text = Utils.GestionReservas.calcularValorReserva(reserva).ToString();
            }
        }
    }
}
