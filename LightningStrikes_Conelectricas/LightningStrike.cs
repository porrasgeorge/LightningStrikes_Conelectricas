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
        }

        public DateTime FechaHora { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
        public double amplitud { get; set; }
    }
}
