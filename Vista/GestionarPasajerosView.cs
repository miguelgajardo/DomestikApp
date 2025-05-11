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
    public partial class GestionarPasajerosView : Form
    {
        public GestionarPasajerosView()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(TipoPasajero));
            comboBox1.SelectedItem = TipoPasajero.Normal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rut = textBox1.Text;
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            TipoPasajero tipoSeleccionado = (TipoPasajero)comboBox1.SelectedItem;
            if (rut != null && nombre != null && apellido != null)
            {
                int resp = 0;
                Pasajero pasajero = new Pasajero();
                pasajero.rut = rut;
                pasajero.nombre = nombre;
                pasajero.apellido = apellido;
                pasajero.tipoPasajero = tipoSeleccionado;
                pasajero.puntaje = 0;
                resp = PasajeroDAO.crearPasajero(pasajero);
                if (resp > 0)
                {
                    MessageBox.Show("Pasajero registrado en Base de Datos",
                                  "AVISO DE SISTEMA",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Pasajero No fue registrado en Base de Datos.",
                                  "AVISO DE SISTEMA",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Ingrese la información obligatoria solicitada");
            }
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridPasajeros.DataSource = PasajeroDAO.listarPasajeros();
        }
    }
}
