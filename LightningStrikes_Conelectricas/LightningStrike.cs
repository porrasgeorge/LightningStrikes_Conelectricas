using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningStrikes_Conelectricas
{
    class LightningStrike
    {
        public LightningStrike(DateTime fechaHora, double latitud, double longitud, double amplitud)
        {
            FechaHora = fechaHora;
            this.latitud = latitud;
            this.longitud = longitud;
            this.amplitud = amplitud;
            this.altura = 0.0;
        }

        public LightningStrike(DateTime fechaHora, double latitud, double longitud, double amplitud, double altura)
        {
            FechaHora = fechaHora;
            this.latitud = latitud;
            this.longitud = longitud;
            this.amplitud = amplitud;
            this.altura = altura;

        }

        public DateTime FechaHora { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
        public double amplitud { get; set; }
        public double altura { get; set; }
    }
}
