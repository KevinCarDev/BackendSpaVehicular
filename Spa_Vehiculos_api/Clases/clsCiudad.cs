using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsCiudad
    {
        private SpaVehicularEntities dbSpaVehicular = new SpaVehicularEntities();
        public Ciudad ciudad { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpaVehicular.Ciudads.Add(ciudad);
                dbSpaVehicular.SaveChanges();
                return "Ciudad insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la ciudad: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Ciudad ciu = Consultar(ciudad.ID_Ciudad);
                if (ciu == null)
                {
                    return "Ciudad no existe";
                }
                dbSpaVehicular.Ciudads.AddOrUpdate(ciudad);
                dbSpaVehicular.SaveChanges();
                return "Ciudad actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la ciudad: " + ex.Message;
            }
        }
        public Ciudad Consultar(int id_Ciudad)
        {
            Ciudad ciu = dbSpaVehicular.Ciudads.FirstOrDefault(e => e.ID_Ciudad == id_Ciudad);
            return ciu;
        }
        public string Eliminar()
        {
            try
            {
                Ciudad ciu = Consultar(ciudad.ID_Ciudad);
                if (ciu == null)
                {
                    return "Ciudad no existe";
                }
                dbSpaVehicular.Ciudads.Remove(ciu);
                dbSpaVehicular.SaveChanges();
                return "Ciudad eliminada correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar la Ciudad: " + ex.Message;
            }
        }
        public string EliminarXId(int id_Ciudad)
        {
            try
            {
                Ciudad dep = Consultar(id_Ciudad);
                if (dep == null)
                {
                    return "Ciudad no existe";
                }
                dbSpaVehicular.Ciudads.Remove(dep);
                dbSpaVehicular.SaveChanges();
                return "Ciudad eliminada correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar la Ciudad: " + ex.Message;
            }
        }
    }
}