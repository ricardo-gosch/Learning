using HelloWorld.Helpers;
using HelloWorld.Models;

namespace HelloWorld.Exercicios;

class Exercicio02
{
    public static void Run()
    {
        string nome = ConsoleExtensions.ReadLine("Digite seu Nome: ");
        
        int idade = int.Parse(ConsoleExtensions.ReadLine("Digite sua Idade: "));

        string endereco = ConsoleExtensions.ReadLine("Digite seu Endereço: ");

        int matricula = int.Parse(ConsoleExtensions.ReadLine("Digite o número da Matricula: "));

        Aluno aluno = new Aluno(nome, idade, endereco, matricula); 

            
        
        Console.WriteLine($"\n{aluno.Nome}\n{aluno.Idade}\n{aluno.Endereco}\n{aluno.Matricula}");
    }
}
