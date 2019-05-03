using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Entity
{
    public class VentaDetalle
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public Producto ProductoVenta { get; set; }

        public VentaDetalle()
        {
            ProductoVenta = new Producto();
        }
    }
}
