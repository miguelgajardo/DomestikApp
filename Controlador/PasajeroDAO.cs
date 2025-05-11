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
    internal class PasajeroDAO
    {
        public static int crearPasajero(Pasajero pasajero)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand command = new MySqlCommand(
                string.Format(
                    "INSERT INTO tbl_pasajeros(rut, nombre, apellido, tipo, puntaje) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    pasajero.rut, pasajero.nombre, pasajero.apellido,
                    pasajero.tipoPasajero.ToString(), pasajero.puntaje),
                conexion);
            retorno = command.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static Pasajero buscarPasajero(string rut)
        {
            Pasajero pasajero = new Pasajero();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM tbl_pasajeros WHERE rut=@rut"), Conexion.openConnection());
            orden.Parameters.AddWithValue("@rut", rut);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                pasajero.rut = lector.GetString(0);
                pasajero.nombre = lector.GetString(1);
                pasajero.apellido = lector.GetString(2);
                string dbValue = lector.GetString(3);
                if (Enum.TryParse(dbValue, out TipoPasajero tipo))
                {
                    pasajero.tipoPasajero = tipo;
                }
                else
                {
                    pasajero.tipoPasajero = TipoPasajero.Normal;
                }
                pasajero.puntaje = lector.GetInt32(4);
            }
            return pasajero;
        }

        public static List<Pasajero> listarPasajeros()
        {
            List<Pasajero> lista = new List<Pasajero>();
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM tbl_pasajeros"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Pasajero pasajero = new Pasajero();
                pasajero.rut = lector.GetString(0);
                pasajero.nombre = lector.GetString(1);
                pasajero.apellido = lector.GetString(2);
                string dbValue = lector.GetString(3);
                if (Enum.TryParse(dbValue, out TipoPasajero tipo))
                {
                    pasajero.tipoPasajero = tipo;
                }
                else
                {
                    pasajero.tipoPasajero = TipoPasajero.Normal;
                }
                pasajero.puntaje = lector.GetInt32(4);
                lista.Add(pasajero);
            }
            return lista;
        }
    }
}
