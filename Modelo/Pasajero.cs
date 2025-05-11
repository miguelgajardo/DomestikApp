using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomestikApp.Modelo
{
    enum TipoPasajero
    {
        Frecuente,
        Normal
    }
    internal class Pasajero
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public TipoPasajero tipoPasajero { get; set; }
        public int puntaje { get; set; }
    }
}
