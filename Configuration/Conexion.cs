using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DomestikApp.Configuration
{
    internal class Conexion
    {
        public static MySqlConnection openConnection()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=BD_DOMESTIKAPP;Uid=root;pwd=;");
            conexion.Open();
            return conexion;
        }
    }
}
