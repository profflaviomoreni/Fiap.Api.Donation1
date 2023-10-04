using Fiap.Api.Donation1.Models;
using Fiap.Api.Donation1.Repository.Interface;
using Microsoft.AspNetCore.Http;
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
        public IList<UsuarioModel> Get()
        {
            return usuarioRepository.FindAll();
        }

        [HttpGet("{id:int}")]
        public UsuarioModel Get(int id)
        {
            return usuarioRepository.FindById(id);
        }

        [HttpPost]
        public int Post([FromBody] UsuarioModel usuarioModel)
        {
            var retorno = usuarioRepository.Insert(usuarioModel);

            return retorno;
        }

        [HttpPut("{id:int}")]
        public void Post([FromRoute] int id, [FromBody] UsuarioModel usuarioModel)
        {
            usuarioRepository.Update(usuarioModel);
        }

        [HttpDelete("{id:int}")]
        public void Delete([FromRoute] int id) {
            usuarioRepository.Delete(id);
        }


        [HttpPost]
        [Route("Login")]
        public UsuarioModel Login([FromBody] UsuarioModel usuarioModel)
        {
            var usuario = usuarioRepository
                .FindByEmailAndSenha( usuarioModel.EmailUsuario, usuarioModel.Senha);

            return usuario;
        }



    }
}
