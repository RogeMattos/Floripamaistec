using Escola.Dtos;
using Escola.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    
    [HttpGet]
    public IActionResult Listar(string nome)
    {
        var repository = new AlunosRepository();
        var Alunos = repository.ListarAluno(nome);

        return Ok(Alunos);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Obter(int id)
    {

        if (id <= 0)
            return BadRequest("Id deve ser maior que zero");

        var repository = new AlunosRepository();
        var Alunos = repository.ObterAluno(id);

        if (Alunos == null)
            return NotFound();

        return Ok(Alunos);
    }

     [HttpPost]
    public IActionResult Criar([FromBody] AlunoDto dto)
    {
       
       var repository = new AlunosRepository();
       var Alunos = repository.CriarAluno(dto);
       return CreatedAtAction(nameof(AlunoController.Obter),  new { id = Alunos.id }, Alunos);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Excluir(int id)
    {
       
       var repository = new AlunosRepository();
       repository.ExcluirAluno(id);

       return NoContent();
    }

}   