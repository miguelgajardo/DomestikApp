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
        public TimeSpan hora { get; set; }
        public string destino { get; set; }

        // Formatted properties for the view/database
        public string FechaFormateada => fecha.ToString("dd-MM-yyyy");
        public string HoraFormateada => hora.ToString("HH:mm");

        public void SetFechaFromString(string fechaStr)
        {
            fecha = DateTime.ParseExact(fechaStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        }

        public void SetHoraFromString(string horaStr)
        {
            hora = TimeSpan.ParseExact(horaStr, "HH:mm", CultureInfo.InvariantCulture);
        }
    }
}
