using Spa_Vehiculos_api.Clases;
using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Spa_Vehiculos_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Departamento")]
    //[Authorize]
    public class DepartamentoController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public Departamento Consultar(int id_Departamento)
        {
            clsDepartamento Departamento = new clsDepartamento();
            return Departamento.Consultar(id_Departamento);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Departamento dep)
        {
            clsDepartamento Departamento = new clsDepartamento();
            Departamento.departamento = dep;
            return Departamento.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Departamento dep)
        {
            clsDepartamento Departamento = new clsDepartamento();
            Departamento.departamento = dep;
            return Departamento.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Departamento dep)
        {
            clsDepartamento Departamento = new clsDepartamento();
            Departamento.departamento = dep;
            return Departamento.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_Departamento)
        {
            clsDepartamento Departamento = new clsDepartamento();
            return Departamento.EliminarXId(id_Departamento);
        }
    }
}