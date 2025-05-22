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
    [RoutePrefix("api/Empleado")]
    //[Authorize]
    public class EmpleadoController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Empleado> ConsultarTodos()
        {
            var Empleado = new clsEmpleado();
            return Empleado.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public Empleado Consultar(int id_Empleado)
        {
            clsEmpleado Empleado = new clsEmpleado();
            return Empleado.Consultar(id_Empleado);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Empleado emp)
        {
            clsEmpleado Empleado = new clsEmpleado();
            Empleado.empleado = emp;
            return Empleado.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Empleado emp)
        {
            clsEmpleado Empleado = new clsEmpleado();
            Empleado.empleado = emp;
            return Empleado.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Empleado emp)
        {
            clsEmpleado Empleado = new clsEmpleado();
            Empleado.empleado = emp;
            return Empleado.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_Empleado)
        {
            clsEmpleado Empleado = new clsEmpleado();
            return Empleado.EliminarXId(id_Empleado);
        }
    }
}