using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomestikApp.Configuration;
using DomestikApp.Modelo;
using MySql.Data.MySqlClient;

namespace DomestikApp.Controlador
{
    internal class LoginController
    {
        public Boolean login(Credencial credencial)
        {
            Boolean existe = false;
            MySqlConnection mySqlConnection = Conexion.openConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * from tbl_autenticacion WHERE id_usuario = '" + credencial.usuario + "' AND password = '" + credencial.password + "'", mySqlConnection);
            MySqlDataReader read = mySqlCommand.ExecuteReader();
            if (read.Read()) existe = true;
            return existe;
        }
    }
}
