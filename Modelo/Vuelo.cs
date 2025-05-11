using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomestikApp.Modelo
{
    internal class Vuelo
    {
        public string numvlo {  get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string destino { get; set; }
    }
}
