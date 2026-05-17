namespace gestaoEscolar;

public class AlunoRequestDTO
{
    public required string Nome { get; set; }
    public required string Email { get; set; }

    public required String Curso { get; set; }
    public DateTime DataNascimento { get; set; }
}
