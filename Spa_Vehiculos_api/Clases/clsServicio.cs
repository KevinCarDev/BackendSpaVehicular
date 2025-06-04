using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsServicio
    {
        private SpaVehicularEntities dbSpa = new SpaVehicularEntities();
        public Servicio servicio { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpa.Servicios.Add(servicio);
                dbSpa.SaveChanges();
                return "Servicio insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el servicio: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Servicio ser = Consultar(servicio.ID_Servicio);
                if (ser == null)
                {
                    return "Servicio no existe";
                }
                dbSpa.Servicios.AddOrUpdate(servicio);
                dbSpa.SaveChanges();
                return "Servicio actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el servicio: " + ex.Message;
            }
        }
        public Servicio Consultar(int id_Servicio)
        {
            Servicio ser = dbSpa.Servicios.FirstOrDefault(e => e.ID_Servicio == id_Servicio);
            return ser;
        }
        public string Eliminar()
        {
            try
            {
                Servicio ser = Consultar(servicio.ID_Servicio);
                if (ser == null)
                {
                    return "Servicio no existe";
                }
                dbSpa.Servicios.Remove(ser);
                dbSpa.SaveChanges();
                return "Servicio eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el servicio: " + ex.Message;
            }
        }
        public string EliminarXId(int id_Servicio)
        {
            try
            {
                Servicio ser = Consultar(id_Servicio);
                if (ser == null)
                {
                    return "Servicio no existe";
                }
                dbSpa.Servicios.Remove(ser);
                dbSpa.SaveChanges();
                return "Servicio eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el servicio: " + ex.Message;
            }
        }
    }
}