using Microsoft.EntityFrameworkCore;

namespace gestaoEscolar;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Aluno>(e =>
        {
            e.Property(e => e.Nome).HasMaxLength(80);
            e.Property(e => e.Email).HasMaxLength(40);
            e.Property(e => e.Curso).HasMaxLength(40);
            e.Property(e => e.DataNascimento);
        });

    }

    public DbSet<Aluno> tb_alunos {get; set;}
}
