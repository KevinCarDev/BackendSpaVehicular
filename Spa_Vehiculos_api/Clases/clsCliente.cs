using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsCliente
    {
        private SpaVehicularEntities dbSpaVehicular = new SpaVehicularEntities();
        public Cliente cliente { get; set; }
        public string Insertar()
        {
            try
            {
                dbSpaVehicular.Clientes.Add(cliente);
                dbSpaVehicular.SaveChanges();
                return "Cliente insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el cliente: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Cliente clien = Consultar(cliente.Documento);
                if (clien == null)
                {
                    return "Cliente no existe";
                }
                dbSpaVehicular.Clientes.AddOrUpdate(cliente);
                dbSpaVehicular.SaveChanges();
                return "Cliente actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el cliente: " + ex.Message;
            }
        }
        public Cliente Consultar(int documento)
        {
            Cliente clien = dbSpaVehicular.Clientes.FirstOrDefault(e => e.Documento == documento);
            return clien;
        }
        public string Eliminar()
        {
            try
            {
                Cliente clien = Consultar(cliente.Documento);
                if (clien == null)
                {
                    return "Cliente no existe";
                }
                dbSpaVehicular.Clientes.Remove(clien);
                dbSpaVehicular.SaveChanges();
                return "Cliente eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente: " + ex.Message;
            }
        }
        public string EliminarXId(int Documento)
        {
            try
            {
                Cliente clien = Consultar(Documento);
                if (clien == null)
                {
                    return "Cliente no existe";
                }
                dbSpaVehicular.Clientes.Remove(clien);
                dbSpaVehicular.SaveChanges();
                return "Cliente eliminado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente: " + ex.Message;
            }
        }
    }
}