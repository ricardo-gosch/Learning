namespace HelloWorld.Referencia
{
    public class Pessoa : SerVivo
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _nome = value;
            }
        }







        public string Sobrenome;
        public DateTime DataNascimento;
        public double Peso;
        public double Altura;
        public double Salario;
        public int CalcularIdade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }


        public string CalcularIMC()
        {

            double resultado = Peso / Math.Pow(Altura, 2);
            var descricao = resultado switch
            {
                < 18.5 => "MAGREZA",
                >= 18.5 and < 24.9 => "NORMAL",
                >= 25.0 and < 29.9 => "SOBREPESO",
                >= 30 and < 39.9 => "OBESIDADE",
                > 40 => "OBESIDADE GRAVE",
                _ => "IMPOSSÍVEL CALCULAR IMC"
            };
            return descricao;
        }
        public double AumentarSalario(double x)
        {
            double resultado = Salario * (x / 100);
            Salario += resultado;
            return Salario;
        }

        public string NomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }

    }
}
