using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsEmpleado
    {
        private SpaVehicularEntities dbSpaVehicular = new SpaVehicularEntities();
        public Empleado empleado { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpaVehicular.Empleadoes.Add(empleado);
                dbSpaVehicular.SaveChanges();
                return "Empleado insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el empleado: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Empleado emp = Consultar(empleado.ID_Empleado);
                if (emp == null)
                {
                    return "Empleado no existe";
                }
                dbSpaVehicular.Empleadoes.AddOrUpdate(emp);
                dbSpaVehicular.SaveChanges();
                return "Empleado actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el empleado: " + ex.Message;
            }
        }

        public List<Empleado> ConsultarTodos()
        {
            return dbSpaVehicular.Empleadoes
                .OrderBy(p => p.Nombres)
                .ToList();
        }
        public Empleado Consultar(int documento)
        {
            Empleado clien = dbSpaVehicular.Empleadoes.FirstOrDefault(e => e.ID_Empleado == documento);
            return clien;
        }
        public string Eliminar()
        {
            try
            {
                Empleado emp = Consultar(empleado.ID_Empleado);
                if (emp == null)
                {
                    return "Empleado no existe";
                }
                dbSpaVehicular.Empleadoes.Remove(empleado);
                dbSpaVehicular.SaveChanges();
                return "Empleado eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el Empleado: " + ex.Message;
            }
        }
        public string EliminarXId(int Documento)
        {
            try
            {
                Empleado clien = Consultar(Documento);
                if (clien == null)
                {
                    return "Empleado no existe";
                }
                dbSpaVehicular.Empleadoes.Remove(empleado);
                dbSpaVehicular.SaveChanges();
                return "Empleado eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el Empleado: " + ex.Message;
            }
        }
    }
}