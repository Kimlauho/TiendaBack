using BusinessRule;
using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ClienteController : ApiController
    {
        [HttpGet]
        [Route("~/api/Cliente/ObtenerClientes")]
        public IHttpActionResult ObtenerClientes()
        {
            try
            {
                var result = ClienteBR.ObtenerClientes();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/Cliente/CrearEditarCliente")]
        public IHttpActionResult CrearEditarCliente(ClienteModel Cliente)
        {
            try
            {
                var result = ClienteBR.CrearEditarCliente(Cliente);
                if (result.EstadoNota == 1)
                {
                    return BadRequest(result.Nota);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}