using Spa_Vehiculos_api.Clases;
using Spa_Vehiculos_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Spa_Vehiculos_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Perfiles")]
    public class UsuariosController : ApiController
    {
        [HttpPost]
        [Route("CrearUsuarios")]
        //[Authorize]
        public string CrearUsuarios([FromBody] Perfil perfil)
        {
            clsPerfil _Perfil = new clsPerfil();
            _Perfil.perfil = perfil;
            return _Perfil.CrearUsuario();
        }
    }
}