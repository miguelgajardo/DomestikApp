using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomestikApp.Modelo
{
    internal class Vuelo
    {
        public string numvlo {  get; set; }
        public DateTime fecha { get; set; }
        private DateTime _hora = DateTime.Today;

        public DateTime hora
        {
            get => _hora;
            set => _hora = value;
        }
        public string destino { get; set; }

        // Formatted properties for the view/database
        public string FechaFormateada => fecha.ToString("dd-MM-yyyy");
        public string HoraFormateada
        {
            get
            {
                try
                {
                    return _hora.ToString("HH:mm", CultureInfo.InvariantCulture);
                }
                catch
                {
                    return "00:00"; // Default time when formatting fails
                }
            }
        }
        public void SetFechaFromString(string fechaStr)
        {
            fecha = DateTime.ParseExact(fechaStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        }

        public void SetHoraFromString(string horaStr)
        {
            hora = DateTime.ParseExact(horaStr, "HH:mm", CultureInfo.InvariantCulture);
        }
    }
}
