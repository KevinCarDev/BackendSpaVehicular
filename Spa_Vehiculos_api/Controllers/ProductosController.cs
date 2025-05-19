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
        public List<PRODUCTO> ConsultarTodos()
        {
            clsProducto Producto = new clsProducto();
            return Producto.ConsultarTodos();
        }
        [HttpGet]
        [Route("Consultar")]
        public PRODUCTO Consultar(int CodigoProducto)
        {
            clsProducto Producto = new clsProducto();
            return Producto.Consultar(CodigoProducto);
        }
        [HttpGet]
        [Route("ConsultarXTipoProducto")]
        public List<PRODUCTO> ConsultarXTipoProducto(int TipoProducto)
        {
            clsProducto Producto = new clsProducto();
            return Producto.ConsultarXTipo(TipoProducto);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] PRODUCTO producto)
        {
            clsProducto Producto = new clsProducto();
            Producto.producto = producto;
            return Producto.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] PRODUCTO producto)
        {
            clsProducto Producto = new clsProducto();
            Producto.producto = producto;
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