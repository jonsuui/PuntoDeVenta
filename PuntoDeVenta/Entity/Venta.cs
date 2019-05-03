using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Entity
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal TotalVenta { get; set; }

        public List<VentaDetalle> Detalle { get; set; }

        public Venta()
        {
            Detalle = new List<VentaDetalle>();
        }
    }
}
