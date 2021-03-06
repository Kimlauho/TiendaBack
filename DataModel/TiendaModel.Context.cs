//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class TiendaEntities : DbContext
    {
        public TiendaEntities()
            : base("name=TiendaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<sp_CrearEditarCliente_Result> sp_CrearEditarCliente(Nullable<int> idCliente, string cedula, string nombre, string apellido, string telefono)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CrearEditarCliente_Result>("sp_CrearEditarCliente", idClienteParameter, cedulaParameter, nombreParameter, apellidoParameter, telefonoParameter);
        }
    
        public virtual ObjectResult<sp_CrearEditarDetalleVenta_Result> sp_CrearEditarDetalleVenta(Nullable<int> idVenta, Nullable<int> idDetalleVenta, Nullable<int> idProducto, Nullable<decimal> valorUnitario)
        {
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("IdVenta", idVenta) :
                new ObjectParameter("IdVenta", typeof(int));
    
            var idDetalleVentaParameter = idDetalleVenta.HasValue ?
                new ObjectParameter("IdDetalleVenta", idDetalleVenta) :
                new ObjectParameter("IdDetalleVenta", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            var valorUnitarioParameter = valorUnitario.HasValue ?
                new ObjectParameter("ValorUnitario", valorUnitario) :
                new ObjectParameter("ValorUnitario", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CrearEditarDetalleVenta_Result>("sp_CrearEditarDetalleVenta", idVentaParameter, idDetalleVentaParameter, idProductoParameter, valorUnitarioParameter);
        }
    
        public virtual ObjectResult<sp_CrearEditarProducto_Result> sp_CrearEditarProducto(Nullable<int> idProducto, string nombreProducto, Nullable<decimal> valorUnitario)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            var nombreProductoParameter = nombreProducto != null ?
                new ObjectParameter("NombreProducto", nombreProducto) :
                new ObjectParameter("NombreProducto", typeof(string));
    
            var valorUnitarioParameter = valorUnitario.HasValue ?
                new ObjectParameter("ValorUnitario", valorUnitario) :
                new ObjectParameter("ValorUnitario", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CrearEditarProducto_Result>("sp_CrearEditarProducto", idProductoParameter, nombreProductoParameter, valorUnitarioParameter);
        }
    
        public virtual ObjectResult<sp_CrearEditarVenta_Result> sp_CrearEditarVenta(Nullable<int> idVenta, Nullable<int> idCliente, Nullable<decimal> valorTotal)
        {
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("IdVenta", idVenta) :
                new ObjectParameter("IdVenta", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var valorTotalParameter = valorTotal.HasValue ?
                new ObjectParameter("ValorTotal", valorTotal) :
                new ObjectParameter("ValorTotal", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CrearEditarVenta_Result>("sp_CrearEditarVenta", idVentaParameter, idClienteParameter, valorTotalParameter);
        }
    
        public virtual ObjectResult<sp_ObtenerClientes_Result> sp_ObtenerClientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ObtenerClientes_Result>("sp_ObtenerClientes");
        }
    
        public virtual ObjectResult<sp_ObtenerDetalleVentas_Result> sp_ObtenerDetalleVentas(Nullable<int> idVenta)
        {
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("IdVenta", idVenta) :
                new ObjectParameter("IdVenta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ObtenerDetalleVentas_Result>("sp_ObtenerDetalleVentas", idVentaParameter);
        }
    
        public virtual ObjectResult<sp_ObtenerProductos_Result> sp_ObtenerProductos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ObtenerProductos_Result>("sp_ObtenerProductos");
        }
    
        public virtual ObjectResult<sp_ObtenerVentas_Result> sp_ObtenerVentas(Nullable<int> idCliente)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ObtenerVentas_Result>("sp_ObtenerVentas", idClienteParameter);
        }
    }
}
