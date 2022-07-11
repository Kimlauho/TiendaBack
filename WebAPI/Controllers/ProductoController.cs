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
    public class ProductoController : ApiController
    {
        [HttpGet]
        [Route("~/api/Producto/ObtenerProductos")]
        public IHttpActionResult ObtenerProductos()
        {
            try
            {
                var result = ProductoBR.ObtenerProductos();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/Producto/CrearEditarProducto")]
        public IHttpActionResult CrearEditarProducto(ProductoModel producto)
        {
            try
            {
                var result = ProductoBR.CrearEditarProducto(producto);
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