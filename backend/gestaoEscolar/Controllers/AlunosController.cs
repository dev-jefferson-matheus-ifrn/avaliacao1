using gestaoEscolar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AlunosController : ControllerBase
    {

        private readonly AppDbContext _context;

        public AlunosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _context.tb_alunos;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var aluno = await _context.tb_alunos.FindAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            return Ok(aluno);
        }


        [HttpPost]
        public async Task<IActionResult> Post(AlunoRequestDTO alunoDto)
        {
            var aluno = new Aluno
            {
                Nome = alunoDto.Nome,
                Curso = alunoDto.Curso,
                Email = alunoDto.Email,
                DataNascimento = alunoDto.DataNascimento
            };

            _context.tb_alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = aluno.Id }, aluno);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, AlunoRequestDTO alunoDto)
        {
            var alunoExistente = await _context.tb_alunos.FindAsync(id);

            if (alunoExistente == null)
            {
                return NotFound(); 
            }

            alunoExistente.Nome = alunoDto.Nome;
            alunoExistente.Email = alunoDto.Email;
            alunoExistente.Curso = alunoDto.Curso;
            alunoExistente.DataNascimento = alunoDto.DataNascimento;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.tb_alunos.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var aluno = await _context.tb_alunos.FindAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }

            _context.tb_alunos.Remove(aluno);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
