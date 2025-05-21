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
        public Producto Producto { get; set; }

        public string Insertar()
        {
            try
            {
                dbSpaVehicular.Productoes.Add(Producto);
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
                Producto prod = Consultar(Producto.ID_Producto);
                if (prod == null)
                {
                    return "No se encontró el Producto";
                }
                dbSpaVehicular.Productoes.AddOrUpdate(Producto);
                dbSpaVehicular.SaveChanges();
                return "Producto actualizado correctamente";

            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public Producto Consultar(int ID_Producto)
        {
            Producto prod = dbSpaVehicular.Productoes.FirstOrDefault(p => p.ID_Producto == ID_Producto);
            return prod;
        }

        public List<Producto> ConsultarTodos()
        {
            return dbSpaVehicular.Productoes
                .OrderBy(p => p.Nombre)
                .ToList();
        }

        public List<Producto> ConsultarXId(int ID_Producto)
        {
            return dbSpaVehicular.Productoes
                .Where(p => p.ID_Producto == ID_Producto)
                .OrderBy(p => p.Nombre)
                .ToList();
        }

        public string Eliminar(int ID_Producto)
        {
            try
            {
                Producto prod = Consultar(ID_Producto);
                if (prod == null)
                {
                    return "El Producto no existe";
                }
                dbSpaVehicular.Productoes.Remove(prod);
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