using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsProducto
    {

        private SpaVehicularEntities dbSpaVehicular = new SpaVehicularEntities();
        public PRODUCTO producto { get; set; }

        public string Insertar()
        {
            try
            {
                dbSpaVehicular.PRODUCTOes.Add(producto);
                dbSpaVehicular.SaveChanges();
                return "Producto insertado correctamente";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                PRODUCTO prod = Consultar(producto.id_producto);
                if (prod == null)
                {
                    return "No se encontró el producto";
                }
                dbSpaVehicular.PRODUCTOes.AddOrUpdate(producto);
                dbSpaVehicular.SaveChanges();
                return "Producto actualizado correctamente";

            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public PRODUCTO Consultar(int id_producto)
        {
            PRODUCTO prod = dbSpaVehicular.PRODUCTOes.FirstOrDefault(p => p.id_producto == id_producto);
            return prod;
        }

        public List<PRODUCTO> ConsultarTodos()
        {
            return dbSpaVehicular.PRODUCTOes
                .OrderBy(p => p.nombre_producto)
                .ToList();
        }

        public List<PRODUCTO> ConsultarXTipo(int id_producto)
        {
            return dbSpaVehicular.PRODUCTOes
                .Where(p => p.id_producto == id_producto)
                .OrderBy(p => p.nombre_producto)
                .ToList();
        }

        public string Eliminar(int id_producto)
        {
            try
            {
                PRODUCTO prod = Consultar(id_producto);
                if (prod == null)
                {
                    return "El producto no existe";
                }
                dbSpaVehicular.PRODUCTOes.Remove(prod);
                dbSpaVehicular.SaveChanges();
                return "Producto eliminado correctamente";

            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }


    }

}