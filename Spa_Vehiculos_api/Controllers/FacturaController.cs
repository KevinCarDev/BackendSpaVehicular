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
    [RoutePrefix("api/Factura")]
    public class FacturaController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Factura> ConsultarTodos()
        {
            var factura = new clsFactura();
            return factura.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXCliente")]
        public List<Factura> ConsultarXCliente(int id_Cliente)
        {
            clsFactura factura = new clsFactura();
            return factura.ConsultarXCliente(id_Cliente);
        }
        [HttpGet]
        [Route("ConsultarXId")]
        public List<Factura> ConsultarXId(int id_Factura)
        {
            clsFactura factura = new clsFactura();
            return factura.ConsultarXId(id_Factura);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Factura fac)
        {
            clsFactura factura = new clsFactura();
            factura.factura = fac;
            return factura.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Factura fac)
        {
            clsFactura factura = new clsFactura();
            factura.factura = fac;
            return factura.Actualizar();
        }



        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_Factura)
        {
            clsFactura factura = new clsFactura();
            return factura.EliminarXId(id_Factura);

        }
    }
}
