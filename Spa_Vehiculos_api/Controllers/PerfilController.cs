using Spa_Vehiculos_api.Clases;
using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Spa_Vehiculos_api.Controllers
{
    [RoutePrefix("api/Usuarios")]
    public class UsuariosController : ApiController
    {
        [HttpPost]
        [Route("CrearUsuarios")]
        [Authorize]
        public string CrearUsuarios([FromBody] Perfil perfil, int idPerfil)
        {
            clsPerfil _Perfil = new clsPerfil();
            _Perfil.perfil = perfil;
            return _Perfil.CrearUsuario(idPerfil);
        }
    }
}