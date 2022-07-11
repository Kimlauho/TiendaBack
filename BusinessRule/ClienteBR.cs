using DataModel.DataManager;
using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRule
{
    public class ClienteBR
    {
        public static List<ClienteModel> ObtenerClientes()
        {
            return ClienteManager.ObtenerClientes();
        }

        public static ClienteModel CrearEditarCliente(ClienteModel Cliente)
        {
            return ClienteManager.CrearEditarCliente(Cliente);
        }
    }
}
