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
        public string CrearUsuario(int idPerfil)
        {
            try
            {
                dbSpa.Perfils.Add(perfil);
                dbSpa.SaveChanges();
                Empleado emplPerfil = new Empleado();
                emplPerfil.ID_Empleado = perfil.ID_Empleado;
                dbSpa.Empleadoes.Add(emplPerfil);
                dbSpa.SaveChanges();
                return "Se creó el usuario exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}