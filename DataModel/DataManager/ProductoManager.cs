using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.DataManager
{
    public class ProductoManager
    {
        public static List<ProductoModel> ObtenerProductos()
        {
            try
            {
                using (TiendaEntities db = new TiendaEntities())
                {
                    return db.sp_ObtenerProductos().AsEnumerable().Select(x => new ProductoModel()
                    {
                        IdProducto = x.IdProducto,
                        NombreProducto = x.NombreProducto,
                        ValorUnitario = x.ValorUnitario,
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static ProductoModel CrearEditarProducto(ProductoModel Producto)
        {
            try
            {
                using (TiendaEntities db = new TiendaEntities())
                {
                    return db.sp_CrearEditarProducto(Producto.IdProducto, Producto.NombreProducto,Producto.ValorUnitario).AsEnumerable().Select(x => new ProductoModel()
                    {
                        IdProducto = x.IdProducto,
                        NombreProducto = x.NombreProducto,
                        ValorUnitario= x.ValorUnitario,
                        Nota = x.Nota,
                        EstadoNota = x.EstadoNota
                    }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
