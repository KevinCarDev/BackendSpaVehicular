using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spa_Vehiculos_api.Clases
{
    public class clsPerfil
    {
        private SpaVehicularEntities dbSpa = new SpaVehicularEntities();
        public Perfil perfil { get; set; }

        public string CrearUsuario()
        {
            try
            {
                // Asegurarse de que el empleado existe
                var empleado = dbSpa.Empleadoes.Find(perfil.ID_Empleado);
                if (empleado == null)
                {
                    return "Error: El empleado no existe.";
                }

                dbSpa.Perfils.Add(perfil);
                dbSpa.SaveChanges();
                return "Se creó el usuario exitosamente";
            }
            catch (Exception ex)
            {
                return "Error al crear usuario: " + ex.Message;
            }
        }
    }
}