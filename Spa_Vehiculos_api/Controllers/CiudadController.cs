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
    [RoutePrefix("api/Ciudad")]
    //[Authorize]
    public class CiudadController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public Ciudad Consultar(int id_Ciudad)
        {
            clsCiudad Ciudad = new clsCiudad();
            return Ciudad.Consultar(id_Ciudad);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Ciudad ciu)
        {
            clsCiudad Ciudad = new clsCiudad();
            Ciudad.ciudad = ciu;
            return Ciudad.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Ciudad ciu)
        {
            clsCiudad Ciudad = new clsCiudad();
            Ciudad.ciudad = ciu;
            return Ciudad.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Ciudad ciu)
        {
            clsCiudad Ciudad = new clsCiudad();
            Ciudad.ciudad = ciu;
            return Ciudad.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_Ciudad)
        {
            clsCiudad Ciudad = new clsCiudad();
            return Ciudad.EliminarXId(id_Ciudad);
        }
    }
}
