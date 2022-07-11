using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.DataManager
{
    public class ClienteManager
    {
        public static List<ClienteModel> ObtenerClientes()
        {
            try
            {
                using (TiendaEntities db = new TiendaEntities())
                {
                    return db.sp_ObtenerClientes().AsEnumerable().Select(x => new ClienteModel()
                    {
                        IdCliente = x.IdCliente,
                        Cedula = x.Cedula,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        Telefono = x.Telefono
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public static ClienteModel CrearEditarCliente(ClienteModel cliente)
        {
            try
            {
                using (TiendaEntities db = new TiendaEntities())
                {
                    return db.sp_CrearEditarCliente(cliente.IdCliente, cliente.Cedula, cliente.Nombre, cliente.Apellido, cliente.Telefono).AsEnumerable().Select(x => new ClienteModel()
                    {
                        IdCliente = x.IdCliente,
                        Cedula = x.Cedula,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        Telefono = x.Telefono,
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
