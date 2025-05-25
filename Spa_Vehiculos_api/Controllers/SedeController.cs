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
    [RoutePrefix("api/Sede")]
    //[Authorize]
    public class SedeController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public Sede Consultar(int id_Sede)
        {
            clsSede Sede = new clsSede();
            return Sede.Consultar(id_Sede);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Sede sed)
        {
            clsSede Sede = new clsSede();
            Sede.sede = sed;
            return Sede.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Sede sed)
        {
            clsSede Sede = new clsSede();
            Sede.sede = sed;
            return Sede.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Sede sed)
        {
            clsSede Sede = new clsSede();
            Sede.sede = sed;
            return Sede.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_Sede)
        {
            clsSede Sede = new clsSede();
            return Sede.EliminarXId(id_Sede);
        }
    }
}