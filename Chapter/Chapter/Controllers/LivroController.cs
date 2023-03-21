using Chapter.Models;
using Chapter.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;




namespace Chapter.Controllers
{
    [Produces("application/json")]


    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1")]

    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]

        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        /*
        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.Ler());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            } 

        }*/
        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Livro livro = _livroRepository.BuscarPorId(id);

                if (livro == null)
                {
                    return NotFound();
                }
                return Ok(livro);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        }

        [HttpPost]

        public IActionResult Cadastrar(Livro livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro);
                return Ok(livro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        [HttpPut]

        public IActionResult Atualizar(int id, Livro livro)
        {
            try
            {
                _livroRepository.Atualizar(id, livro);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        [HttpDelete]

        public IActionResult Deletar(int id)
        {
            try
            {
                _livroRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
