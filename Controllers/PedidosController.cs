using ServicioClientesPedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioClientesPedidos.Controllers
{
    [RoutePrefix("api/get-info")]
    public class PedidosController : ApiController
    {
        [HttpGet]
        [Route("pedidos/{cliente}")]
        public IHttpActionResult pedidos(string cliente)
        {
            try
            {
                 PedidosModule pedidosModule = new PedidosModule(cliente);
                
                var pedidosCliente = pedidosModule.getpedidos();

                return Ok(pedidosCliente);
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }
        }


    }
}
