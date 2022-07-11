using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class ProductoModel
    {
        public int? IdProducto {get; set;}
        public string NombreProducto {get; set;}
        public decimal? ValorUnitario {get; set;}
        public int? EstadoNota {get; set;}
        public string Nota { get; set;}
    }
}
