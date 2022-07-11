using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class VentaModel : ClienteModel
    {
        public int? IdVenta { get; set; }
        public decimal? ValorTotal { get; set; }
        public List<DetalleVentaModel> _DetalleVenta {get; set;}
    }

    public class DetalleVentaModel : ProductoModel
    {
        public int? IdDetalleVenta { get; set; }
        public int? IdVenta { get; set; }
    }
}
