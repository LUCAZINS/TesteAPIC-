using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;


namespace TesteApiDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TesteController(OrganizadorContext context)
        {
            _context = context;
        }
        [HttpPost("CriarTarefa")]
        public IActionResult Criar(Teste teste)
        {
            teste.Id = 0;
            if (teste.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data do teste não pode ser vazia" });

            // TODO: Adicionar a tarefa recebida no EF e salvar as mudanças (save changes)
            _context.Teste.Add(teste);
            _context.SaveChanges();
           return CreatedAtAction(nameof(ObterPorId), new { id = teste.Id }, teste);
           
        }
        
        
        [HttpGet("{BuscarPorId}")]
        public IActionResult ObterPorId(int id)
        {
            // TODO: Buscar o Id no banco utilizando o EF
            // TODO: Validar o tipo de retorno. Se não encontrar a tarefa, retornar NotFound,
            // caso contrário retornar OK com a tarefa encontrada

            var tarefa = _context.Tarefas.Find(id);
            if (tarefa == null)
                return NotFound();

            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            // TODO: Buscar todas as tarefas no banco utilizando o EF
            var tarefas = _context.Tarefas.ToList();
            return Ok(tarefas);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o titulo recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            var tarefa = _context.Tarefas.Where(x => x.Titulo.Contains(titulo));
            return Ok(tarefa);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o status recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            var tarefa = _context.Tarefas.Where(x => x.Status == status);
            return Ok(tarefa);
        }


        [HttpPut("EditarPorId")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
            
            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;
            tarefaBanco.Id = id;

            _context.Tarefas.Update(tarefaBanco);  
            _context.SaveChanges();
            
            return Ok(tarefaBanco);
        }

        [HttpDelete("DeletarPorId")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            // TODO: Remover a tarefa encontrada através do EF e salvar as mudanças (save changes)
            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
