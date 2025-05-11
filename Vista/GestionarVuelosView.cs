using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Vuelo vuelo = new Vuelo();
            vuelo.fecha = dateTimePicker1.Value.Date;


        }
    }
}
