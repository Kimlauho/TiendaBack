using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.DataManager
{
    public class VentaManager
    {
        public static List<VentaModel> ObtenerVentas(VentaModel venta)
        {
            try
            {
                using (TiendaEntities db = new TiendaEntities())
                {
                    return db.sp_ObtenerVentas(venta.IdCliente).AsEnumerable().Select(x => new VentaModel()
                    {
                        IdVenta = x.IdVenta,
                        IdCliente = x.IdCliente,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        ValorTotal = x.ValorTotal,
                        _DetalleVenta = db.sp_ObtenerDetalleVentas(x.IdVenta).AsEnumerable().Select(z => new DetalleVentaModel()
                        {
                            IdVenta = x.IdVenta,
                            IdDetalleVenta = z.IdDetalleVenta,
                            IdProducto = z.IdProducto,
                            NombreProducto = z.NombreProducto,
                            ValorUnitario = z.ValorUnitario
                        }).ToList()
                }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static VentaModel CrearEditarVenta(VentaModel Venta)
        {
            try
            {
                VentaModel ventaResult = new VentaModel();
                using (TiendaEntities db = new TiendaEntities())
                {
                    ventaResult = db.sp_CrearEditarVenta(Venta.IdVenta, Venta.IdCliente, Venta.ValorTotal).AsEnumerable().Select(x => new VentaModel()
                    {
                        IdVenta = x.IdVenta,
                        IdCliente = x.IdCliente,
                        ValorTotal = x.ValorTotal,
                        Nota = x.Nota,
                        EstadoNota = x.EstadoNota
                    }).FirstOrDefault();

                    if (ventaResult.EstadoNota == 1)
                    {
                        return ventaResult;
                    }

                    if (ventaResult.IdVenta != null && Venta._DetalleVenta != null)
                    {
                        List<DetalleVentaModel> listDetalle = new List<DetalleVentaModel>();
                        foreach (var item in Venta._DetalleVenta)
                        {
                            DetalleVentaModel detalle = new DetalleVentaModel();
                            detalle = db.sp_CrearEditarDetalleVenta(ventaResult.IdVenta,item.IdDetalleVenta, item.IdProducto, item.ValorUnitario).AsEnumerable().Select(x => new DetalleVentaModel()
                            {
                                IdVenta = x.IdVenta,
                                IdDetalleVenta = x.IdDetalleVenta,
                                IdProducto = x.IdProducto,
                                ValorUnitario = x.ValorUnitario,
                                Nota = x.Nota,
                                EstadoNota = x.EstadoNota
                            }).FirstOrDefault();
                            listDetalle.Add(detalle);

                            if (detalle.EstadoNota == 1)
                            {
                                ventaResult._DetalleVenta = listDetalle;
                                ventaResult.Nota = detalle.Nota;
                                ventaResult.EstadoNota = 1;
                                return ventaResult;
                            }
                        }
                        ventaResult._DetalleVenta = listDetalle;
                    }
                }
                return ventaResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
