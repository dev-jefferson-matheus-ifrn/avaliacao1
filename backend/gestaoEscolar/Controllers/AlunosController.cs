using gestaoEscolar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<IActionResult> Post(Aluno aluno)
        {
            _context.tb_alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = aluno.Id }, aluno);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Aluno aluno)
        {
            if (id != aluno.Id)
            {
                return BadRequest();
            }

            _context.Entry(aluno).State = EntityState.Modified;

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
