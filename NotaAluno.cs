namespace DependencyInjection.Api;

public class NotaAluno : INotaAluno
{
    public void NotaMatematica(string nomeAluno)
    {
        Console.WriteLine($"Aluno {nomeAluno} nota de matemática igual a 7.5.");
    }

    public void NotaPortugues(string nomeAluno)
    {
        Console.WriteLine($"Aluno {nomeAluno} nota de português igual a 6.0.");
    }
}
