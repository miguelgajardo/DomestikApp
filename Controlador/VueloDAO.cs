using System;
using System.Collections.Generic;
using System.Globalization;
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
            /* MySqlConnection conexion = Conexion.openConnection();

             MySqlCommand command = new MySqlCommand(
                 string.Format(
                     "INSERT INTO tbl_vuelos(numvlo, fecha, hora, destino) VALUES ('{0}', STR_TO_DATE(@fecha, '%d-%m-%Y'), '%d-%m-%Y'), '{2}', '{3}')",
                     vuelo.numvlo, vuelo.fecha.ToString("dd-MM-yyyy"), vuelo.hora, vuelo.destino),
                 conexion);
             retorno = command.ExecuteNonQuery();
             conexion.Close(); */
            using (MySqlConnection conexion = Conexion.openConnection())
            {
                string sql = @"INSERT INTO tbl_vuelos(numvlo, fecha, hora, destino) 
                      VALUES (@numvlo, STR_TO_DATE(@fecha, '%d-%m-%Y'), @hora, @destino)";

                using (MySqlCommand command = new MySqlCommand(sql, conexion))
                {
                    command.Parameters.AddWithValue("@numvlo", vuelo.numvlo);
                    command.Parameters.AddWithValue("@fecha", vuelo.FechaFormateada);
                    command.Parameters.AddWithValue("@hora", vuelo.HoraFormateada);
                    command.Parameters.AddWithValue("@destino", vuelo.destino);

                    try
                    {
                        retorno = command.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        // Log the error
                        Console.WriteLine($"Database error: {ex.Message}");
                        retorno = -1;
                    }
                }
            }
            return retorno;
            return retorno;
        }

        /* public static Vuelo buscarVuelo(string numvlo)
         {
             Vuelo vuelo = new Vuelo();
             MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM tbl_vuelos WHERE numvlo=@numvlo"), Conexion.openConnection());
             orden.Parameters.AddWithValue("@numvlo", numvlo);
             MySqlDataReader lector = orden.ExecuteReader();
             if (lector.Read())
             {
                 vuelo.numvlo = lector.GetString(0);
                 vuelo.fecha = lector.GetDateTime(1);
                 vuelo.hora = lector.GetDateTime(2);
                 vuelo.destino = lector.GetString(3);
             }
             return vuelo;
         } */
        public static Vuelo buscarVuelo(string numvlo)
        {
            Vuelo vuelo = new Vuelo();
            using (MySqlConnection conexion = Conexion.openConnection())
            {
                // Use explicit formatting to ensure consistent date/time strings
                string sql = @"SELECT 
                      numvlo, 
                      IFNULL(DATE_FORMAT(fecha, '%d-%m-%Y'), '') as fecha_str,
                      IFNULL(TIME_FORMAT(hora, '%H:%i'), '') as hora_str,
                      destino 
                      FROM tbl_vuelos 
                      WHERE numvlo = @numvlo";

                using (MySqlCommand orden = new MySqlCommand(sql, conexion))
                {
                    orden.Parameters.AddWithValue("@numvlo", numvlo);

                    using (MySqlDataReader lector = orden.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            vuelo.numvlo = lector.IsDBNull(0) ? string.Empty : lector.GetString(0);
                            string fechaStr = lector.IsDBNull(1) ? string.Empty : lector.GetString(1);
                            if (!string.IsNullOrEmpty(fechaStr) &&
                                DateTime.TryParseExact(fechaStr, "dd-MM-yyyy",
                                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                            {
                                vuelo.fecha = fecha;
                            }
                            string horaStr = lector.IsDBNull(2) ? string.Empty : lector.GetString(2);
                            if (!string.IsNullOrEmpty(horaStr) &&
                                TimeSpan.TryParseExact(horaStr, @"hh\:mm",
                                    CultureInfo.InvariantCulture, out TimeSpan hora))
                            {
                                vuelo.hora = DateTime.Today.Add(hora);
                            }
                            vuelo.destino = lector.IsDBNull(3) ? string.Empty : lector.GetString(3);
                        }
                    }
                }
            }
            return vuelo;
        }

        public static List<Vuelo> listarVuelos()
        /* {
            List<Vuelo> lista = new List<Vuelo>();
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM tbl_vuelos"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Vuelo vuelo = new Vuelo();
                vuelo.numvlo = lector.GetString(0);
                object dateValue = lector.GetValue(1); // Get as object first
                //vuelo.fecha = lector.GetDateTime(1).ToLocalTime();
                if (dateValue != DBNull.Value)
                {
                    if (dateValue is DateTime)
                    {
                        vuelo.fecha = (DateTime)dateValue;
                    }
                    else
                    {
                        // Handle string conversion if needed
                        string dateString = lector.GetString(1);
                        vuelo.fecha = DateTime.ParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    }
                }
                else
                {
                    // Handle null case (set to default or null)
                    vuelo.fecha = DateTime.MinValue; // or use nullable DateTime?
                }
                vuelo.hora = lector.GetDateTime(2);
                vuelo.destino = lector.GetString(3);
                lista.Add(vuelo);
            }
            return lista;
        } */
        {
            List<Vuelo> lista = new List<Vuelo>();
            using (MySqlConnection conexion = Conexion.openConnection())
            {
                string sql = @"SELECT 
                      numvlo, 
                      IFNULL(DATE_FORMAT(fecha, '%d-%m-%Y'), '') as fecha_str,
                      IFNULL(TIME_FORMAT(hora, '%H:%i'), '') as hora_str,
                      destino 
                      FROM tbl_vuelos";

                using (MySqlCommand orden = new MySqlCommand(sql, conexion))
                using (MySqlDataReader lector = orden.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Vuelo vuelo = new Vuelo();
                        vuelo.numvlo = lector.IsDBNull(0) ? string.Empty : lector.GetString(0);
                        string fechaStr = lector.IsDBNull(1) ? string.Empty : lector.GetString(1);
                        if (!string.IsNullOrEmpty(fechaStr) &&
                            DateTime.TryParseExact(fechaStr, "dd-MM-yyyy",
                                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                        {
                            vuelo.fecha = fecha;
                        }
                        else
                        {
                            vuelo.fecha = DateTime.Today;
                        }
                        string horaStr = lector.IsDBNull(2) ? string.Empty : lector.GetString(2);
                        if (!string.IsNullOrEmpty(horaStr) &&
                            TimeSpan.TryParseExact(horaStr, @"hh\:mm",
                                CultureInfo.InvariantCulture, out TimeSpan hora))
                        {
                            vuelo.hora = DateTime.Today.Add(hora); 
                        }
                        else
                        {
                            vuelo.hora = DateTime.Today; 
                        }

                        vuelo.destino = lector.IsDBNull(3) ? string.Empty : lector.GetString(3);

                        lista.Add(vuelo);
                    }
                }
            }
            return lista;
        }
    }
}
