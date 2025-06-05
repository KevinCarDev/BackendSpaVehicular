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
    [RoutePrefix("api/Cita")]
    [Authorize]
    public class CitaController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public Cita Consultar(int id_Cita)
        {
            clsCita cita = new clsCita();
            return cita.Consultar(id_Cita);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Cita> ConsultarTodos()
        {
            var cita = new clsCita();
            return cita.ConsultarTodos();
        }


        [HttpGet]
        [Route("ConsultarXCliente")]
        public List<Cita> ConsultarXCliente(int id_Cliente)
        {
            clsCita Cita = new clsCita();
            return Cita.ConsultarCitaPorCliente(id_Cliente).ToList();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Cita clien)
        {
            clsCita Cita = new clsCita();
            Cita.cita = clien;
            return Cita.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Cita clien)
        {
            clsCita Cita = new clsCita();
            Cita.cita = clien;
            return Cita.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Cita clien)
        {
            clsCita Cita = new clsCita();
            Cita.cita = clien;
            return Cita.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_Cita)
        {
            clsCita Cita = new clsCita();
            return Cita.EliminarXId(id_Cita);
        }
    }
}