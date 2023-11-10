

using hotel.api.Model.Usuario;
using hotel.api.Modules.Usuario;
using hotel.domino.Entities;
using hotel.domino.repository;
using hotel.infractructure.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hotel.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorys usuarioRepositorys;

        public UsuarioController(IUsuarioRepository usuarioRepositorys)
        {
            this.usuarioRepositorys = usuarioRepositorys;
        }

        // GET: api/<UsuarioController  

        [HttpGet("GetUsuarios")]
        public IActionResult Get()
        {
            var Usuario = this.usuarioRepositorys.GetTEntities()
                                                .Select(st => new
                                                      GetUsuarioModel()
                                                {
                                                    IdUsuario = st.IdUsuario,
                                                    Nombrecompleto = st.NombreCompleto,
                                                    FechaCreacion = st.FechaCreacion,
                                                    FechaRegistro = st.FechaRegistro,
                                                    Estado = st.Estado,
                                                });



            return Ok(Usuario);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("GetUsuario")]
        public IActionResult Get(int id)
        {
            var Usuario = this.usuarioRepositorys.GetEntity(id);

            GetUsuarioModel usuarioModel = new GetUsuarioModel()
            {
                
                Nombrecompleto = Usuario.NombreCompleto,
                FechaCreacion = Usuario.FechaCreacion,
                FechaRegistro = Usuario.FechaRegistro,
                Estado = Usuario.Estado,
            };

            return Ok(usuarioModel);
        }

        // POST api/<UsuarioController>
        [HttpPost("saveUsuario")]
        public IActionResult Post([FromBody] UsuarioAppModel usuarioAppModel)
        {
            this.usuarioRepositorys.Save(new Usuario()
            {
                FechaCreacion = usuarioAppModel.FechaCreacion,
                FechaRegistro = usuarioAppModel.FechaRegistro,
                IdUsuarioCreacion = usuarioAppModel.IdUsuarioCreacion,
                NombreCompleto = usuarioAppModel.FirstName
            });
            return Ok();
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("UpdateUsuario")]
        public IActionResult Put([FromBody] UsuarioUpdate usuarioUpdate)
        {
            this.usuarioRepositorys.Save(new Usuario()
            {
                IdUsuarioMod = usuarioUpdate.IdUsuarioMod,
                FechaRegistro = usuarioUpdate.FechaRegistro,
                FechaMod = usuarioUpdate.FechaMod,
                NombreCompleto = usuarioUpdate.FirstName,
                IdUsuario = usuarioUpdate.IdUsuario
            });

            return Ok();    

        }

    }
}
