using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsCita
    {
        private SpaVehicularEntities dbSpa = new SpaVehicularEntities();
        public Cita cita { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpa.Citas.Add(cita);
                dbSpa.SaveChanges();
                return "Cita insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la cita: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Cita cit = Consultar(cita.ID_Cita);
                if (cit == null)
                {
                    return "La cita no existe";
                }
                dbSpa.Citas.AddOrUpdate(cita);
                dbSpa.SaveChanges();
                return "Cita actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la cita: " + ex.Message;
            }
        }
        public Cita Consultar(int id_Cita)
        {
            Cita cit = dbSpa.Citas.FirstOrDefault(e => e.ID_Cita == id_Cita);
            return cit;
        }
        public List<Cita> ConsultarTodos()
        {
            return dbSpa.Citas.ToList();
        }
        public IQueryable<Cita> ConsultarCitaPorCliente(int clienteId)
        {
            var cita = dbSpa.Citas
                .Where(f => f.Cliente == clienteId);

            return cita;
        }
        public string Eliminar()
        {
            try
            {
                Cita cit = Consultar(cita.ID_Cita);
                if (cit == null)
                {
                    return "La cita no existe";
                }
                dbSpa.Citas.Remove(cit);
                dbSpa.SaveChanges();
                return "Cita eliminada correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar la cita: " + ex.Message;
            }
        }
        public string EliminarXId(int id_Cita)
        {
            try
            {
                Cita cit = Consultar(id_Cita);
                if (cit == null)
                {
                    return "La cita no existe";
                }
                dbSpa.Citas.Remove(cit);
                dbSpa.SaveChanges();
                return "Cita eliminada correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar la cita: " + ex.Message;
            }
        }
    }
}