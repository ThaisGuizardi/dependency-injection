namespace DependencyInjection.Api;

public class Aluno
{
    private readonly INotaAluno _notaAluno;

    public Aluno(INotaAluno notaAluno)
    {
        _notaAluno = notaAluno;
    }

    public void VerNotaAluno()
    {
        _notaAluno.NotaMatematica("Antônio");

        _notaAluno.NotaPortugues("Rosa");
    }
}
