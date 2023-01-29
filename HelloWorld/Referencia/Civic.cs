namespace HelloWorld.Referencia
{
    public class Civic : Veiculo, IVeiculoTransporte
    {

        public int CalcularAutonomia()
        {
            return 400;
        }

        public void CalcularConsumo()
        {
            Console.WriteLine("1");
        }

        public decimal CalcularPrecoLocacao()
        {
            return 1000;
        }

        public override void MostrarConsumo()
        {
            throw new NotImplementedException();
        }

        public int PeriodoManutencao()
        {
            return 50;
        }

        public void VeiculoDisponivel(bool disponibilidade)
        {
            EstaDisponivel = disponibilidade;
        }
    }
}
