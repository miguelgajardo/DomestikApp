using System;
using System.Windows.Forms;

namespace DomestikApp.Vista
{
    public partial class DashboardView : Form
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void gestionarPasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPasajerosView gestionarPasajerosView = new GestionarPasajerosView();
            gestionarPasajerosView.Show();
        }

        private void gestionarVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarVuelosView gestionarVuelosView = new GestionarVuelosView();
            gestionarVuelosView.Show();
        }

        private void gestionarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarReservasView gestionarReservasView = new GestionarReservasView();
            gestionarReservasView.Show();
        }
    }
}
