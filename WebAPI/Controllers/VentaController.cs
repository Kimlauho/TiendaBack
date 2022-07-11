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
    [EnableCors("*","*","*")]
    public class VentaController : ApiController
    {
        [HttpPost]
        [Route("~/api/Venta/ObtenerVentas")]
        public IHttpActionResult ObtenerVentas(VentaModel venta)
        {
            try
            {
                var result = VentaBR.ObtenerVentas(venta);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/Venta/CrearEditarVenta")]
        public IHttpActionResult CrearEditarVenta(VentaModel Venta)
        {
            try
            {
                var result = VentaBR.CrearEditarVenta(Venta);
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