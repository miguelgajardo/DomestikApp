using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomestikApp.Configuration;
using DomestikApp.Modelo;
using MySql.Data.MySqlClient;

namespace DomestikApp.Controlador
{
    internal class VueloDAO
    {
        public static int crearVuelo(Vuelo vuelo)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.openConnection();

            MySqlCommand command = new MySqlCommand(
                string.Format(
                    "INSERT INTO tbl_vuelos(numvlo, fecha, hora, destino) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    vuelo.numvlo, vuelo.fecha, vuelo.hora, vuelo.destino),
                conexion);
            retorno = command.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static Vuelo buscarVuelo(string numvlo)
        {
            Vuelo vuelo = new Vuelo();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM tbl_vuelos WHERE numvlo=@numvlo"), Conexion.openConnection());
            orden.Parameters.AddWithValue("@numvlo", numvlo);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                vuelo.numvlo = lector.GetString(0);
                vuelo.fecha = lector.GetDateTime(1);
                vuelo.hora = lector.GetTimeSpan(2);
                vuelo.destino = lector.GetString(3);
            }
            return vuelo;
        }
    }
}
