using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomestikApp.Data
{
    internal static class Tarifas
    {
        public static class Economica
        {
            public const double ValorBase = 30000;
            public const double GastoEmbarque = 5500;
            public const int Puntaje = 500;
        }

        public static class Turista
        {
            public const double ValorBase = 40000;
            public const double GastoEmbarque = 6000;
            public const int Puntaje = 700;
        }

        public static class Ejecutivo
        {
            public const double ValorBase = 60000;
            public const double GastoEmbarque = 10000;
            public const int Puntaje = 1000;
        }
        //double valorTotal = TarifasVuelo.Economica.ValorBase + TarifasVuelo.Economica.GastoEmbarque;
    }
}
