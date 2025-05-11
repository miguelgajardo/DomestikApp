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
    public partial class GestionarVuelosView : Form
    {
        public GestionarVuelosView()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resp = 0;
            Vuelo vuelo = new Vuelo();
            vuelo.numvlo = textBox1.Text;
            vuelo.fecha = dateTimePicker1.Value;
            vuelo.hora = dateTimePicker2.Value;
            vuelo.destino = textBox2.Text;
            resp = VueloDAO.crearVuelo(vuelo);
            if (resp > 0)
            {
                MessageBox.Show("Vuelo registrado en Base de Datos",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vuelo No fue registrado en Base de Datos.",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridVuelos.DataSource = VueloDAO.listarVuelos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
