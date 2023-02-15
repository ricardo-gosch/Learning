using HelloWorld.Helpers;
using HelloWorld.Models;

namespace HelloWorld.Exercicios;

public class Exercicio01
{
    public static void Run()
    {
        string nome = ConsoleExtensions.ReadLine("Digite seu Nome: ");

        int idade = int.Parse(ConsoleExtensions.ReadLine("Digite sua Idade: "));

        Console.WriteLine("Digite seu Endereço");
        string endereco = Console.ReadLine();

        Pessoa pessoa = new Pessoa(nome, idade, endereco);

        Console.WriteLine("Insira um novo Nome");
        pessoa.DefinirNome(Console.ReadLine());

        Console.WriteLine("Insira uma nova Idade");
        pessoa.DefinirIdade(int.Parse(Console.ReadLine()));

        Console.WriteLine("Insira um novo Endereço");
        pessoa.DefinirEndereco(Console.ReadLine());

        Console.WriteLine($"\n{pessoa.Nome}\n{pessoa.Idade}\n{pessoa.Endereco}");


    }
}
