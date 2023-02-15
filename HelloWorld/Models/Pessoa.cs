namespace HelloWorld.Models
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Endereco { get; private set; }

        public Pessoa(string nome, int idade, string endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

        public void DefinirNome(string nome)
        {
            Nome = nome;
        }

        public void DefinirIdade(int idade)
        {
            Idade = idade;
        }

        public void DefinirEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"Nome:{Nome} Idade:{Idade} Endereço:{Endereco}";
        }
    }
}
