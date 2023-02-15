namespace HelloWorld.Models;

public class Aluno : Pessoa
{
    public int Matricula {get; set;}

    public Aluno(string nome, int idade, string endereco, int matricula) : base (nome, idade, endereco)
    {
        Matricula = matricula;
    }

    public void DefinirMatricula(int matricula)
    {
        Matricula = matricula;
    }
}