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
    internal class ReservaDAO
    {
        public static int crearReserva(Reserva reserva)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand command = new MySqlCommand(
                string.Format(
                    "INSERT INTO tbl_reservas(codigo, tipo, valor, rut, numvlo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    reserva.codigo, reserva.tipoReserva.ToString(), reserva.valor,
                    reserva.pasajero.rut, reserva.vuelo.numvlo),
                conexion);
            retorno = command.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }
    }
}
