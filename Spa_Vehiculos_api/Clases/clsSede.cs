using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsSede
    {
        private SpaVehicularEntities dbSpa = new SpaVehicularEntities();
        public Sede sede { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpa.Sedes.Add(sede);
                dbSpa.SaveChanges();
                return "Sede insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la sede: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Sede sed = Consultar(sede.ID_Sede);
                if (sed == null)
                {
                    return "Sede no existe";
                }
                dbSpa.Sedes.AddOrUpdate(sede);
                dbSpa.SaveChanges();
                return "Sede actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la Sede: " + ex.Message;
            }
        }
        public Sede Consultar(int id_Sede)
        {
            Sede sed = dbSpa.Sedes.FirstOrDefault(e => e.ID_Sede == id_Sede);
            return sed;
        }
        public string Eliminar()
        {
            try
            {
                Sede ciu = Consultar(sede.ID_Sede);
                if (ciu == null)
                {
                    return "Sede no existe";
                }
                dbSpa.Sedes.Remove(ciu);
                dbSpa.SaveChanges();
                return "Sede eliminada correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar la Sede: " + ex.Message;
            }
        }
        public string EliminarXId(int id_Sede)
        {
            try
            {
                Sede sed = Consultar(id_Sede);
                if (sed == null)
                {
                    return "Sede no existe";
                }
                dbSpa.Sedes.Remove(sed);
                dbSpa.SaveChanges();
                return "Sede eliminada correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar la Sede: " + ex.Message;
            }
        }
    }
}