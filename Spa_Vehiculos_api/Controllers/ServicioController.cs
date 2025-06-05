using Spa_Vehiculos_api.Clases;
using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace Spa_Vehiculos.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Servicio")]
    public class ServicioController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public Servicio Consultar(int id_Servicio)
        {
            clsServicio Servicio = new clsServicio();
            return Servicio.Consultar(id_Servicio);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Servicio ser)
        {
            clsServicio Servicio = new clsServicio();
            Servicio.servicio = ser;
            return Servicio.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Servicio ser)
        {
            clsServicio Servicio = new clsServicio();
            Servicio.servicio = ser;
            return Servicio.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Servicio ser)
        {
            clsServicio Servicio = new clsServicio();
            Servicio.servicio = ser;
            return Servicio.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_Servicio)
        {
            clsServicio Servicio = new clsServicio();
            return Servicio.EliminarXId(id_Servicio);
        }
    }
}