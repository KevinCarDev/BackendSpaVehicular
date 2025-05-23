﻿using Spa_Vehiculos_api.Clases;
using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Spa_Vehiculos_api.Controllers
{
    [RoutePrefix("api/Vehiculos")]
   // [Authorize]
    public class VehiculoClienteController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Vehiculo_Cliente> ConsultarTodos()
        {
            var vehiculoCliente = new clsVehiculoCliente();
            return vehiculoCliente.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXCliente")]
        public List<Vehiculo_Cliente> ConsultarXCliente(int id_cliente)
        {
            var vehiculoCliente = new clsVehiculoCliente();
            return vehiculoCliente.ConsultarXCliente(id_cliente);
        }

        [HttpGet]
        [Route("ConsultarXMatricula")]
        public List<Vehiculo_Cliente> ConsultarXMatricula(string matricula)
        {
            var vehiculoCliente = new clsVehiculoCliente();
            return vehiculoCliente.ConsultarXMatricula(matricula);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Vehiculo_Cliente vehiculoCliente)
        {
            var vehiculoClienteClass = new clsVehiculoCliente();
            vehiculoClienteClass.vehiculoCliente = vehiculoCliente;
            return vehiculoClienteClass.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vehiculo_Cliente vehiculoCliente)
        {
            var vehiculoClienteClass = new clsVehiculoCliente();
            vehiculoClienteClass.vehiculoCliente = vehiculoCliente;
            return vehiculoClienteClass.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(string Matricula)
        {
            var vehiculoClienteClass = new clsVehiculoCliente();
            return vehiculoClienteClass.Eliminar(Matricula);
        }
    }
}