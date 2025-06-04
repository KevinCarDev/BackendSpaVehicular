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
    [RoutePrefix("api/TelfEmpleados")]
    //[Authorize]
    public class TelefonoEmpleadoController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Telefono_Empleado> ConsultarTodos()
        {
            var TelfEmpleado = new clsTelefEmpleado();
            return TelfEmpleado.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public Telefono_Empleado Consultar(int id_tel)
        {
            clsTelefEmpleado TelEmpleado = new clsTelefEmpleado();
            return TelEmpleado.Consultar(id_tel);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Telefono_Empleado telemp)
        {
            clsTelefEmpleado TelEmpleado = new clsTelefEmpleado();
            TelEmpleado.TelfEmpleado = telemp;
            return TelEmpleado.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Telefono_Empleado emp)
        {
            clsTelefEmpleado TelEmpleado = new clsTelefEmpleado();
            TelEmpleado.TelfEmpleado = emp;
            return TelEmpleado.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Telefono_Empleado emp)
        {
            clsTelefEmpleado TelEmpleado = new clsTelefEmpleado();
            TelEmpleado.TelfEmpleado = emp;
            return TelEmpleado.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id_tel)
        {
            clsTelefEmpleado TelfEmpleado = new clsTelefEmpleado();
            return TelfEmpleado.EliminarXId(id_tel);
        }
    }
}