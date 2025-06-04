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
    [RoutePrefix("api/EmaEmpleados")]
    //[Authorize]
    public class EmailEmpleadoController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Email_Empleado> ConsultarTodos()
        {
            var EmaEmpleado = new clsEmailEmpleado();
            return EmaEmpleado.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public Email_Empleado Consultar(int id_ema)
        {
            clsEmailEmpleado EmaEmpleado = new clsEmailEmpleado();
            return EmaEmpleado.Consultar(id_ema);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Email_Empleado emailemp)
        {
            clsEmailEmpleado EmaEmpleado = new clsEmailEmpleado();
            EmaEmpleado.EmaEmpleado = emailemp;
            return EmaEmpleado.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Email_Empleado emp)
        {
            clsEmailEmpleado EmaEmpleado = new clsEmailEmpleado();
            EmaEmpleado.EmaEmpleado = emp;
            return EmaEmpleado.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Email_Empleado emp)
        {
            clsEmailEmpleado EmaEmpleado = new clsEmailEmpleado();
            EmaEmpleado.EmaEmpleado = emp;
            return EmaEmpleado.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_email)
        {
            clsEmailEmpleado EmaEmpleado = new clsEmailEmpleado();
            return EmaEmpleado.EliminarXId(id_email);
        }
    }
}