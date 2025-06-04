using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsTelefEmpleado
    {
        private SpaVehicularEntities dbSpaVehicular = new SpaVehicularEntities();
        public Telefono_Empleado TelfEmpleado { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpaVehicular.Telefono_Empleado.Add(TelfEmpleado);
                dbSpaVehicular.SaveChanges();
                return TelfEmpleado.ID_Telefono.ToString();
            }
            catch (Exception ex)
            {
                return "Error al insertar el Telefono: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Telefono_Empleado telfemp = Consultar(TelfEmpleado.ID_Telefono);
                if (telfemp == null)
                {
                    return "Telefono no existe";
                }
                dbSpaVehicular.Telefono_Empleado.AddOrUpdate(TelfEmpleado);
                dbSpaVehicular.SaveChanges();
                return "Telefono actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el Telefono: " + ex.Message;
            }
        }

        public List<Telefono_Empleado> ConsultarTodos()
        {
            return dbSpaVehicular.Telefono_Empleado
                .OrderBy(p => p.ID_Telefono)
                .ToList();
        }
        public Telefono_Empleado Consultar(int documento)
        {
            Telefono_Empleado telf = dbSpaVehicular.Telefono_Empleado.FirstOrDefault(e => e.ID_Telefono == documento);
            return telf;
        }
        public string Eliminar()
        {
            try
            {
                Telefono_Empleado telemp = Consultar(TelfEmpleado.ID_Telefono);
                if (telemp == null)
                {
                    return "Telefono no existe";
                }
                dbSpaVehicular.Telefono_Empleado.Remove(TelfEmpleado);
                dbSpaVehicular.SaveChanges();
                return "Telefono eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el Telefono: " + ex.Message;
            }
        }
        public string EliminarXId(int id)
        {
            try
            {
                Telefono_Empleado clien = Consultar(id);
                if (clien == null)
                {
                    return "Telefono no existe";
                }
                dbSpaVehicular.Telefono_Empleado.Remove(TelfEmpleado);
                dbSpaVehicular.SaveChanges();
                return "Telefono eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el Telefono: " + ex.Message;
            }
        }
    }
}