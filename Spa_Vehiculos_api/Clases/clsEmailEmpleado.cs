using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsEmailEmpleado
    {
        private SpaVehicularEntities dbSpaVehicular = new SpaVehicularEntities();
        public Email_Empleado EmaEmpleado { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpaVehicular.Email_Empleado.Add(EmaEmpleado);
                dbSpaVehicular.SaveChanges();
                return EmaEmpleado.ID_Email.ToString();
            }
            catch (Exception ex)
            {
                return "Error al insertar el Email: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Email_Empleado telfemp = Consultar(EmaEmpleado.ID_Email);
                if (telfemp == null)
                {
                    return "Email no existe";
                }
                dbSpaVehicular.Email_Empleado.AddOrUpdate(EmaEmpleado);
                dbSpaVehicular.SaveChanges();
                return "Telefono actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el Email: " + ex.Message;
            }
        }

        public List<Email_Empleado> ConsultarTodos()
        {
            return dbSpaVehicular.Email_Empleado
                .OrderBy(p => p.ID_Email)
                .ToList();
        }
        public Email_Empleado Consultar(int documento)
        {
            Email_Empleado telf = dbSpaVehicular.Email_Empleado.FirstOrDefault(e => e.ID_Email == documento);
            return telf;
        }
        public string Eliminar()
        {
            try
            {
                Email_Empleado telemp = Consultar(EmaEmpleado.ID_Email);
                if (telemp == null)
                {
                    return "Email no existe";
                }
                dbSpaVehicular.Email_Empleado.Remove(EmaEmpleado);
                dbSpaVehicular.SaveChanges();
                return "Email eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el Email: " + ex.Message;
            }
        }
        public string EliminarXId(int id)
        {
            try
            {
                Email_Empleado clien = Consultar(id);
                if (clien == null)
                {
                    return "Email no existe";
                }
                dbSpaVehicular.Email_Empleado.Remove(EmaEmpleado);
                dbSpaVehicular.SaveChanges();
                return "Email eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el Email: " + ex.Message;
            }
        }
    }
}