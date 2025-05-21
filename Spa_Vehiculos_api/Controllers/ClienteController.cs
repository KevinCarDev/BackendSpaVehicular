using Spa_Vehiculos_api.Clases;
using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Spa_Vehiculos_api.Controllers
{
    [RoutePrefix("api/Cliente")]
    [Authorize]
    public class ClienteController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public Cliente Consultar(int id_Cliente)
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.Consultar(id_Cliente);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Cliente clien)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = clien;
            return Cliente.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Cliente clien)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = clien;
            return Cliente.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Cliente clien)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = clien;
            return Cliente.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_Cliente)
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.EliminarXId(id_Cliente);
        }
    }
}