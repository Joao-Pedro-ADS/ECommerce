using ECommerce.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;


namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuariosController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        //{endereço_site}/api/usuarios

        [HttpGet]
        public IActionResult Get()
        {
            var listaUsuarios = _repository.GetUsuarios();

            return Ok(listaUsuarios);
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var usuario = _repository.Get(id);

            if (usuario == null)
            {
                return NotFound("Não encontrado");
            }

            return Ok(usuario);
        }

        [HttpPost]

        public IActionResult Add([FromBody] ECommerce.Models.Usuario usuario)
        {
            _repository.Add(usuario);

            return Ok(usuario);
        }

        [HttpPut("{id}")]

        public IActionResult Update([FromBody] ECommerce.Models.Usuario usuario, int id)
        {
            _repository.Update(usuario);
            return Ok(usuario);       
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok("Deletado com sucesso");
        }
    }
}
