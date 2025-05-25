using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsDepartamento
    {
        private SpaVehicularEntities dbSpa = new SpaVehicularEntities();
        public Departamento departamento { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpa.Departamentoes.Add(departamento);
                dbSpa.SaveChanges();
                return "Departamento insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el departamento: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Departamento dep = Consultar(departamento.ID_Departamento);
                if (dep == null)
                {
                    return "Departamento no existe";
                }
                dbSpa.Departamentoes.AddOrUpdate(departamento);
                dbSpa.SaveChanges();
                return "Departamento actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el departamento: " + ex.Message;
            }
        }
        public Departamento Consultar(int id_departamento)
        {
            Departamento dep = dbSpa.Departamentoes.FirstOrDefault(e => e.ID_Departamento == id_departamento);
            return dep;
        }
        public string Eliminar()
        {
            try
            {
                Departamento dep = Consultar(departamento.ID_Departamento);
                if (dep == null)
                {
                    return "Departamento no existe";
                }
                dbSpa.Departamentoes.Remove(dep);
                dbSpa.SaveChanges();
                return "Departamento eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el departamento: " + ex.Message;
            }
        }
        public string EliminarXId(int id_departamento)
        {
            try
            {
                Departamento dep = Consultar(id_departamento);
                if (dep == null)
                {
                    return "Departamento no existe";
                }
                dbSpa.Departamentoes.Remove(dep);
                dbSpa.SaveChanges();
                return "Departamento eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el departamento: " + ex.Message;
            }
        }
    }
}