using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomestikApp.Data;
using DomestikApp.Modelo;

namespace DomestikApp.Utils
{
    internal class GestionReservas
    {
        public static double calcularValorReserva(Reserva reserva)
        {
            double valorBase = 0.0;
            double embarque = 0.0;
            double totalReserva = 0.0;
            if(reserva.tipoReserva.Equals(TipoReserva.Economica)) {
                valorBase = Tarifas.Economica.ValorBase;
                embarque = Tarifas.Economica.GastoEmbarque;
                totalReserva = valorBase + embarque;
            } else if(reserva.tipoReserva.Equals(TipoReserva.Turista))
            {
                valorBase = Tarifas.Turista.ValorBase;
                embarque = Tarifas.Turista.GastoEmbarque;
                totalReserva = valorBase + embarque;
            }
            else
            {
                valorBase = Tarifas.Ejecutivo.ValorBase;
                embarque = Tarifas.Ejecutivo.GastoEmbarque;
                totalReserva = valorBase + embarque;
            }
            return totalReserva;
        }
    }
}
