using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsFactura
    {
        private SpaVehicularEntities dbSpaVehicular = new SpaVehicularEntities();
        public Factura factura { get; set; }

        public string Insertar()
        {
            try
            {
                dbSpaVehicular.Facturas.Add(factura);
                dbSpaVehicular.SaveChanges();
                return "Factura insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la factura: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                Factura fac = Consultar(factura.ID_Factura);
                if (fac == null)
                {
                    return "Factura no existe";
                }
                dbSpaVehicular.Facturas.AddOrUpdate(factura);
                dbSpaVehicular.SaveChanges();
                return "Factura actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la factura: " + ex.Message;
            }
        }

        public Factura Consultar(int id_Factura)
        {
            Factura fac = dbSpaVehicular.Facturas.FirstOrDefault(e => e.ID_Factura == id_Factura);
            return fac;
        }

        public List<Factura> ConsultarTodos()
        {
            return dbSpaVehicular.Facturas.ToList();
        }

        public List<Factura> ConsultarXCliente(int id_Cliente)
        {
            return dbSpaVehicular.Facturas
                .Where(f => f.Cliente == id_Cliente)
                .OrderBy(f => f.Fecha_Emision)
                .ToList();
        }

        public List<Factura> ConsultarXId(int id_Factura)
        {
            return dbSpaVehicular.Facturas
                .Where(f => f.ID_Factura == id_Factura)
                .OrderBy(f => f.Fecha_Emision)
                .ToList();
        }
        public string Eliminar()
        {
            try
            {
                Factura fac = Consultar(factura.ID_Factura);
                if (fac == null)
                {
                    return "Factura no existe";
                }
                dbSpaVehicular.Facturas.Remove(fac);
                dbSpaVehicular.SaveChanges();
                return "Factura eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la factura: " + ex.Message;
            }
        }

        public string EliminarXId(int id_Factura)
        {
            try
            {
                Factura fac = Consultar(id_Factura);
                if (fac == null)
                {
                    return "Factura no existe";
                }
                dbSpaVehicular.Facturas.Remove(fac);
                dbSpaVehicular.SaveChanges();
                return "Factura eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la factura: " + ex.Message;
            }
        }
    }
}