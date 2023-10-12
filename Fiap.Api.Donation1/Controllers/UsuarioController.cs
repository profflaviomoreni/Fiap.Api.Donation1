using Fiap.Api.Donation1.Models;
using Fiap.Api.Donation1.Repository.Interface;
using Fiap.Api.Donation1.Services;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository _usuarioRepository)
        {
            usuarioRepository = _usuarioRepository;        
        }


        [HttpGet]
        public async Task<ActionResult<IList<UsuarioModel>>> Get()
        {
            var usuarios = await usuarioRepository.FindAll();

            if ( usuarios == null || usuarios.Count == 0) { 
                return NoContent();
            } else
            {
                return Ok(usuarios);
            }

        }


        [HttpGet("{id:int}")]
        public ActionResult<UsuarioModel> Get(int id)
        {
            var usuario = usuarioRepository.FindById(id);

            if ( usuario == null || usuario.UsuarioId == 0)
            {
                return NotFound();
            } else
            {
                return Ok(usuario);
            }

           
        }

        [HttpPost]
        public ActionResult<UsuarioModel> Post([FromBody] UsuarioModel usuarioModel)
        {
            if ( ! ModelState.IsValid )
            {
                return BadRequest(ModelState);
            } 

            try { 
                
                usuarioRepository.Insert(usuarioModel);

                var url = Request.GetEncodedUrl().EndsWith("/") ? 
                                                Request.GetEncodedUrl() : 
                                                Request.GetEncodedUrl() + "/";

                var location = new Uri(url + usuarioModel.UsuarioId);


                return Created(location, usuarioModel);

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult<UsuarioModel> Put([FromRoute] int id, [FromBody] UsuarioModel usuarioModel)
        {
            if ( ! ModelState.IsValid )
            {
                return BadRequest();
            }

            if ( id != usuarioModel.UsuarioId  )
            {
                return NotFound();
            }


            usuarioRepository.Update(usuarioModel);

            return NoContent();

        }

        [HttpDelete("{id:int}")]
        public ActionResult<int> Delete([FromRoute] int id) {

            if ( id == 0 )
            {
                return BadRequest();
            }

            var usuarioModel = usuarioRepository.FindById(id);

            if ( usuarioModel == null )
            {
                return NotFound();
            } else
            {
                usuarioRepository.Delete(id);
                return NoContent();
            }
            
        }


        [HttpPost]
        [Route("Login")]
        public ActionResult<dynamic> Login([FromBody] UsuarioModel usuarioModel)
        {
            var usuario = usuarioRepository
                .FindByEmailAndSenha( usuarioModel.EmailUsuario, usuarioModel.Senha);

            if ( usuario != null )
            {
                var token = AuthenticationService.GetToken(usuario);
                usuario.Senha = "";

                var usuarioRetorno = new
                {
                    usuario = usuario,
                    token = token
                };


                return Ok(usuarioRetorno);
            } else
            {
                return NotFound();
            }

        }



    }
}
