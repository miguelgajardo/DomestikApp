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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vista.DashboardView dashboard = new Vista.DashboardView();
            dashboard.Show();
            //Boolean isLogin = true;
            //LoginController loginControl = new LoginController();
            /* if (textBox1.Text != null && textBox2.Text != null)
            {
                Credencial credencial = new Credencial(textBox1.Text, textBox2.Text);
                isLogin = loginControl.login(credencial);
                if (isLogin)
                {
                    Vista.DashboardView dashboard = new Vista.DashboardView();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Error al intentar iniciar sesión!");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para el inicio de sesión!");
            } */
        }
    }
}
