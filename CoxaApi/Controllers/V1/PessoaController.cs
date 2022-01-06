using Commom;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace Application.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [SwaggerResponse(409, "Domain Exception", typeof(string))]
        public async Task<ActionResult<int>> PostPessoaAsync(Pessoa pessoa)
        {
            try
            {
                var id = await _pessoaService.PostPessoaAsync(pessoa);

                return Ok(id);
            }
            catch (DomainException erro)
            {
                return Conflict(erro.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Pessoa))]
        public async Task<ActionResult<Pessoa>> GetPessoa()
        {
            return Ok(new Pessoa { IdPessoa = 1, Nome = "Coxa", DataNascimento = DateTime.Now });
        }
    }
}
