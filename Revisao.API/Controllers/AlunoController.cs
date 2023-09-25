using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunosServices _Alunosservices;

        public AlunoController(IAlunosServices alunosServices)
        {
            _Alunosservices = alunosServices;
        }

        [HttpGet(Name = "Adicionar")]
        public IActionResult Post(NovoAlunoViewModel alunoViewModel)
        {
            _Alunosservices.Adicionar(alunoViewModel);
            return Ok();
        }
    }
}
