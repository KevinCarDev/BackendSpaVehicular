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
    [RoutePrefix("api/Productos")]
    //[Authorize]
    public class ProductosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Producto> ConsultarTodos()
        {
            clsProducto Producto = new clsProducto();
            return Producto.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public List<Producto> ConsultarXId(int Id)
        {
            var Producto = new clsProducto();
            return Producto.ConsultarXId(Id);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Producto producto)
        {
            var Producto = new clsProducto();
            Producto.Producto = producto;
            return Producto.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Producto producto)
        {
            clsProducto Producto = new clsProducto();
            Producto.Producto = producto;
            return Producto.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int CodigoProducto)
        {
            clsProducto Producto = new clsProducto();
            return Producto.Eliminar(CodigoProducto);
        }
    }
}