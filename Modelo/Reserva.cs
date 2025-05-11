using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomestikApp.Modelo { 

    enum TipoReserva
{
    Economica,
    Turista,
    Ejecutivo
}
    internal class Reserva
    {
        public string codigo { get; set; }
        public TipoReserva tipoReserva { get; set; }
        public double valor { get; set; }
        public Pasajero pasajero { get; set; }
        public Vuelo vuelo { get; set; }
    
    }
}
