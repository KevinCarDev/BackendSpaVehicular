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
        public Vehiculo_Cliente vehiculoCliente { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpaVehicular.Vehiculo_Cliente.Add(vehiculoCliente);
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
                Vehiculo_Cliente vehiculo = Consultar(vehiculoCliente.Matricula);
                if (vehiculo == null)
                {
                    return "No se encontró el vehículo cliente";
                }
                dbSpaVehicular.Vehiculo_Cliente.AddOrUpdate(vehiculoCliente);
                dbSpaVehicular.SaveChanges();
                return "Vehículo cliente actualizado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Vehiculo_Cliente Consultar(string Matricula)
        {
            Vehiculo_Cliente vehiculo = dbSpaVehicular.Vehiculo_Cliente.FirstOrDefault(v => v.Matricula == Matricula);
            return vehiculo;
        }

        public List<Vehiculo_Cliente> ConsultarTodos()
        {
            return dbSpaVehicular.Vehiculo_Cliente.ToList();
        }

        public List<Vehiculo_Cliente> ConsultarXCliente(int Documento)
        {
            return dbSpaVehicular.Vehiculo_Cliente.Where(v => v.Documento == Documento).ToList();
        }

        public List<Vehiculo_Cliente> ConsultarXMatricula(string Matricula)
        {
            return dbSpaVehicular.Vehiculo_Cliente.Where(m => m.Matricula == Matricula).ToList();
        }

        public string Eliminar(string Matricula)
        {
            try
            {
                Vehiculo_Cliente vehiculo = Consultar(Matricula);
                if (vehiculo == null)
                {
                    return "No se encontró el vehículo cliente";
                }
                dbSpaVehicular.Vehiculo_Cliente.Remove(vehiculo);
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