using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsVehiculoCliente
    {
        private SpaVehicularEntities dbSpaVehicular = new SpaVehicularEntities();
        public VEHICULO_CLIENTE vehiculoCliente { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpaVehicular.VEHICULO_CLIENTE.Add(vehiculoCliente);
                dbSpaVehicular.SaveChanges();
                return "Vehículo cliente insertado correctamente";
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
                VEHICULO_CLIENTE vehiculo = Consultar(vehiculoCliente.id_vehiculo);
                if (vehiculo == null)
                {
                    return "No se encontró el vehículo cliente";
                }
                dbSpaVehicular.VEHICULO_CLIENTE.AddOrUpdate(vehiculoCliente);
                dbSpaVehicular.SaveChanges();
                return "Vehículo cliente actualizado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public VEHICULO_CLIENTE Consultar(int id_vehiculo)
        {
            VEHICULO_CLIENTE vehiculo = dbSpaVehicular.VEHICULO_CLIENTE.FirstOrDefault(v => v.id_vehiculo == id_vehiculo);
            return vehiculo;
        }

        public List<VEHICULO_CLIENTE> ConsultarTodos()
        {
            return dbSpaVehicular.VEHICULO_CLIENTE.ToList();
        }

        public List<VEHICULO_CLIENTE> ConsultarXCliente(int id_cliente)
        {
            return dbSpaVehicular.VEHICULO_CLIENTE.Where(v => v.id_cliente == id_cliente).ToList();
        }

        public List<VEHICULO_CLIENTE> ConsultarXMatricula(string matricula)
        {
            return dbSpaVehicular.VEHICULO_CLIENTE.Where(m => m.matricula == matricula).ToList();
        }

        public string Eliminar(int id_vehiculo)
        {
            try
            {
                VEHICULO_CLIENTE vehiculo = Consultar(id_vehiculo);
                if (vehiculo == null)
                {
                    return "No se encontró el vehículo cliente";
                }
                dbSpaVehicular.VEHICULO_CLIENTE.Remove(vehiculo);
                dbSpaVehicular.SaveChanges();
                return "Vehículo cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}