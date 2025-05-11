using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomestikApp.Modelo
{
    internal class Credencial
    {
        public string usuario { get; set; }
        public string password { get; set; }

        public Credencial(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }
    }
}
